using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.BizEntities
{
    public class BasePago
    {
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        //Registracion
        public int IdRegistracion { get; set; }
    }
}
