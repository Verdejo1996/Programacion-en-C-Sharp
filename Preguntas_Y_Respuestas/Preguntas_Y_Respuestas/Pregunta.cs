using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntas_Y_Respuestas
{
    internal class Pregunta
    {
        public int Id {  get; set; }
        public string Preguntas {  get; set; }

        public Pregunta(string Preguntas)
        {
            var datos = Preguntas.Split(',');

            this.Id = int.Parse(datos[0]);
            this.Preguntas = datos[1];
        }
    }
}
