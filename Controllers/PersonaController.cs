using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace apiDemo.Controllers
{
 
    [ApiController] 
    [Route("api/[controller]")]
    public class PersonaController : controllerBase
    {
        private readonly List<Persona> persona = new List<Persona>();

        public PersonaController(){
            persona.Add(new Persona(){
                id=1,
                Nombre = "Luis Garcia",
                Email = "lusito"
                Domicio = "sarasa"
                Foto = "asadasd",
                Activo = true,
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get(){
            return OK(Persona);
        }
    }
}