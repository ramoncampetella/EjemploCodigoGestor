using System;
using AutoMapper;
using Gestor.BizEntities;
using Gestor.ResumenTarjetaCobradoServiceAdapter.Proxy;
using TarjetaCobradoService.DTO;

namespace Gestor.ResumenTarjetaCobradoAdapter
{
    public class ResumenTarjetaCobradoService : IResumenTarjetaCobradoService
    {
        private IResumenTarjetaCobradoProxy _resumenTarjetaCobradoProxy;

        public ResumenTarjetaCobradoService(IResumenTarjetaCobradoProxy resumenTarjetaCobradoProxy)
        {
            _resumenTarjetaCobradoProxy = resumenTarjetaCobradoProxy;
        }

        public void RegistrarCobro(ref ResumenTarjeta resumen)
        {
            //builder de objetos y llamada al servicio
            var rq = Mapper.Map<RegistrarCobroResumenRq>(resumen);

            var rs = _resumenTarjetaCobradoProxy.RegistrarCobroResumen(rq);

            Mapper.Map(rs, resumen);
        }
    }
}
