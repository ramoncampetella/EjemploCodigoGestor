using AutoMapper;
using CuotaCobradaService.DTO;
using Gestor.BizEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.CuotaCobradaServiceAdapter.Mappers
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Cuota, RegistrarCobroCuotaRq>();
            CreateMap<RegistrarCobroCuotaRs, Cuota>();
        }

        //public static void Config()
        //{
        //    Mapper.Initialize(cfg =>
        //    {
        //        cfg.CreateMap<Cuota, RegistrarCobroCuotaRq>();
        //        cfg.CreateMap<RegistrarCobroCuotaRs, Cuota>();
        //    });
                
        //}
        
    }
}
