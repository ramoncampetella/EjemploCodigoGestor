using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.RestAPI.DTO
{
    public class PagoResumenTarjetaDTORq : BasePagoDTORq
    {
        public DateTime FechaVencimiento { get; set; }
        public decimal Consumo { get; set; }
        public int NumeroCuenta { get; set; }
        public string TipoTarjeta { get; set; }
    }
}
