using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    internal class Prenda
    {
        public string nombrePrenda;
        public Prenda(string nombre)
        {
            nombrePrenda = nombre;
        }

        public Prenda() { }

        public override string ToString()
        {
            return nombrePrenda;
        }
    }
}
