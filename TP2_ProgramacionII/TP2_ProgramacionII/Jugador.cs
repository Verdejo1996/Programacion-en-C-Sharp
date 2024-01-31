using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_ProgramacionII
{
    internal class Jugador
    {
        public Jugador() { }
        public Jugador(string linea) 
        {
            string[] datos = linea.Split(',');

            this.Nombre = datos[0];
            this.Edad = datos[1];
            this.Posicion = datos[2];
            this.Equipo = datos[3];
            this.Pase = datos[4];
            this.Regate = datos[5];
            this.Defensa = datos[6];
            this.Ataque = datos[7];
            this.Disparo = datos[8];
        }

        public string Nombre {  get; set; }
        public string Edad {  get; set; }
        public string Posicion {  get; set; }
        public string Equipo { get; set; }
        public string Pase { get; set; }
        public string Regate { get; set; }
        public string Defensa {  get; set; }
        public string Ataque { get; set; }
        public string Disparo { get; set; }
    }
}
