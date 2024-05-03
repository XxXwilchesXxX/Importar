using System;
using System.Windows.Forms;

namespace Importar.VIEW
{
    internal class EditaryEliminarDatos
    {
        internal void AbrirFormularioParaEdicion(DataGridViewRow filaSeleccionada)
        {
            if (filaSeleccionada == null)
            {
                throw new ArgumentNullException(nameof(filaSeleccionada), "No se seleccionó ninguna fila.");
            }

            // Crear una nueva instancia del formulario para editar y eliminar datos
            Frm_editar form = new Frm_editar();

            // Asignar valores a los textboxes en el formulario
            form.txtEdit_eliminar_codigo_loc.Text = filaSeleccionada.Cells["codigo_loc"].Value?.ToString();
            form.txtEdit_eliminar_consec_ctr.Text = filaSeleccionada.Cells["consec_ctr"].Value?.ToString();
            form.txtEdit_eliminar_codigo_trs.Text = filaSeleccionada.Cells["codigo_trs"].Value?.ToString();
            form.txtEdit_eliminar_id_emp.Text = filaSeleccionada.Cells["id_emp"].Value?.ToString();
            form.txtEdit_eliminar_valor_ctr.Text = filaSeleccionada.Cells["valor_ctr"].Value?.ToString();
            form.txtEdit_eliminar_fecha_ctr.Text = filaSeleccionada.Cells["fecha_ctr"].Value?.ToString();
            form.txtEdit_eliminar_estado_ctr.Text = filaSeleccionada.Cells["estado_ctr"].Value?.ToString();

            // Abrir el formulario para editar
            form.ShowDialog();
        }
    }
}
