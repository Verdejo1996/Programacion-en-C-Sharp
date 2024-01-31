using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ApareoArchivos
{
    internal class Autor
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public List<Libro> Libros { get; set; }

        public override string ToString()
        {
            return "Nombre: " + nombre;
        }
    }
}
