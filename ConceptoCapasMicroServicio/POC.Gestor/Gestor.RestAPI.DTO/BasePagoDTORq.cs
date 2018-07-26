using System;

namespace Gestor.RestAPI.DTO
{
    public class BasePagoDTORq
    {
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
    }
}