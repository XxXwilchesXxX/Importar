using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Importar.BLL
{
    internal class eliminarFila_BLL
    {
        public void EliminarFilas(DataGridView dgv, Label lblFilasImportadas)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una fila para eliminar.");
                return;
            }

            var result = MessageBox.Show(
                "¿Está seguro de que desea eliminar las filas seleccionadas?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Convertir las filas seleccionadas a una lista para evitar problemas de modificación durante la iteración
                var filasSeleccionadas = dgv.SelectedRows.Cast<DataGridViewRow>().ToList();

                foreach (var row in filasSeleccionadas)
                {
                    dgv.Rows.Remove(row);
                }

                // Actualizar el conteo de filas después de eliminar
                ActualizarConteoFilas(dgv, lblFilasImportadas);
                MessageBox.Show($"Se eliminaron {filasSeleccionadas.Count} filas con éxito.");
            }
        }

        private void ActualizarConteoFilas(DataGridView dgv, Label lblFilasImportadas)
        {
            if (lblFilasImportadas != null)
            {
                int filasImportadas = dgv.Rows.Count;
                lblFilasImportadas.Text = $"Filas importadas: {filasImportadas}";
            }
        }
    }
}
