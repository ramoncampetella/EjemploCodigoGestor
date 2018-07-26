using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.RestAPI.DTO
{
    public class PagoResumenTarjetaRq : BasePagoDTORq
    {
        public int NumeroCuenta { get; set; }
        public string TipoTarjeta { get; set; }
    }
}
