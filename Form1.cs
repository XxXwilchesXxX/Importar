using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using MySql.Data.MySqlClient;
using Importar.Clases;


namespace Importar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
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

                    // Asignar el DataTable al DataGridView como origen de datos
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            Clases.CConexion objetoconexion = new Clases.CConexion();
            objetoconexion.establecerConexion();
        }

        private void btnSubirDB_Click(object sender, EventArgs e)
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



