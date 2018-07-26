using System;
using AutoMapper;
using CuotaCobradaService.DTO;
using Gestor.BizEntities;
using Gestor.CuotaCobradaServiceAdapter.Proxy;

namespace Gestor.CuotaCobradaServiceAdapter
{

    public class CuotaCobradaService : ICuotaCobradaService
    {
        private ICuotaCobradaServiceProxy _cuotaCobradaService;

        public CuotaCobradaService(ICuotaCobradaServiceProxy cuotaCobradaService)
        {
            _cuotaCobradaService = cuotaCobradaService;
        }

        public void RegistrarCobro(ref Cuota cuota)
        {
            //builder de objetos y llamada al servicio
            var rq = Mapper.Map<RegistrarCobroCuotaRq>(cuota);

            var rs = _cuotaCobradaService.RegistrarCobroCuota(rq);

            Mapper.Map(rs, cuota);
        }
    }
}
