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
                                ));
                    
            CreateMap<MedioPagoDTO, MedioPago>();

            CreateMap<BasePagoDTORq, BasePago>();
            CreateMap<BasePago, BasePagoDTORs>();
            CreateMap<PagoCuotaDTORq, Cuota>();
            CreateMap<Cuota, PagoCuotaDTORs>();
            CreateMap<PagoResumenTarjetaDTORq, ResumenTarjeta>();
            CreateMap<ResumenTarjeta, PagoResumenTarjetaDTORs>();
            CreateMap<Cobranza, CobranzaRs>()
                    .ForMember(dest => dest.Cuotas,
                            opt => opt.MapFrom(
                                src => Mapper.Map<List<Cuota>, List<PagoCuotaDTORs>>(src.Pagos.OfType<Cuota>().ToList())
                                ))
                    .ForMember(dest => dest.Resumenes,
                            opt => opt.MapFrom(
                                src => Mapper.Map<List<ResumenTarjeta>, List<PagoResumenTarjetaDTORs>>(src.Pagos.OfType<ResumenTarjeta>().ToList())
                                ));
        }

        
    }
}
