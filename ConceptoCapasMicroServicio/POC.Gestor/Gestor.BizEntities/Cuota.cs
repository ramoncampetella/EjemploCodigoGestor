using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.BizEntities
{
    public class Cuota : AbstractPago
    {
        public int CuentaCredito{ get; set; }
        public int IdentificacionCredito { get; set; }
        public int NroCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal ValorCuota { get; set; }

    }
}
