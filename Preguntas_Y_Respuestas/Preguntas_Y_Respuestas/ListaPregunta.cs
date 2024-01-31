using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntas_Y_Respuestas
{
    internal class ListaPregunta
    {
        public string archivo = "Preguntas.csv";
        public List<Pregunta> CargarPreguntas()
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();

            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

            using(StreamReader sw = new StreamReader(fs))
            {
                
                string linea = sw.ReadLine();
                while (linea != null)
                {
                    
                    Pregunta pregunta = new Pregunta(linea);
                    listaPreguntas.Add(pregunta);
                    linea = sw.ReadLine();
                }
            }
            return listaPreguntas;
        }
    }
}
