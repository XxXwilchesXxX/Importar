using System;
using System.Data.SqlClient;

namespace Importar.DAL
{
    internal class ConexionSqlserver
    {
        private readonly string connectionString = "Data Source=DESKTOP-LQHP5D2;Initial Catalog=excel;Integrated Security=True";
        private SqlConnection connection;

        public ConexionSqlserver()
        {
            connection = new SqlConnection(connectionString);
        }

        public void AbrirConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    Console.WriteLine("Conexión a SQL Server abierta con éxito.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión a SQL Server cerrada con éxito.");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return connection;
        }
    }
}
