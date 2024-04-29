using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Importar.VIEW
{
    internal class importador
    {
        public DataTable Importarcsv(out int numFilas)
        {
            numFilas = 0; // Inicializamos el contador de filas importadas

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

                    numFilas = dt.Rows.Count; // Contar el número de filas importadas
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }

            return null; // Si no se importó nada o hubo un error, devuelve null
        }
    }
}
