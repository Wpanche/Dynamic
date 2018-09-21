using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos;
using Microsoft.AspNetCore.Mvc;

namespace ServiceDynamic.Controllers
{
    
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpPost]
        [Route("api/recursive/{id}")]
        public IActionResult Get(string id, [FromBody] Parametros data)
        {
            try
            {
                AccesoDatos odo = new AccesoDatos();
                var datos = odo._Listar(id, data.parametros, 1, "");
                return Ok(datos);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
    }
}
