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
using Importar.controller;



namespace Importar{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            controller.controllerImportar objetoDeImportacion = new controller.controllerImportar();
            DataTable dt = objetoDeImportacion.Importarcsv();

            if (dt != null)
            {
                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dt;
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            controller.CConexion objetoconexion = new controller.CConexion();
            objetoconexion.establecerConexion();
  
        }

        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            controller.SubirDatosDB objetoDeSubirDatosDB = new controller.SubirDatosDB();
            objetoDeSubirDatosDB.SubirDatos(dataGridView1);

        }
    }
    
}




