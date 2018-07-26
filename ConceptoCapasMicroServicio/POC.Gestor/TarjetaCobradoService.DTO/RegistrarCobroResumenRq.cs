using System;
using System.Collections.Generic;
using System.Text;

namespace TarjetaCobradoService.DTO
{
    public class RegistrarCobroResumenRq
    {
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Consumo { get; set; }
        public int NumeroCuenta { get; set; }
        public string TipoTarjeta { get; set; }
    }
}
