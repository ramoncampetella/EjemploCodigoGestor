using System;

namespace CuotaCobradaService.DTO
{
    public class RegistrarCobroCuotaRq
    {
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public int CuentaCredito { get; set; }
        public int IdentificacionCredito { get; set; }
        public int NroCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal ValorCuota { get; set; }
    }
}
