using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Supermercado.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GetTesteControler : ControllerBase
    {
        [HttpGet]
        public ActionResult GetBlaBla()
        {
            return Ok("GetBlaBla");
        }

        [HttpPost]
        public ActionResult PostBlaBla()
        {
            return Ok("PostBlaBla");
        }
    }
}