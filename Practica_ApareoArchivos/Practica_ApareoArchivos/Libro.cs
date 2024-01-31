using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ApareoArchivos
{
    internal class Libro
    {

        public string libro {  get; set; }
        public string libro1 { get; set; }

        public override string ToString()
        {
            return "Titulos del autor: " + libro + libro1;
        }
    }
}
