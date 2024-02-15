using emptyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace emptyAPI.Controllers
{
    public class personaController : ApiController
    {
        persona clPersona = new persona();

        [Route("api/Persona/"), HttpGet]
        public IHttpActionResult listarPersonas()
        {
            clPersona = new persona();
            return Ok(clPersona.listadoPersonas());
        }

        [Route("api/Persona/"), HttpGet]
        public IHttpActionResult listarPersonas(int dpi)
        {
            clPersona = new persona();
            return Ok(clPersona.listarPersona(dpi));
        }

        [Route("api/Persona/agregar"), HttpPost]
        public IHttpActionResult crearPersona(persona _persona)
        {
            clPersona = new persona();
            return Ok(clPersona.agregarPersona(clPersona.listadoPersonas(), _persona));
        }
    }
}
