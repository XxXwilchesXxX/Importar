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
            newRow["codigo_loc"] = txtSave_codigo_loc.Text;
            newRow["consec_ctr"] = txtSave_consec_ctr.Text;
            newRow["codigo_trs"] = txtSave_codigo_trs.Text;
            newRow["id_emp"] = txtSave_id_emp.Text;
            newRow["valor_ctr"] = txtSave_valor_ctr.Text;
            newRow["fecha_ctr"] = txtSave_fecha_ctr.Text;
            newRow["estado_ctr"] = txtSave_estado_ctr.Text;

            // Agregar la nueva fila al DataTable
            dt.Rows.Add(newRow);
            Dgv_cuadriculaDedatos.Refresh();

            MessageBox.Show("Dato agregado con éxito al DataGridView.");

            // Limpiar campos de texto
            txtSave_codigo_loc.Text = "";
            txtSave_consec_ctr.Text = "";
            txtSave_codigo_trs.Text = "";
            txtSave_id_emp.Text = "";
            txtSave_valor_ctr.Text = "";
            txtSave_fecha_ctr.Text = "";
            txtSave_estado_ctr.Text = "";

            // Actualizar el Label con el número de filas
            lblFilasImportadas.Text = $"Filas importadas: {dt.Rows.Count}";
        }
    }
}
