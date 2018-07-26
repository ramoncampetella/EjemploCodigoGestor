using AutoMapper;
using Gestor.BizEntities;
using System;
using System.Collections.Generic;
using System.Text;
using TarjetaCobradoService.DTO;

namespace Gestor.ResumenTarjetaCobradoServiceAdapter.Mappers
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ResumenTarjeta, RegistrarCobroResumenRq>();
            CreateMap<RegistrarCobroResumenRs, ResumenTarjeta>();
        }

        //public static void Config()
        //{
        //    Mapper.Initialize(cfg =>
        //    {
        //        cfg.CreateMap<ResumenTarjeta, RegistrarCobroResumenRq>();
        //        cfg.CreateMap<RegistrarCobroResumenRs, ResumenTarjeta>();
        //    });
        //}

    }
}
