using System;
using System.Data;
using System.Windows.Forms;

namespace Importar.VIEW
{
    public partial class AgregarDatos : Form
    {
        private DataGridView Dgv_cuadriculaDedatos;
        private Label lblFilasImportadas; 

        public AgregarDatos(DataGridView dgv, Label lblFilas)
        {
            InitializeComponent();
            Dgv_cuadriculaDedatos = dgv;
            lblFilasImportadas = lblFilas; 
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (Dgv_cuadriculaDedatos == null)
            {
                MessageBox.Show("El DataGridView no está disponible.");
                return;
            }

            DataTable dt = (DataTable)Dgv_cuadriculaDedatos.DataSource;

            // Crear una nueva fila y asignar valores
            DataRow newRow = dt.NewRow();
            newRow["codigo_loc"] = txtCodigo_loc.Text;
            newRow["consec_ctr"] = txtConsec_ctr.Text;
            newRow["codigo_trs"] = txtCodigo_trs.Text;
            newRow["id_emp"] = txtId_emp.Text;
            newRow["valor_ctr"] = txtValor_ctr.Text;
            newRow["fecha_ctr"] = txtFecha_ctr.Text;
            newRow["estado_ctr"] = txtEstado_ctr.Text;

            // Agregar la nueva fila al DataTable
            dt.Rows.Add(newRow);
            Dgv_cuadriculaDedatos.Refresh();

            MessageBox.Show("Dato agregado con éxito al DataGridView.");

            // Limpiar campos de texto
            txtCodigo_loc.Text = "";
            txtConsec_ctr.Text = "";
            txtCodigo_trs.Text = "";
            txtId_emp.Text = "";
            txtValor_ctr.Text = "";
            txtFecha_ctr.Text = "";
            txtEstado_ctr.Text = "";

            // Actualizar el Label con el número de filas
            lblFilasImportadas.Text = $"Filas importadas: {dt.Rows.Count}";
        }
    }
}
