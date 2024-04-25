using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Importar.controller;
using System.IO;

namespace Importar.DAL
{
    internal class SubirDatosDB
    {
        private static int indiceInicio = 0;

        public static void GuardarIndice()
        {
            File.WriteAllText("indiceInicio.txt", indiceInicio.ToString());
        }

        public static int LeerIndice()
        {
            if (File.Exists("indiceInicio.txt"))
            {
                string contenido = File.ReadAllText("indiceInicio.txt");
                if (int.TryParse(contenido, out int indice))
                {
                    return indice;
                }
            }
            return 0;
        }

        public void SubirDatos(DataGridView dataGridView, int numDatos)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView.DataSource;

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para subir.");
                    return;
                }

                if (indiceInicio >= dt.Rows.Count)
                {
                    MessageBox.Show("No hay más datos para subir.");
                    return;
                }

                int datosASubir = Math.Min(numDatos, dt.Rows.Count - indiceInicio);

                CConexion conexion = new CConexion();
                MySqlConnection connection = conexion.establecerConexion();

                if (connection.State == ConnectionState.Open)
                {
                    GuardarDatosEnBaseDeDatos(dt, connection, indiceInicio, datosASubir);
                    indiceInicio += datosASubir;
                    GuardarIndice();

                    MessageBox.Show($"Se subieron {datosASubir} datos a la base de datos.");
                }
                else
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir los datos a la base de datos: " + ex.Message);
            }
        }

        private bool DatoYaExiste(MySqlConnection connection, DataRow row)
        {
            string query = "SELECT COUNT(*) FROM MiTabla WHERE codigo_loc = @codigo_loc AND consec_ctr = @consec_ctr AND codigo_trs = @codigo_trs AND id_emp = @id_emp AND valor_ctr = @valor_ctr AND fecha_ctr = @fecha_ctr AND estado_ctr = @estado_ctr";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
            command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
            command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
            command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
            command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
            command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
            command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count > 0; 
        }

        private void GuardarDatosEnBaseDeDatos(DataTable dt, MySqlConnection connection, int indiceInicio, int datosASubir)
        {
            for (int i = indiceInicio; i < indiceInicio + datosASubir; i++)
            {
                DataRow row = dt.Rows[i];

                if (!DatoYaExiste(connection, row))
                {
                    string query = "INSERT INTO MiTabla (codigo_loc, consec_ctr, codigo_trs, id_emp, valor_ctr, fecha_ctr, estado_ctr) VALUES (@codigo_loc, @consec_ctr, @codigo_trs, @id_emp, @valor_ctr, @fecha_ctr, @estado_ctr)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
                    command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
                    command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
                    command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
                    command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
                    command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
                    command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
