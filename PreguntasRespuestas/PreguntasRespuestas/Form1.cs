using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreguntasRespuestas
{
    public partial class Form1 : Form
    {
        GestorJuego gestor = new GestorJuego();
        List<Pregunta> preguntas = new List<Pregunta>();
        List<Pregunta> prVistas = new List<Pregunta>();

        Pregunta prJuego = new Pregunta();

        string archivoPreguntas = "Preguntas.csv";
        string archivoRespuestas = "Respuestas.csv";

        int indicePreguntas;

        public Form1()
        {
            InitializeComponent();

            indicePreguntas=0;

            preguntas = gestor.CargarPreguntas(archivoPreguntas);
            prJuego = preguntas[indicePreguntas];
            prVistas.Add(prJuego);
            prJuego.Respuesta = gestor.ApareoRespuestas(archivoRespuestas, prJuego);

            CargarJuego(prJuego);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarJuego(Pregunta pregunta)
        {
            lblPregunta.Text = pregunta.pregunta;

            btnRespuesta1.Text = pregunta.Respuesta[0].respuesta1;
            btnRespuesta2.Text = pregunta.Respuesta[1].respuesta2;
            btnRespuesta3.Text = pregunta.Respuesta[2].respuesta3;
            btnRespuesta4.Text = pregunta.Respuesta[3].respuesta4;
        }

        private void RespuestaCorrecta(object sender)
        {
            string respuestaCorrecta = prJuego.Respuesta[0].respuesta1;
            Button button = sender as Button;
            string respuestaSeleccionada = button.Text;

            if(respuestaCorrecta == respuestaSeleccionada)
            {
                MessageBox.Show("Respuesta correcta");

                if(prVistas.Count == 5 )
                {
                    MessageBox.Show("El juego termino");
                    this.Close();
                }
                else
                {
                    indicePreguntas++;
                    prJuego = preguntas[indicePreguntas];
                    while (prVistas.Contains(prJuego))
                    {
                        prJuego = preguntas[indicePreguntas++];
                    }
                    prVistas.Add(prJuego);
                    prJuego.Respuesta = gestor.ApareoRespuestas(archivoRespuestas, prJuego);

                    CargarJuego(prJuego);
                }


            }
            else
            {
                MessageBox.Show("No acertaste. Perdiste");
                this.Close();
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
    }
}
