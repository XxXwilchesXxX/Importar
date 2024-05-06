using System;
using System.Data;
using System.Windows.Forms;

namespace Importar.DAL
{
    internal class GuardarDatos_BLL
    {

        //Este método toma un DataGridView y siete valores para agregar como fila nueva.
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

            //Se crea una nueva fila (newRow) usando dt.NewRow()
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

        internal void ActualizarDataGridView(DataGridView dgvCuadriculaDedatos, int rowIndex, string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }
    }
}
