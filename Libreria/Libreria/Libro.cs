using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Libro
    {
        public string libro {  get; set; }
        public string autor {  get; set; }

        public override string ToString()
        {
            return libro + " de " + autor;
        }
    }
}
