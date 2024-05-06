using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Importar.DAL
{
    internal class SubirDatosDB
    {
        private SqlConnection connection;

        public SubirDatosDB()
        {
            var conexion = new ConexionSqlserver_DAL();
            connection = conexion.ObtenerConexion();
        }

        private void AbrirConexion()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public int ObtenerConteoTotal()
        {
            int totalDatos = 0;

            AbrirConexion(); // Asegurarse de abrir la conexión
            try
            {
                var query = "SELECT COUNT(*) FROM MiTabla"; // Ajustar según el nombre de la tabla
                using (var command = new SqlCommand(query, connection))
                {
                    totalDatos = Convert.ToInt32(command.ExecuteScalar()); // Obtener el número total de registros
                }
            }
            finally
            {
                CerrarConexion(); // Siempre cerrar la conexión
            }

            return totalDatos; // Devolver el conteo total
        }

        public void AgregarDato(DataRow row)
        {
            try
            {
                AbrirConexion(); // Asegurarse de que la conexión esté abierta

                if (DatoYaExiste(row))
                {
                    MessageBox.Show("El dato ya existe en la base de datos.");
                    return;
                }

                GuardarDatoEnBaseDeDatos(row); // Guardar el dato
                MessageBox.Show("Dato agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el dato: {ex.Message}");
            }
            finally
            {
                CerrarConexion(); // Siempre cerrar la conexión
            }
        }

        private bool DatoYaExiste(DataRow row)
        {
            string query = "SELECT COUNT(*) FROM MiTabla WHERE " +
                           "codigo_loc = @codigo_loc AND consec_ctr = @consec_ctr AND codigo_trs = @codigo_trs AND id_emp = @id_emp AND valor_ctr = @valor_ctr AND fecha_ctr = @fecha_ctr AND estado_ctr = @estado_ctr";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
                command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
                command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
                command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
                command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
                command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
                command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

                return Convert.ToInt32(command.ExecuteScalar()) > 0; // Devuelve verdadero si el dato ya existe
            }
        }

        private void GuardarDatoEnBaseDeDatos(DataRow row)
        {
            var query = "INSERT INTO MiTabla (codigo_loc, consec_ctr, codigo_trs, id_emp, valor_ctr, fecha_ctr, estado_ctr) " +
                        "VALUES (@codigo_loc, @consec_ctr, @codigo_trs, @id_emp, @valor_ctr, @fecha_ctr, @estado_ctr)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
                command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
                command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
                command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
                command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
                command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
                command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

                command.ExecuteNonQuery(); // Ejecutar la inserción
            }
        }

        public void SubirDatos(DataGridView dgv, int numDatos, Action<int> reportarProgreso)
        {
            if (dgv == null || dgv.DataSource == null)
            {
                throw new ArgumentNullException(nameof(dgv), "El DataGridView es nulo o no tiene fuente de datos.");
            }

            try
            {
                AbrirConexion(); // Asegurarse de que la conexión esté abierta  

                DataTable dt = (DataTable)dgv.DataSource;
                int totalFilas = dt.Rows.Count;
                int datosASubir = Math.Min(numDatos, totalFilas);

                for (int i = 0; i < datosASubir; i++)
                {
                    DataRow row = dt.Rows[i];

                    if (!DatoYaExiste(row)) // Verificar si el dato ya existe
                    {
                        GuardarDatoEnBaseDeDatos(row); // Guardar el dato
                        reportarProgreso((i + 1) * 100 / datosASubir); // Actualizar progreso como porcentaje
                    }
                }

                MessageBox.Show($"Se subieron {datosASubir} datos con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al subir los datos: {ex.Message}");
            }
            finally
            {
                CerrarConexion(); // Siempre cerrar la conexión para evitar fugas de recursos
            }
        }


    }
}