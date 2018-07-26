using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.BizEntities
{
    public abstract class AbstractPago
    {
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        //Registracion
        public int IdRegistracion { get; set; }
    }
}
