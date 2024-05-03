using System.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Importar.DAL;
using Importar.VIEW;



namespace Importar
{
    public partial class software : Form
    {

        private ConexionSqlserver_DAL conexionSqlserver; // Asegúrate de tener esta declaración
        private DataGridViewRow selectedRow;

        public software()
        {
            InitializeComponent();
            conexionSqlserver = new ConexionSqlserver_DAL();
            // Aplicar configuración al DataGridView
            importador_VIEW.ConfigurarDataGridView(Dgv_cuadriculaDedatos);
        }



        //Funcion del boton de IMPORTAR
        private void btnImportar_Click(object sender, EventArgs e)
        {
            importador_VIEW importador = new importador_VIEW();
            int numFilas;
            DataTable dt = importador.Importarcsv(out numFilas);

            if (dt != null)
            {
                Dgv_cuadriculaDedatos.DataSource = dt;
                importador_VIEW.ConfigurarDataGridView(Dgv_cuadriculaDedatos); // Aplicar configuración después de importar
            }
        }



        //Funcion del boton de SubirDatosDB
        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            int numDatos;

            if (int.TryParse(txtNumeroDatos.Text, out numDatos) && numDatos > 0)
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;

                worker.DoWork += (s, ev) =>
                {
                    SubirDatosDB_DAL subirDatosDB = new SubirDatosDB_DAL();

                    DataTable dtTransacciones = (DataTable)Dgv_cuadriculaDedatos.DataSource;
                    subirDatosDB.SubirDatos(dtTransacciones, numDatos, percent =>
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



        //Funcion del boton de Dato nuevo
        private void btnDatonuevo_Click(object sender, EventArgs e)
        {
            Frm_AgregarDatos nuevoForm = new Frm_AgregarDatos(Dgv_cuadriculaDedatos, lblFilasImportadas);
            if (nuevoForm.ShowDialog() == DialogResult.OK)
            {

            }
        }


        //Funcion del boton de editar
        private void btnEditar_Click(object sender, EventArgs e)
        {

            // Crear el formulario y pasarle el DataGridView
            if (Dgv_cuadriculaDedatos.SelectedRows.Count > 0) // Asegurarse de que haya filas seleccionadas
            {
                DataGridViewRow selectedRow = Dgv_cuadriculaDedatos.SelectedRows[0];
                Frm_editar formEditaryEliminar = new Frm_editar(Dgv_cuadriculaDedatos, selectedRow);
                formEditaryEliminar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila que desea editar.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_cuadriculaDedatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                return;
            }

            var selectedRow = Dgv_cuadriculaDedatos.SelectedRows[0];

            var result = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Dgv_cuadriculaDedatos.Rows.Remove(selectedRow);
                MessageBox.Show("Fila eliminada con éxito.");
            }
        }

        
    }

}











