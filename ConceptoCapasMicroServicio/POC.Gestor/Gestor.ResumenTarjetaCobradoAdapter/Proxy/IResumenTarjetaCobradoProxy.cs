using System;
using System.Collections.Generic;
using System.Text;
using TarjetaCobradoService.DTO;

namespace Gestor.ResumenTarjetaCobradoServiceAdapter.Proxy
{
    public interface IResumenTarjetaCobradoProxy
    {
        RegistrarCobroResumenRs RegistrarCobroResumen(RegistrarCobroResumenRq rq);
    }
}
