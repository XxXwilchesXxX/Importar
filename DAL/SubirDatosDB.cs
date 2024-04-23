using Importar.controller;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Importar.DAL
{
    internal class SubirDatosDB
    {
        public void SubirDatos(DataGridView dataGridView)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView.DataSource;

                if (dt != null && dt.Rows.Count > 0)
                {
                    CConexion conexion = new CConexion();
                    MySqlConnection connection = conexion.establecerConexion();

                    if (connection.State == ConnectionState.Open)
                    {
                        if (!DatosYaSubidos(dt, connection))
                        {
                            GuardarDatosEnBaseDeDatos(dt, connection);
                            MessageBox.Show("Datos subidos a la base de datos correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Los datos ya han sido subidos previamente.");
                        }
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

        private bool DatosYaSubidos(DataTable dt, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM MiTabla WHERE codigo_loc = @codigo_loc AND consec_ctr = @consec_ctr AND codigo_trs = @codigo_trs AND id_emp = @id_emp AND valor_ctr = @valor_ctr AND fecha_ctr = @fecha_ctr AND estado_ctr = @estado_ctr";

            foreach (DataRow row in dt.Rows)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
                command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
                command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
                command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
                command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
                command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
                command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void GuardarDatosEnBaseDeDatos(DataTable dt, MySqlConnection connection)
        {
            foreach (DataRow row in dt.Rows)
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
