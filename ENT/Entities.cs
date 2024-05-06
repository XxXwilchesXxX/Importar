using System;

namespace Importar.Entities
{
    public class MiTabla
    {
        // Clave primaria con identidad (autoincremental)
        public int Id { get; set; }

        // Campos adicionales
        public string CodigoLoc { get; set; } 
        public string ConsecCtr { get; set; } 
        public string CodigoTrs { get; set; }
        public string IdEmp { get; set; } 
        public string ValorCtr { get; set; } 
        public string FechaCtr { get; set; } 
        public string EstadoCtr { get; set; } 
    }
}
