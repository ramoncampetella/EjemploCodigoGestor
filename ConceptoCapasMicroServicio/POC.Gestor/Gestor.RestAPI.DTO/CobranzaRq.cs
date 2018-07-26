using System;
using System.Collections.Generic;

namespace Gestor.RestAPI.DTO
{
    public class CobranzaRq
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public List<PagoCuotaDTORq> CuotasPagas { get; set; }
        public List<PagoResumenTarjetaDTORq> ResumenesTarjetaPagos { get; set; }
        public List<MedioPagoDTO> MediosPago { get; set; }
        public decimal MontoTotalCobranza { get; set; }
    }
}
