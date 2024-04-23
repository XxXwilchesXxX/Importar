using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Importar.DAL
{
    internal class controllerImportar
    {
        public DataTable Importarcsv()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
                Title = "Seleccionar archivo CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear DataTable para almacenar los datos CSV
                    DataTable dt = new DataTable();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        // Leer la primera línea para crear las columnas
                        string[] headers = reader.ReadLine().Split(';');
                        foreach (string header in headers) dt.Columns.Add(header);

                        // Leer el resto de las líneas para llenar los datos
                        while (!reader.EndOfStream)
                        {
                            string[] rows = reader.ReadLine().Split(';');
                            dt.Rows.Add(rows);
                        }
                    }

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }

            return null;
        }
    }
}