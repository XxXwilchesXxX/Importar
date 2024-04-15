using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Importar.controller
{
    internal class SubirDatosDB
    {
        public void SubirDatos(DataGridView dataGridView1)
        {
            try
            {
                // Obtener los datos de la DataGridView
                DataTable dt = (DataTable)dataGridView1.DataSource;

                // Verificar si hay datos en la DataGridView
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Crear una instancia de la clase CConexion para establecer la conexión a la base de datos
                    CConexion conexion = new CConexion();
                    MySqlConnection connection = conexion.establecerConexion();

                    // Verificar si la conexión se estableció correctamente
                    if (connection.State == ConnectionState.Open)
                    {
                        // Guardar los datos en la base de datos MySQL
                        GuardarDatosEnBaseDeDatos(dt, connection);

                        MessageBox.Show("Datos subidos a la base de datos correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para subir a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir los datos a la base de datos: " + ex.Message);
            }
        }

        private void GuardarDatosEnBaseDeDatos(DataTable dt, MySqlConnection connection)
        {
            // Iterar a través de cada fila en el DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Crear la consulta de inserción
                string query = "INSERT INTO MiTabla (codigo_loc, consec_ctr, codigo_trs, id_emp, valor_ctr, fecha_ctr, estado_ctr) " +
                               "VALUES (@codigo_loc, @consec_ctr, @codigo_trs, @id_emp, @valor_ctr, @fecha_ctr, @estado_ctr)";

                // Crear el comando SQL
                MySqlCommand command = new MySqlCommand(query, connection);

                // Agregar parámetros a la consulta
                command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
                command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
                command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
                command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
                command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
                command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
                command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

                // Ejecutar la consulta
                command.ExecuteNonQuery();
            }
        }
    }
}
