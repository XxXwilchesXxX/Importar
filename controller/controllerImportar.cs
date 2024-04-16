using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Importar.controller
{
    internal class controllerImportar
    {
        public bool Importarcsv(DataGridView cuadriculaDeDatos)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer el contenido del archivo CSV
                    string[] lineas = File.ReadAllLines(openFileDialog.FileName);

                    // Verificar si los datos ya han sido importados previamente en la cuadrícula
                    foreach (string linea in lineas)
                    {
                        if (DatosYaImportados(linea, cuadriculaDeDatos))
                        {
                            MessageBox.Show("Estos datos ya han sido importados previamente.");
                            return false;
                        }

                    // Si no hay datos duplicados, agregar los nuevos datos a la cuadrícula
                    foreach (string linea in lineas)
                        {
                        string[] campos = linea.Split(';');
                        cuadriculaDeDatos.Rows.Add(campos);
                    }

                    MessageBox.Show("Datos importados correctamente.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }

            return false; // Devolver false si la operación se cancela o hay un error
        }

        private bool DatosYaImportados(string nuevaLinea, DataGridView cuadriculaDeDatos)
        {
            foreach (DataGridViewRow fila in cuadriculaDeDatos.Rows)
            {
                string lineaExistente = "";
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    lineaExistente += celda.Value.ToString() + ";";
                }
                if (lineaExistente == nuevaLinea)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
