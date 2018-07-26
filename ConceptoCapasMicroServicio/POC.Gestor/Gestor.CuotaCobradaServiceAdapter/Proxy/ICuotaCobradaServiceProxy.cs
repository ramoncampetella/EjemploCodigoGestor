using CuotaCobradaService.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.CuotaCobradaServiceAdapter.Proxy
{
    public interface ICuotaCobradaServiceProxy
    {
        RegistrarCobroCuotaRs RegistrarCobroCuota(RegistrarCobroCuotaRq rq);
    }
}
