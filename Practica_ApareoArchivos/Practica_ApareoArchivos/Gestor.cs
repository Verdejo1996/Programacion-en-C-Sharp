using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ApareoArchivos
{
    internal class Gestor
    {
        public List<Autor> LeerAutores(string archivo)
        {
            List<Autor> autoresLista = new List<Autor>();

            using (FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sw = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sw.ReadLine();

                    while(linea != null)
                    {
                        datos = linea.Split(',');

                        Autor autor = new Autor();
                        autor.id = int.Parse(datos[0]);
                        autor.nombre = datos[1];

                        autoresLista.Add(autor);
                        linea = sw.ReadLine();
                    }
                }
                fs.Close();
            }
            return autoresLista;
        }

        public List<Libro> Libros(string archivo, Autor autor)
        {
            List<Libro> librosLista = new List<Libro>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sw =new StreamReader(fs))
                {
                    string linea = sw.ReadLine();
                    string[] datos;

                    while( linea != null && librosLista.Count == 0)
                    {
                        datos = linea.Split(',');

                        if(autor.id == int.Parse(datos[0]))
                        {
                            Libro libro = new Libro();
                            Libro libro1 = new Libro();

                            libro.libro = datos[1];
                            libro1.libro1 = datos[2];

                            librosLista.Add(libro);
                            librosLista.Add(libro1);
                            
                        }
                        else
                        {
                            linea = sw.ReadLine();
                        }
                    }
                }
                fs.Close();
            }
            return librosLista;
        }
    }
}
