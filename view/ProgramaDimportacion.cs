using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Importar.BLL;
using Importar.DAL;
using Importar.VIEW;

namespace Importar
{
    public partial class Frm_software : Form
    {
        private ConexionSqlserver_DAL conexionSqlserver; // Conexión a SQL Server

        public Frm_software()
        {
            InitializeComponent();
            conexionSqlserver = new ConexionSqlserver_DAL(); // Inicializar conexión
            ConectarEventosDataGridView();

            // Configurar DataGridView para seleccionar toda la fila con un clic
            Dgv_cuadriculaDedatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_cuadriculaDedatos.MultiSelect = true; // Permitir selección múltiple
            Dgv_cuadriculaDedatos.KeyDown += Dgv_cuadriculaDedatos_KeyDown;

        }

        private void ConectarEventosDataGridView()
        {
            // Conectar eventos para mantener el conteo de filas actualizado
            Dgv_cuadriculaDedatos.RowsAdded += Dgv_cuadriculaDedatos_RowsChanged;
            Dgv_cuadriculaDedatos.RowsRemoved += Dgv_cuadriculaDedatos_RowsChanged;

        }

        private void Dgv_cuadriculaDedatos_RowsChanged(object sender, EventArgs e)
        {
            ActualizarConteoFilas();
        }

        private void ActualizarConteoFilas()
        {
            int filasImportadas = Dgv_cuadriculaDedatos.Rows.Count - (Dgv_cuadriculaDedatos.AllowUserToAddRows ? 1 : 0); // Contar las filas sin fila fantasma
            lblFilasImportadas.Text = $"Filas importadas: {filasImportadas}";
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                Importar_BLL importarBLL = new Importar_BLL();
                DataTable dt = importarBLL.ImportarDatos();

                Dgv_cuadriculaDedatos.DataSource = dt;

                importarBLL.ConfigurarDataGridView(Dgv_cuadriculaDedatos, lblFilasImportadas);
                importarBLL.ActualizarConteoFilas(Dgv_cuadriculaDedatos, lblFilasImportadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al importar datos: {ex.Message}");
            }
        }





        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroDatos.Text, out int numDatos) && numDatos > 0)
            {
                BackgroundWorker worker = new BackgroundWorker
                {
                    WorkerReportsProgress = true
                };

                worker.DoWork += (s, ev) =>
                {
                    SubirDatosDB subirDatosDB = new SubirDatosDB();
                    subirDatosDB.SubirDatos(Dgv_cuadriculaDedatos, numDatos, percent =>
                    {
                        worker.ReportProgress((int)percent);
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
                    MessageBox.Show("Datos subidos con éxito.");
                };

                prgbProcessing.Visible = true;
                worker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para la cantidad de datos a subir.");
            }
        }





        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarFila_BLL eliminador = new eliminarFila_BLL();
                eliminador.EliminarFilas(Dgv_cuadriculaDedatos, lblFilasImportadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la fila: {ex.Message}");
            }
        }

        private void Dgv_cuadriculaDedatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Capturar tecla "Supr" para eliminar
            {
                var eliminarBLL = new eliminarFila_BLL();
                eliminarBLL.EliminarFilas(Dgv_cuadriculaDedatos, lblFilasImportadas);
            }
        }

     




        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Dgv_cuadriculaDedatos.SelectedRows.Count > 0)
            {
                Frm_editar formEditaryEliminar = new Frm_editar(Dgv_cuadriculaDedatos, Dgv_cuadriculaDedatos.SelectedRows[0]);
                formEditaryEliminar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }





        private void btnDatonuevo_Click(object sender, EventArgs e)
        {
            var nuevoForm = new Frm_AgregarDatos(Dgv_cuadriculaDedatos, lblFilasImportadas);
            if (nuevoForm.ShowDialog() == DialogResult.OK)
            {
                ActualizarConteoFilas();
            }
        }

    }
}
