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
using Importar.DAL;



namespace Importar
{
    public partial class software : Form
    {



        public software()
        {
            InitializeComponent();
      
        }




        private void btnImportar_Click(object sender, EventArgs e)
        {
            controllerImportar objetoDeImportacion = new DAL.controllerImportar();
            DataTable dt = objetoDeImportacion.Importarcsv();

            if (dt != null)
            {
                // Asignar el DataTable al DataGridView
                Dgv_cuadriculaDedatos.DataSource = dt;
            }

        }



        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            SubirDatosDB objetoDeSubirDatosDB = new DAL.SubirDatosDB();
            objetoDeSubirDatosDB.SubirDatos(Dgv_cuadriculaDedatos);

        }
    }
    
}




