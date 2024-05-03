using System;
using System.Windows.Forms;

namespace Importar.VIEW
{
    public partial class Frm_editar : Form
    {
        private DataGridView Dgv_cuadriculaDedatos; // DataGridView del formulario principal
        private DataGridViewRow selectedRow; // Fila seleccionada para editar

        public Frm_editar()
        {
        }


        // Constructor para recibir el DataGridView y la fila seleccionada
        public Frm_editar(DataGridView dgv, DataGridViewRow row)
        {
            InitializeComponent();
            this.Dgv_cuadriculaDedatos = dgv;
            this.selectedRow = row;

            // Asignar valores a los TextBox con los datos de la fila seleccionada
            txtEdit_eliminar_codigo_loc.Text = row.Cells["codigo_loc"].Value?.ToString();
            txtEdit_eliminar_consec_ctr.Text = row.Cells["consec_ctr"].Value?.ToString(); txtEdit_eliminar_codigo_trs.Text = row.Cells["codigo_trs"].Value?.ToString();
            txtEdit_eliminar_id_emp.Text = row.Cells["id_emp"].Value?.ToString();
            txtEdit_eliminar_valor_ctr.Text = row.Cells["valor_ctr"].Value?.ToString();
            txtEdit_eliminar_fecha_ctr.Text = row.Cells["fecha_ctr"].Value?.ToString();
            txtEdit_eliminar_estado_ctr.Text = row.Cells["estado_ctr"].Value?.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar la fila seleccionada con los valores de los TextBox
            selectedRow.Cells["codigo_loc"].Value = txtEdit_eliminar_codigo_loc.Text;
            selectedRow.Cells["consec_ctr"].Value = txtEdit_eliminar_consec_ctr.Text;
            selectedRow.Cells["codigo_trs"].Value = txtEdit_eliminar_codigo_trs.Text;
            selectedRow.Cells["id_emp"].Value = txtEdit_eliminar_id_emp.Text;
            selectedRow.Cells["valor_ctr"].Value = txtEdit_eliminar_valor_ctr.Text;
            selectedRow.Cells["fecha_ctr"].Value = txtEdit_eliminar_fecha_ctr.Text;
            selectedRow.Cells["estado_ctr"].Value = txtEdit_eliminar_estado_ctr.Text;

            Dgv_cuadriculaDedatos.Refresh(); // Refrescar el DataGridView para mostrar cambios
            MessageBox.Show("Dato actualizado con éxito.");
            this.Close(); // Cerrar el formulario al finalizar
        }


    }
}
