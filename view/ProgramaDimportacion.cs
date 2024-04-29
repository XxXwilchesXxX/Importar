using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using MySql.Data.MySqlClient;
using Importar.DAL;
using Importar.VIEW;



namespace Importar
{
    public partial class software : Form
    {
    

        public DataGridView DgvCuadriculaDeDatos { get; private set; }



        public software()
        {
            InitializeComponent();

      
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            importador objetoDeImportacion = new Importar.VIEW.importador();
            int numFilas;

            DataTable dt = objetoDeImportacion.Importarcsv(out numFilas);

            if (dt != null)
            {
                Dgv_cuadriculaDedatos.DataSource = dt;
                lblFilasImportadas.Text = $"Filas importadas: {numFilas}";
            }
            else
            {
                lblFilasImportadas.Text = "No se importaron datos";
            }
        }


        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            int numDatos;

            if (int.TryParse(txtNumeroDatos.Text, out numDatos) && numDatos > 0)
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;

                worker.DoWork += (s, ev) =>
                {
                    SubirDatosDB subirDatosDB = new Importar.DAL.SubirDatosDB();

                    subirDatosDB.SubirDatos(Dgv_cuadriculaDedatos, numDatos, percent =>
                    {
                        worker.ReportProgress(percent);
                    });
                };

                worker.ProgressChanged += (s, ev) =>
                {
                    prgbProcessing.Value = ev.ProgressPercentage;
                    lblProcessing.Text = $"Subiendo datos... {ev.ProgressPercentage}%";
                };

                worker.RunWorkerCompleted += (s, ev) =>
                {
                    prgbProcessing.Value = 0;
                    lblProcessing.Text = "Completado";
                    MessageBox.Show("Datos subidos con éxito");
                };

                prgbProcessing.Visible = true;
                lblProcessing.Visible = true;

                worker.RunWorkerAsync(); 
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para la cantidad de datos a subir.");
            }
        }


        private void btnDatonuevo_Click(object sender, EventArgs e)
        {
            AgregarDatos nuevoForm = new AgregarDatos(Dgv_cuadriculaDedatos, lblFilasImportadas);
            if (nuevoForm.ShowDialog() == DialogResult.OK)
            {
      
            }
        }
    }
}










