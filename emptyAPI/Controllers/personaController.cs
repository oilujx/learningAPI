using emptyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Web.Http;
using static System.Net.Mime.MediaTypeNames;

namespace emptyAPI.Controllers
{
    public class personaController : ApiController
    {
        persona clPersona = null;

        [Route("api/Persona/"), HttpGet]
        public IHttpActionResult listarPersonas()
        {            
            clPersona = new persona();
            return Ok(clPersona.listadoPersonas());
        }

        [Route("api/Persona/misNumeros"), HttpGet]
        public IHttpActionResult misNumeros()
        {
            clPersona = new persona();
            return Ok(clPersona.misNumeros());
        }       

        [Route("api/Persona/"), HttpGet]
        public IHttpActionResult listarPersonas(int dpi)
        {            
            clPersona = new persona();            
            return Ok(clPersona.buscarPersona(dpi));
        }

        [Route("api/Persona/agregar"), HttpPost]
        public IHttpActionResult crearPersona(List<persona> _personas)
        {
            clPersona = new persona();

            List<persona> listaConPersonaNueva = new List<persona>();

            // listaConPersonaNueva = clPersona.agregarPersona(_personas);

            if (_personas.Count > 1)
            {
                listaConPersonaNueva = clPersona.agregarPersona(_personas);
            }
            else
            {
                persona newPerson = new persona();
                newPerson = _personas[0];

                listaConPersonaNueva = clPersona.agregarPersona(newPerson);
            }
            
            return Ok(listaConPersonaNueva);
        }

        

        [Route("api/Persona/json"), HttpPost]
        public IHttpActionResult json(persona _persona)
        {
            clPersona = new persona();

            string respuesta = clPersona.deserealizarObjeto(_persona);
            Console.WriteLine(respuesta);

            return Ok(clPersona.agregarPersona(_persona));
        }
    }
}
