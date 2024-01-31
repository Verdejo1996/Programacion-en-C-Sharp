using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarLibrosPorAutor
{
    internal class Gestor
    {
        public List<Libro> LeerLibros(string archivo)
        {
            List<Libro> libros = new List<Libro>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sw = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sw.ReadLine();

                    while(linea != null)
                    {
                        datos = linea.Split(',');

                        Libro libro = new Libro();
                        libro.nombre = datos[0];
                        libro.autor = datos[1];
                        libros.Add(libro);
                        linea = sw.ReadLine();
                    }
                    sw.Close();
                }
                
            }
            return libros;
        }

        public void Contar(List<Libro> libros)
        {
            var autoresContados = libros;
            Libro l = new Libro();
            
            for(int i = 0; i < libros.Count; i++)
            {
             
                
                for(int j = 0; j < libros.Count; j++)
                {
                    if (libros[i].autor == libros[j].autor)
                    {
                        l.cantidad++;
                    }
                }
                
            }
            
        }
    }
}
