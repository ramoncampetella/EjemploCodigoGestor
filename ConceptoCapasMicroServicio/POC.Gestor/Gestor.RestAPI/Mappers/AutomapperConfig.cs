using AutoMapper;
using Gestor.BizEntities;
using Gestor.RestAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor.RestAPI.Mappers
{
    public class AutomapperConfig : Profile
    {
        
        public AutomapperConfig()
        {
            CreateMap<Cobranza, CobranzaRs>();

            CreateMap<CobranzaRq, Cobranza>()
                    .ForMember(dest => dest.Pagos,
                            opt => opt.MapFrom(
                                src => Mapper.Map<List<PagoResumenTarjetaDTORq>, List<ResumenTarjeta>>(src.ResumenesTarjetaPagos)
                                ))
                    .ForMember(dest => dest.Pagos,
                            opt => opt.MapFrom(
                                src => Mapper.Map<List<PagoCuotaDTORq>, List<Cuota>>(src.CuotasPagas)
                                ));

            CreateMap<MedioPagoDTO, MedioPago>();

            CreateMap<BasePagoDTORq, BasePago>();
            CreateMap<BasePago, BasePagoDTORs>();
            CreateMap<PagoCuotaDTORq, Cuota>();
            CreateMap<Cuota, PagoCuotaDTORs>();
            CreateMap<PagoResumenTarjetaDTORq, ResumenTarjeta>();
            CreateMap<ResumenTarjeta, PagoResumenTarjetaDTORs>();
        }

        
    }
}
