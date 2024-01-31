using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntas_Y_Respuestas
{
    internal class ListaRespuesta
    {
        public string archivo = "Respuestas.csv";
        public List<Respuesta> CargarRespuestas()
        {
            List<Respuesta> listaRespuesta = new List<Respuesta>();

            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

            using (StreamReader sw = new StreamReader(fs))
            {
                
                string linea = sw.ReadLine();
                while (linea != null)
                {
                    
                    Respuesta respuesta = new Respuesta(linea);
                    listaRespuesta.Add(respuesta);
                    linea = sw.ReadLine();
                }
            }

            return listaRespuesta;
        }
    }
}
