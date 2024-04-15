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
    }
    
}




