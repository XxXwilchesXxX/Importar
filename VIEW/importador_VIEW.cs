using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Importar
{
    internal class importador_VIEW
    {
        public DataTable ImportarCsv(out int numFilas)
        {
            numFilas = 0;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
                Title = "Seleccionar archivo CSV"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return null;

            try
            {
                DataTable dt = LeerCsv(openFileDialog.FileName, ref numFilas);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
                return null;
            }
        }

        private DataTable LeerCsv(string filePath, ref int numFilas)
        {
            DataTable dt = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine().Split(';');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }

                while (!reader.EndOfStream)
                {
                    string[] rows = reader.ReadLine().Split(';');
                    dt.Rows.Add(rows);
                }
            }

            numFilas = dt.Rows.Count;
            return dt;
        }

        public static void ConfigurarDataGridView(DataGridView dgv, Label lblFilasImportadas)
        {
            if (dgv == null || lblFilasImportadas == null)
                throw new ArgumentNullException("El DataGridView o el Label es nulo.");

            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;

            dgv.RowsAdded += (sender, e) => ActualizarLabel(dgv, lblFilasImportadas);
            dgv.RowsRemoved += (sender, e) => ActualizarLabel(dgv, lblFilasImportadas);

            dgv.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dgv.Rows[e.RowIndex].Selected = true;
                }
            };
        }

        private static void ActualizarLabel(DataGridView dgv, Label lblFilasImportadas)
        {
            if (dgv == null || lblFilasImportadas == null) return;

            int numFilas = dgv.Rows.Count;

            // Ajustar para evitar fila de inserción no deseada
            if (dgv.AllowUserToAddRows)
            {
                numFilas--;
            }

            lblFilasImportadas.Text = $"Filas importadas: {numFilas}";
        }
    }
}
