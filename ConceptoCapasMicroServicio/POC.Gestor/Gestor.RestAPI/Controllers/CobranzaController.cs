using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Gestor.API;
using Gestor.BizEntities;
using Gestor.RestAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Examples;

namespace Gestor.RestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Cobranza")]
    public class CobranzaController : Controller
    {
        private IManagerCobranza _managerCobranza;

        public CobranzaController(IManagerCobranza managerCobranza)
        {
            _managerCobranza = managerCobranza;
        }

        [HttpPost]
        [Route("/Registrar")]
        public CobranzaRs Registrar([FromBody]CobranzaRq rq)
        {
            var cobranza = Mapper.Map<Cobranza>(rq);

            _managerCobranza.Cobrar(ref cobranza);

            var rs = Mapper.Map<CobranzaRs>(cobranza);

            return rs;
        }
    }
}