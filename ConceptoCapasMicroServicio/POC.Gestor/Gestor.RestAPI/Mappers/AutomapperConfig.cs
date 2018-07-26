using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor.RestAPI.Mappers
{
    public class AutomapperConfig
    {
        public class AutomapperConfig : Profile
        {
            public AutomapperConfig()
            {
                CreateMap<Cuota, RegistrarCobroCuotaRq>();
                CreateMap<RegistrarCobroCuotaRs, Cuota>();
            }

        }
    }
}
