using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicanumeromil
{
    internal class GestorJuego
    {
        public List<Pregunta> LeerPreguntas(string archivo)
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sr.ReadLine();

                    while(linea != null)
                    {
                        datos = linea.Split(',');
                        Pregunta pr = new Pregunta();
                        pr.id = int.Parse(datos[0]);
                        pr.pregunta = datos[1];
                        listaPreguntas.Add(pr);
                        linea = sr.ReadLine();
                    }
                }
                fs.Close();
            }
            return listaPreguntas;
        }

        public List<Respuesta> ListaRespuesta(string archivo, Pregunta pr)
        {
            List<Respuesta> respuestasLista = new List<Respuesta>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader  reader = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = reader.ReadLine();

                    while(linea != null && respuestasLista.Count == 0)
                    {
                        datos = linea.Split(',');

                        if(pr.id == int.Parse(datos[0]))
                        {
                            Respuesta rp = new Respuesta();
                            Respuesta rp1 = new Respuesta();
                            Respuesta rp2 = new Respuesta();
                            Respuesta rp3 = new Respuesta();
                            rp.respuesta = datos[1];
                            rp1.respuesta1 = datos[2];
                            rp2.respuesta2 = datos[3];
                            rp3.respuesta3 = datos[4];
                            respuestasLista.Add(rp);
                            respuestasLista.Add(rp1); 
                            respuestasLista.Add(rp2); 
                            respuestasLista.Add(rp3);
                        }
                        else
                        {
                            linea = reader.ReadLine();

                        }
                    }
                }
                fs.Close();
            }
            return respuestasLista;
        }
    }
}
