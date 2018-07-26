using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestor.API;
using Gestor.RestAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public CobranzaRs Registrar([FromBody]CobranzaRq value)
        {

        }
    }
}