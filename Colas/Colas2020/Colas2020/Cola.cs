using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas2020
{
    class Cola
    {
        Nodo _inicio;

        public void Encolar(Nodo unNodo)
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(_inicio);
                aux.Siguiente = unNodo;
            }
        }

        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }



        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }



        public bool Vacia()
        {
            return (_inicio == null);
        }

    }
}
