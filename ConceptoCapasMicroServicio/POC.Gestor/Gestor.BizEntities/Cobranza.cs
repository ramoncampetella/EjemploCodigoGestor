using System;
using System.Collections.Generic;

namespace Gestor.BizEntities
{
    public class Cobranza
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public List<BasePago> Pagos { get; set; }
        public List<MedioPago> MediosPago { get; set; }
        public decimal MontoTotalCobranza { get; set; }
    }
}
