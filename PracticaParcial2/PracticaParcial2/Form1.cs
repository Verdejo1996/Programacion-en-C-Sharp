using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial2
{
    public partial class Form1 : Form
    {
        Gestor jugador = new Gestor();

        List<Pregunta> preguntaVista = new List<Pregunta>();
        List<Pregunta> preguntasQueSalieron = new List<Pregunta>();

        Pregunta preguntaEnLista = new Pregunta();

        string archivoPreguntas = "Preguntas.csv";
        string archivoRespuestas = "Respuestas.csv";

        public int puntos;
        public int preguntaActualIndice;
        public int tiempoRestante = 10;

        public Timer temporizador = new Timer();
        
        public Form1()
        {
            InitializeComponent();

            preguntaActualIndice = 0;
            puntos = 0;

            preguntaVista = jugador.LeerPreguntas(archivoPreguntas);
            preguntaEnLista = preguntaVista[preguntaActualIndice];
            preguntasQueSalieron.Add(preguntaEnLista);
            preguntaEnLista.Respuestas = jugador.LeerRespuestas(archivoRespuestas, preguntaEnLista);

            temporizador.Interval = 1000;
            temporizador.Tick += new EventHandler(Temporizador_Tick);

            CargarJuego(preguntaEnLista);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temporizador.Start();
        }

        private void CargarJuego(Pregunta pregunta)
        {
            lblPregunta.Text = preguntaEnLista.cuestionario;
            txtPuntos.Text = puntos.ToString();

            // Barajar las respuestas para que no siempre aparezca la correcta en el mismo botón
            List<string> respuestasBarajadas = new List<string>
            {
                pregunta.Respuestas[0].respuesta,
                pregunta.Respuestas[1].respuesta1,
                pregunta.Respuestas[2].respuesta2,
                pregunta.Respuestas[3].respuesta3
            };

            respuestasBarajadas = respuestasBarajadas.OrderBy(x => Guid.NewGuid()).ToList();

            btnRespuesta1.Text = respuestasBarajadas[0];
            btnRespuesta2.Text = respuestasBarajadas[1];
            btnRespuesta3.Text = respuestasBarajadas[2];
            btnRespuesta4.Text = respuestasBarajadas[3];
        }

        private void RespuestaCorrecta(object sender)
        {
            string respuestaCorrecta = preguntaEnLista.Respuestas[0].respuesta;
            Button button = sender as Button;
            string respuestaSeleccionada = button.Text;

            if (respuestaSeleccionada == respuestaCorrecta)
            {
                temporizador.Stop();
                MessageBox.Show("Correcto");

                puntos++;
                tiempoRestante = 10;

                if (preguntasQueSalieron.Count == 5)
                {
                    
                    DialogResult result = MessageBox.Show("El juego termino. Quiere jugar de nuevo?", "Ganaste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        preguntasQueSalieron.Clear();
                        Reiniciar();
                    }
                    else
                    {
                        this.Close();
                    }
                }

                else
                {
                    preguntaActualIndice++;
                    temporizador.Start();

                    preguntaEnLista = preguntaVista[preguntaActualIndice];
                    while (preguntasQueSalieron.Contains(preguntaEnLista))
                    {
                        preguntaEnLista = preguntaVista[preguntaActualIndice++];
                    }
                    preguntasQueSalieron.Add(preguntaEnLista);
                    preguntaEnLista.Respuestas = jugador.LeerRespuestas(archivoRespuestas, preguntaEnLista);
                    CargarJuego(preguntaEnLista);
                }

            }
            else
            {
                temporizador.Stop();
                DialogResult result = MessageBox.Show("No acertaste. Quiere jugar de nuevo?", "Perdiste", MessageBoxButtons.YesNo);
                temporizador.Stop();
                if(result == DialogResult.Yes)
                {
                    preguntasQueSalieron.Clear();
                    Reiniciar();
                }
                else this.Close();
            }
        }


        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta(sender);
        }

        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta(sender);
        }

        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta(sender);
        }

        private void btnRespuesta4_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta(sender);
        }

        private void Reiniciar()
        {
            tiempoRestante = 10;
            temporizador.Start();

            preguntaActualIndice = 0;
            puntos = 0;
            preguntaVista = jugador.LeerPreguntas(archivoPreguntas);
            
            preguntaEnLista = preguntaVista[preguntaActualIndice];
            preguntasQueSalieron.Add(preguntaEnLista);
            preguntaEnLista.Respuestas = jugador.LeerRespuestas(archivoRespuestas, preguntaEnLista);

            CargarJuego(preguntaEnLista);
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            txtTiempo.Text = tiempoRestante.ToString();

            if(tiempoRestante == 0)
            {
                temporizador.Stop();
                DialogResult result = MessageBox.Show("Tiempo agotado.Quiere jugar de nuevo?", "Perdiste", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    preguntasQueSalieron.Clear();
                    Reiniciar();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
