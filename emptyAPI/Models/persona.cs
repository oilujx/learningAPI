using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emptyAPI.Models
{
    public class persona
    {
        public string nombres { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        public int dpi { get; set; } 

        public persona(string _nombres, int _edad, string _genero, int _dpi) {
            nombres = _nombres;
            edad = _edad;
            genero = _genero;        
            dpi = _dpi;
        }
        public persona() { }

        public List<persona> listadoPersonas()
        {
            List<persona> personas = new List<persona>();           

            personas.Add(new persona() { nombres = "Julio Luna", edad = 35, genero = "M", dpi = 123 });
            personas.Add(new persona() { nombres = "Kevin Garcia", edad = 30, genero = "M", dpi = 456 });
            personas.Add(new persona() { nombres = "Magoo Sabatino", edad = 45, genero = "M", dpi = 789 });
            personas.Add(new persona() { nombres = "Lord Cachetes", edad = 38, genero = "M", dpi = 1011 });

            return personas;
        }

        public persona listarPersona(int dpi)
        {
            return listadoPersonas().Find(p => p.dpi == dpi);
        }

        public List<persona> agregarPersona(List<persona> listaPersonas, persona _persona)
        {
            listaPersonas.Add(_persona);
            return listaPersonas;
        }
    }
}