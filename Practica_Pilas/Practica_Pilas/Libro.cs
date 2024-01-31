using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pilas
{
    internal class Libro
    {
        public string titulo {  get; set; }
        public string autor {  get; set; }
        public Libro(string nombre, string autores) 
        {
            titulo = nombre;
            autor = autores;
        }

        public Libro() { }

        public override string ToString()
        {
            return titulo + ". " + autor;
        }
    }
}
