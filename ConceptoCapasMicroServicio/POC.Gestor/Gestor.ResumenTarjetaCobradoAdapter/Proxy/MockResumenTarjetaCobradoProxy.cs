using System;
using System.Collections.Generic;
using System.Text;
using TarjetaCobradoService.DTO;

namespace Gestor.ResumenTarjetaCobradoServiceAdapter.Proxy
{
    public class MockResumenTarjetaCobradoProxy : IResumenTarjetaCobradoProxy
    {
        public RegistrarCobroResumenRs RegistrarCobroResumen(RegistrarCobroResumenRq rq)
        {
            RegistrarCobroResumenRs rs = new RegistrarCobroResumenRs() { IdRegistracion = 456 };
            return rs;
        }
    }
}
