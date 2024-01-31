using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Gestor
    {
        //string archivoPreguntas = "Preguntas.csv";
        public List<Pregunta> LeerPreguntas(string archivo)
        {
            List<Pregunta> preguntasLista = new List<Pregunta>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sw = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sw.ReadLine();
                    
                    while(linea != null)
                    {
                        datos = linea.Split(',');

                        Pregunta preguntaleida = new Pregunta();
                        preguntaleida.id = datos[0];
                        preguntaleida.cuestionario = datos[1];

                        preguntasLista.Add(preguntaleida);
                        linea = sw.ReadLine();
                    }
                }
                fs.Close();
            }
            return preguntasLista;
        }

        //string archivoRespuestas = "Respuestas.csv";
        public List<Respuesta> LeerRespuestas(string archivoRespuestas, Pregunta pr)
        {
            List<Respuesta> respuestasLista = new List<Respuesta>();

            using (FileStream fs = new FileStream(archivoRespuestas, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    string linea = sw.ReadLine();
                    string[] datos;

                    while (linea != null && respuestasLista.Count == 0)
                    {
                        datos = linea.Split(',');

                        if(pr.id == datos[0])
                        {
                            Respuesta respuesta = new Respuesta();
                            Respuesta respuesta1 = new Respuesta();
                            Respuesta respuesta2 = new Respuesta();
                            Respuesta respuesta3 = new Respuesta();
                            Respuesta respuesta4 = new Respuesta();
                            respuesta.respuesta = datos[1];
                            respuesta1.respuesta1 = datos[2];
                            respuesta2.respuesta2 = datos[3];
                            respuesta3.respuesta3 = datos[4];

                            respuestasLista.Add(respuesta);
                            respuestasLista.Add(respuesta1);
                            respuestasLista.Add(respuesta2);
                            respuestasLista.Add(respuesta3);

                        }
                        else
                        {
                            linea = sw.ReadLine();
                        }
                    }
                }
                fs.Close();
            }
            return respuestasLista;
        }
    }
}
