using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarLibrosPorAutor
{
    internal class Libro
    {
        public Libro() { }
        public string nombre {  get; set; }
        public string autor {  get; set; }
        public int cantidad {  get; set; }

        public override string ToString()
        {
            return nombre + " de" + autor;
        }
    }
}
