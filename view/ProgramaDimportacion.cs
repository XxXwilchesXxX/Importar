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



namespace Importar
{
    public partial class software : Form
    {



        public software()
        {
            InitializeComponent();

      
        }




        private void btnImportar_Click(object sender, EventArgs e)
        {


            controllerImportar objetoDeImportacion = new DAL.controllerImportar();
            DataTable dt = objetoDeImportacion.Importarcsv();



            if (dt != null)
            {
                // Asignar el DataTable al DataGridView
                Dgv_cuadriculaDedatos.DataSource = dt;
            }

        }



        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            // Asumiendo que el TextBox donde se ingresa el número de datos se llama txtNumeroDatos
            int numDatos;

            // Intentar convertir el valor del TextBox a un número entero
            if (int.TryParse(txtNumeroDatos.Text, out numDatos) && numDatos > 0)
            {
                // Crear instancia de SubirDatosDB
                SubirDatosDB objetoDeSubirDatosDB = new DAL.SubirDatosDB();

                // Llamar al método SubirDatos con el DataGridView y el número de datos a subir
                objetoDeSubirDatosDB.SubirDatos(Dgv_cuadriculaDedatos, numDatos);
            }
            else
            {
                // Si la conversión falla o el número es inválido, mostrar un mensaje de error
                MessageBox.Show("Ingrese un número válido para la cantidad de datos a subir.");
            }
        }

    }

}




