using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_ProgramacionII
{
    internal class ListaJugadores
    {
        public List<Jugador> CargaJugadores(string archivo)
        {
            List<Jugador> lista = new List<Jugador>();

            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);


            using (StreamReader sw = new StreamReader(fs))
            {
                string linea = sw.ReadLine();
                while (linea != null)
                {
                    Jugador jugador = new Jugador(linea);
                    lista.Add(jugador);
                    linea = sw.ReadLine();
                }

            }
            fs.Close();
            return lista;
        }
    }
}
