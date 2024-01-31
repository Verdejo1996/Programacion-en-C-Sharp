using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preguntas_Y_Respuestas
{
    public partial class Form1 : Form
    {

        public int preguntaActualIndice;
        List<ListaRespuesta> listaRespuesta;
        List<ListaPregunta> listaPreguntas;

        public Form1()
        {
            InitializeComponent();
            listaPreguntas = new List<ListaPregunta>();
            listaRespuesta = new List<ListaRespuesta>();
            
            PreguntaActual();
            preguntaActualIndice = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PreguntaActual()
        {


            if (preguntaActualIndice < preguntas.Count && preguntaActualIndice < respuestas.Count)
            {
                Pregunta preguntaActual = preguntas[preguntaActualIndice];
                lblPregunta.Text = preguntaActual.Preguntas;

                Respuesta respuestaActual = respuestas[preguntaActualIndice];

                // Barajar las respuestas para que no siempre aparezca la correcta en el mismo botón
                List<string> respuestasBarajadas = new List<string>
                {
                    respuestaActual.Respuestas,
                    respuestaActual.Respuestas,
                    respuestaActual.Respuestas,
                    respuestaActual.Respuestas
                };

                respuestasBarajadas = respuestasBarajadas.OrderBy(x => Guid.NewGuid()).ToList();

                btnRespuesta1.Text = respuestasBarajadas[0];
                btnRespuesta2.Text = respuestasBarajadas[1];
                btnRespuesta3.Text = respuestasBarajadas[2];
                btnRespuesta4.Text = respuestasBarajadas[3];
            }
            else
            {

                MessageBox.Show("Has completado todas las preguntas.");
                ReiniciarJuego();
            }


        }
        private void VerificarRespuesta(string respuestaSeleccionada)
        {
            
            Pregunta preguntaActual = preguntas[preguntaActualIndice];
            Respuesta respuestaActual = respuestas[preguntaActualIndice];

            if (respuestaSeleccionada == respuestaActual.Respuestas)
            {
                MessageBox.Show("¡Respuesta correcta!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Respuesta incorrecta. La respuesta correcta es: {respuestaActual.Respuestas}", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Pasar a la siguiente pregunta
            preguntaActualIndice++;
            PreguntaActual();
        }

        private void ReiniciarJuego()
        {
            preguntaActualIndice = 0;
            PreguntaActual();
        }

        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(btnRespuesta1.Text);
        }

        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(btnRespuesta2.Text);
        }

        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(btnRespuesta3.Text);
        }

        private void btnRespuesta4_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(btnRespuesta4.Text);
        }
    }
}
