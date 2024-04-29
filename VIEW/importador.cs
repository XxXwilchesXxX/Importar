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

        internal DataTable Importarcsv()
        {
            throw new NotImplementedException();
        }
    }
}
