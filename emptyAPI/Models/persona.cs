using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace emptyAPI.Models
{
    public class persona
    {
        //DEFINICION DE PROPIEDADES
        // LAS PROPIEDADES SON ATRIBUTOS DE LAS CLASES
        // SON COMO SUS CARACTERISTICAS
        // ES LO QUE DEFINE A UN OBJETO
        // POR EJEMPLO UNA PERSONA TIENE NOMBRES, EDAD, SEXO, ESTATURA, ETC....
        // VOS A MANOSEAR
        public string nombres { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        public int dpi { get; set; }
        //private float iva { get; set; }

        //DEFINICION DE CONSTRUCTOR
        public persona(string _nombres, int _edad, string _genero, int _dpi) {
            nombres = _nombres;
            edad = _edad;
            genero = _genero;        
            dpi = _dpi;
        }
        public persona() { }

        #region definicionMetodos
        public List<persona> listadoPersonas()
        {
            List<persona> listadoDePersonas = new List<persona>();   

            persona persona1 = new persona();
            persona1.nombres = "Julio";
            persona1.edad = 35;
            persona1.genero = "M";
            persona1.dpi = 123;

            listadoDePersonas.Add(persona1);

            persona persona2 = new persona("Kevin", 30, "M", 456);

            listadoDePersonas.Add(persona2);

            listadoDePersonas.Add(new persona() { dpi = 789, genero = "M", nombres = "Magoo Sabatino", edad = 89 });

            listadoDePersonas.Add(new persona() { nombres = "Lord Cachetes", edad = 38, genero = "M", dpi = 1011 });

            return listadoDePersonas;
        }
        public persona  buscarPersona(int _dpi)
        {
            List<persona> miListaPersonas = new List<persona>();
            persona personaEncontrada = new persona();

            miListaPersonas = listadoPersonas();

            for (int i = 0; i < miListaPersonas.Count; i++)
            {
                if (miListaPersonas[i].dpi == _dpi)
                {
                    personaEncontrada = miListaPersonas[i];
                }
            }

            //personaEncontrada = miListaPersonas.Find(miItem => miItem.dpi == _dpi);

            return personaEncontrada;
        }
        public List<persona> agregarPersona(persona _nuevaPersona)
        {
            List<persona> listaPersonas = new List<persona>();

            listaPersonas = listadoPersonas();

            listaPersonas.Add(_nuevaPersona);

            return listaPersonas;
        }

        public List<persona> agregarPersona(List<persona> personas)
        {
            List<persona> listaPersonas = new List<persona>();

            listaPersonas = listadoPersonas();

            for(int i = 0;i < personas.Count;i++)
            {
                listaPersonas.Add(personas[i]);
            }

            return listaPersonas;
        }
        public List<int> misNumeros()
        {
            int num1 = 100;
            int num2 = 40;
            int num3 = 50;
            int num4 = 4;
            int num5 = 9;
           
            List<int> miLista = new List<int>();

            miLista.Add(num1);
            miLista.Add(num2);
            miLista.Add(num3);
            miLista.Add(num4);
            miLista.Add(num5);

            return miLista;
            

        }
        public List<int> misNumerosConFor()
        {            
            List<int> miLista = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                miLista.Add(i + 1);
            }           

            return miLista;
        }

        public string deserealizarObjeto(persona miPersona)
        {
            string jsonObjeto = JsonConvert.SerializeObject(miPersona);

            persona nuevaPersona = new persona();

            nuevaPersona = JsonConvert.DeserializeObject<persona>(jsonObjeto);


            return jsonObjeto;
        }
        #endregion
    }
}
