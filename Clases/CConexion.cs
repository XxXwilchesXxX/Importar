using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importar.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "excel";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        string cadenadeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + db + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {

                conex.ConnectionString = cadenadeConexion;
                conex.Open();
                MessageBox.Show("se logro conectar a la db correctamente ");

            }

            catch (MySqlException e)
            {

                MessageBox.Show("no se pudo conectar a la db , error: " + e.ToString());
            }

            return conex;
        }

    }
}
