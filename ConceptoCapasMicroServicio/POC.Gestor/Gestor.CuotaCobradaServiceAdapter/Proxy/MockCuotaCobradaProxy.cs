using System;
using System.Collections.Generic;
using System.Text;
using CuotaCobradaService.DTO;

namespace Gestor.CuotaCobradaServiceAdapter.Proxy
{
    public class MockCuotaCobradaProxy : ICuotaCobradaServiceProxy
    {
        public RegistrarCobroCuotaRs RegistrarCobroCuota(RegistrarCobroCuotaRq rq)
        {
            RegistrarCobroCuotaRs rs = new RegistrarCobroCuotaRs() { IdRegistracion = 123 };
            return rs;
        }
    }
}
