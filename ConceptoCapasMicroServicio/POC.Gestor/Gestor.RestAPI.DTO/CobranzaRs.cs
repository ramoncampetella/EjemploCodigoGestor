using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.RestAPI.DTO
{
    public class CobranzaRs
    {
        public List<PagoCuotaDTORs> Cuotas { get; set; }
        public List<PagoResumenTarjetaDTORs> Resumenes { get; set; }
    }
}
