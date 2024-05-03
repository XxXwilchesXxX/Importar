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
        private ConexionSqlserver_DAL conexionSqlserver; // Conexión a SQL Server

        public software()
        {
            InitializeComponent();
            conexionSqlserver = new ConexionSqlserver_DAL(); // Inicializar conexión
            ConectarEventosDataGridView();
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
            importador_VIEW importador = new importador_VIEW();
            DataTable dt = importador.ImportarCsv(out int numFilas);

            if (dt != null)
            {
                Dgv_cuadriculaDedatos.DataSource = dt;
                ActualizarConteoFilas();
                importador_VIEW.ConfigurarDataGridView(Dgv_cuadriculaDedatos, lblFilasImportadas);
            }
            else
            {
                MessageBox.Show("No se importaron datos.");
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
                    SubirDatosDB_DAL subirDatosDB = new SubirDatosDB_DAL();
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
            if (Dgv_cuadriculaDedatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            var selectedRow = Dgv_cuadriculaDedatos.SelectedRows[0];
            var result = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Dgv_cuadriculaDedatos.Rows.Remove(selectedRow);
                ActualizarConteoFilas();
                MessageBox.Show("Fila eliminada con éxito.");
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
