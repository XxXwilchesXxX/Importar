using System;
using System.Data;
using System.Windows.Forms;

namespace Importar.BLL
{
    internal class Importar_BLL
    {
        public DataTable ImportarDatos()
        {
            importar_VIEW importador = new importar_VIEW();
            DataTable dt = importador.ImportarCsv(out int numFilas);

            if (dt == null)
            {
                throw new Exception("No se importaron datos.");
            }

            return dt;
        }

        public void ConfigurarDataGridView(DataGridView dgv, Label lblFilasImportadas)
        {
            importar_VIEW.ConfigurarDataGridView(dgv, lblFilasImportadas);
        }

        public void ActualizarConteoFilas(DataGridView dgv, Label lblFilasImportadas)
        {
            int filasImportadas = dgv.Rows.Count;
            lblFilasImportadas.Text = $"Filas importadas: {filasImportadas}";
        }
    }
}
