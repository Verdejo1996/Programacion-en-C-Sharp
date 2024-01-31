using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntas_Y_Respuestas
{
    internal class Respuesta
    {
        public int Id {  get; set; }
        public string Respuestas {  get; set; }

        public Respuesta(string respuestas)
        {
            var datos = respuestas.Split(',');

            this.Id = int.Parse(datos[0]);
            this.Respuestas = datos[1];
        }
    }
}
