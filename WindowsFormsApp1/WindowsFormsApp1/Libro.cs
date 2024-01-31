using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Libro
    {
        public string titulo {  get; set; }
        public string autor {  get; set; }
        public Libro() { }
        

        public override string ToString()
        {
            return "Libro: " + titulo + " Autor: " + autor;
        }
    }
}
