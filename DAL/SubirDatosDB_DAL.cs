using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Importar.DAL
{
    internal class SubirDatosDB_DAL
    {
        private static int indiceInicio = 0;
        private SqlConnection connection;

        public SubirDatosDB_DAL()
        {
            var conexion = new ConexionSqlserver_DAL();
            connection = conexion.ObtenerConexion();
            AbrirConexion(); // Asegúrate de abrir la conexión al inicializar
        }

        private void AbrirConexion()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private bool DatoYaExiste(DataRow row)
        {
            //Abrir conexion con DB
            var query = "SELECT COUNT(*) FROM MiTabla WHERE " +
                        "codigo_loc = @codigo_loc AND consec_ctr = @consec_ctr AND codigo_trs = @codigo_trs " +
                        "AND id_emp = @id_emp AND valor_ctr = @valor_ctr AND fecha_ctr = @fecha_ctr " +
                        "AND estado_ctr = @estado_ctr";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@codigo_loc", row["codigo_loc"]);
                command.Parameters.AddWithValue("@consec_ctr", row["consec_ctr"]);
                command.Parameters.AddWithValue("@codigo_trs", row["codigo_trs"]);
                command.Parameters.AddWithValue("@id_emp", row["id_emp"]);
                command.Parameters.AddWithValue("@valor_ctr", row["valor_ctr"]);
                command.Parameters.AddWithValue("@fecha_ctr", row["fecha_ctr"]);
                command.Parameters.AddWithValue("@estado_ctr", row["estado_ctr"]);

                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            //Cerrar conexion con DB
        }

        public void SubirDatos(DataTable dtTransacciones, int numDatos, Action<int> reportarProgreso)
        {
            try
            {
                if (dtTransacciones == null || dtTransacciones.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para subir.");
                    return;
                }

                int datosASubir = Math.Min(numDatos, dtTransacciones.Rows.Count - indiceInicio);

                for (int i = 0; i < datosASubir; i++)
                {
                    var row = dtTransacciones.Rows[indiceInicio + i];
                    if (!DatoYaExiste(row))
                    {
                        GuardarDatosEnBaseDeDatos(row);
                        reportarProgreso(((i + 1) * 100) / datosASubir);
                    }
                }

                indiceInicio += datosASubir;

                MessageBox.Show($"Se subieron {datosASubir} datos a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir los datos: " + ex.Message);
            }
        }

        private void GuardarDatosEnBaseDeDatos(DataRow row)
        {
            var query = "INSERT INTO MiTabla (codigo_loc, consec_ctr, codigo_trs, id_emp, valor_ctr, fecha_ctr, estado_ctr) " +
                        "VALUES (@codigo_loc, @consec_ctr, @codigo_trs, @id_emp, @valor_ctr, @fecha_ctr, @estado_ctr)";

            using (var command = new SqlCommand(query, connection))
            {
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

        internal void SubirDatos(DataGridView dgv_cuadriculaDedatos, int numDatos, Action<int> value)
        {
            throw new NotImplementedException();
        }
    }
}
