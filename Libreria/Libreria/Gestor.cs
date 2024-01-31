using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Gestor
    {
        public Stack<Libro> CargarStackLibros(string archivo)
        {
            Stack<Libro> libros = new Stack<Libro>();

            using(FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sr.ReadLine();

                    while(linea != null)
                    {
                        datos = linea.Split(';');
                        Libro libro = new Libro();
                        libro.libro = datos[0];
                        libro.autor = datos[1];
                        libros.Push(libro);
                        linea = sr.ReadLine();
                    }
                }
                fs.Close();
            }
            return libros;
        }
    }
}
