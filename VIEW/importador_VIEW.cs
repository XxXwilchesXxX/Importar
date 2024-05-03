using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Importar.VIEW
{
    internal class importador_VIEW
    {
        public DataTable Importarcsv(out int numFilas)
        {
            numFilas = 0;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
                Title = "Seleccionar archivo CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string[] headers = reader.ReadLine().Split(';');
                        foreach (string header in headers) dt.Columns.Add(header);

                        while (!reader.EndOfStream)
                        {
                            string[] rows = reader.ReadLine().Split(';');
                            dt.Rows.Add(rows);
                        }
                    }

                    numFilas = dt.Rows.Count;
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }

            return null;
        }

        // Método para hacer que un DataGridView sea de solo lectura
        public static void ConfigurarDataGridView(DataGridView dgv)
        {
            if (dgv != null)
            {
                dgv.ReadOnly = true; // Para que no se pueda editar
                dgv.AllowUserToAddRows = false; // Para eliminar la fila de agregado
                dgv.AllowUserToDeleteRows = false; // No permitir eliminación manual
                dgv.AllowUserToOrderColumns = true; // Permitir reordenar columnas

                // Agregar evento para seleccionar toda la fila con doble clic
                dgv.CellDoubleClick += (sender, e) =>
                {
                    if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
                    {
                        dgv.Rows[e.RowIndex].Selected = true; // Seleccionar la fila completa
                    }
                };
            }


        }
    }
}

