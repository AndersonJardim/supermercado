using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Supermercado.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SupermercadoController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetSupermercado()
        {
            return Ok("ok");
        }
    }
}