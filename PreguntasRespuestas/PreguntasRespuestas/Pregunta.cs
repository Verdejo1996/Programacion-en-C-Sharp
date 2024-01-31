using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestas
{
    internal class Pregunta
    {
        public string id {  get; set; }
        public string pregunta { get; set; }
        public Pregunta() { }

        public List<Respuesta> Respuesta { get; set; }
    }
}
