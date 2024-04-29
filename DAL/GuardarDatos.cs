using System;
using System.Data;
using System.Windows.Forms;

namespace Importar.DAL
{
    internal class GuardarDatos
    {
        public void GuardarEnDataGridView(
            DataGridView dgv,
            string codigoLoc,
            string consecCtr,
            string codigoTrs,
            string idEmp,
            string valorCtr,
            string fechaCtr,
            string estadoCtr
        )
        {
            if (dgv == null)
            {
                MessageBox.Show("El DataGridView no está disponible.");
                return;
            }

            DataTable dt = (DataTable)dgv.DataSource;

            if (dt == null)
            {
                MessageBox.Show("No se puede agregar datos porque el DataGridView no tiene una fuente de datos.");
                return;
            }

            DataRow newRow = dt.NewRow();
            newRow["codigo_loc"] = codigoLoc;
            newRow["consec_ctr"] = consecCtr;
            newRow["codigo_trs"] = codigoTrs;
            newRow["id_emp"] = idEmp;
            newRow["valor_ctr"] = valorCtr;
            newRow["fecha_ctr"] = fechaCtr;
            newRow["estado_ctr"] = estadoCtr;

            dt.Rows.Add(newRow);

            MessageBox.Show("Datos agregados con éxito al DataGridView.");
        }
    }
}
