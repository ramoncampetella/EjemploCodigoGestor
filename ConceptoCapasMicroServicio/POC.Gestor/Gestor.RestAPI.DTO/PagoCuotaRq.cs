﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.RestAPI.DTO
{
    public class PagoCuotaRq : BasePagoDTORq
    {
        public int CuentaCredito { get; set; }
        public int IdentificacionCredito { get; set; }
        public int NroCuota { get; set; }
    }
}
