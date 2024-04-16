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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear DataTable para almacenar los datos CSV
                    DataTable dt = new DataTable();

                    // Leer el contenido del archivo CSV usando StreamReader
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        // Leer la primera línea para crear las columnas
                        string[] headers = reader.ReadLine().Split(';');
                        foreach (string header in headers)
                        {
                            dt.Columns.Add(header);
                        }

                        // Leer el resto de las líneas para llenar los datos
                        while (!reader.EndOfStream)
                        {
                            string[] rows = reader.ReadLine().Split(';');
                            dt.Rows.Add(rows);
                        }
                    }

                    return dt; // Devolver el DataTable con los datos CSV
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }

            return null; // Devolver null si la operación se cancela o hay un error
        }
    }
}