using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Pregunta
    {
        public string id { get; set; }
        public string cuestionario { get; set; }

        public List<Respuesta> Respuestas {  get; set; }
    }
}
