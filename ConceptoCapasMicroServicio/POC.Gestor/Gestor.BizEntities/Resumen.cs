﻿using System;

namespace Gestor.BizEntities
{
    public class ResumenTarjeta : BasePago
    {
        public DateTime FechaVencimiento{ get; set; }
        public decimal Consumo { get; set; }
        public int NumeroCuenta { get; set; }
        public string TipoTarjeta { get; set; }
    }
}