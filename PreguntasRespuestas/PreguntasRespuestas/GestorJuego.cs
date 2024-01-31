using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestas
{
    internal class GestorJuego
    {
        public List<Pregunta> CargarPreguntas(string archivo)
        {
            List<Pregunta> preguntasArchivo = new List<Pregunta>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sr.ReadLine();

                    while(linea  != null)
                    {
                        datos = linea.Split(',');

                        Pregunta pregunta = new Pregunta();
                        pregunta.id = datos[0];
                        pregunta.pregunta = datos[1];

                        preguntasArchivo.Add(pregunta);
                        linea = sr.ReadLine();
                    }
                }
                fs.Close();
            }
            return preguntasArchivo;
        }

        public List<Respuesta> ApareoRespuestas(string archivo, Pregunta pr)
        {
            List<Respuesta> respuestas = new List<Respuesta>();

            using(FileStream fs = new FileStream(archivo,FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = reader.ReadLine();

                    while(linea != null && respuestas.Count == 0)
                    {
                        datos = linea.Split(',');

                        if(pr.id == datos[0])
                        {
                            Respuesta respuesta1 = new Respuesta();
                            Respuesta respuesta2 = new Respuesta();
                            Respuesta respuesta3 = new Respuesta();
                            Respuesta respuesta4 = new Respuesta();

                            respuesta1.respuesta1 = datos[1];
                            respuesta2.respuesta2 = datos[2];
                            respuesta3.respuesta3 = datos[3];
                            respuesta4.respuesta4 = datos[4];

                            respuestas.Add(respuesta1);
                            respuestas.Add(respuesta2);
                            respuestas.Add(respuesta3);
                            respuestas.Add(respuesta4);
                        }
                        else
                        {
                            linea = reader.ReadLine();
                        }
                    }
                    fs.Close();
                }
            }
            return respuestas;
        }
    }
}
