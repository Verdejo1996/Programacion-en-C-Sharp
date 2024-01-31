using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicanumeromil
{
    public partial class Form1 : Form
    {
        GestorJuego gestor = new GestorJuego();

        List<Pregunta> preguntasDeLaLista = new List<Pregunta>();
        List<Pregunta> preguntasQueYaSalieron = new List<Pregunta>();

        Pregunta preg = new Pregunta();

        string archivoPreguntas = "Preguntas.csv";
        string archivoRespuestas = "Respuestas.csv";

        public int indicePreguntas;

        public Form1()
        {
            InitializeComponent();

            indicePreguntas = 0;

            preguntasDeLaLista = gestor.LeerPreguntas(archivoPreguntas);
            preg = preguntasDeLaLista[indicePreguntas];
            preguntasQueYaSalieron.Add(preg);
            preg.respuesta = gestor.ListaRespuesta(archivoRespuestas, preg);

            CargarJuego(preg);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarJuego(Pregunta pregunta)
        {
            lblPregunta.Text = preg.pregunta;

            List<string> rpBarajar = new List<string>
            {
                pregunta.respuesta[0].respuesta,
                pregunta.respuesta[1].respuesta1,
                pregunta.respuesta[2].respuesta2,
                pregunta.respuesta[3].respuesta3

            };

            rpBarajar = rpBarajar.OrderBy(x => Guid.NewGuid()).ToList();

            btnRespuesta1.Text = rpBarajar[0];
            btnRespuesta2.Text = rpBarajar[1];
            btnRespuesta3.Text = rpBarajar[2];
            btnRespuesta4.Text = rpBarajar[3];
        }

        private void RespuestaCorrecta(object sender)
        {
            string respuestaCorrecta = preg.respuesta[0].respuesta;
            Button button = sender as Button;
            string respuestaSelecciona = button.Text;

            if(respuestaCorrecta == respuestaSelecciona)
            {
                MessageBox.Show("Correcto");

                if(preguntasQueYaSalieron.Count == 5)
                {
                    MessageBox.Show("Listo");
                }
                else
                {
                    indicePreguntas++;

                    preg = preguntasDeLaLista[indicePreguntas];
                    while (preguntasQueYaSalieron.Contains(preg))
                    {
                        preg = preguntasDeLaLista[indicePreguntas++];
                    }
                    preguntasQueYaSalieron.Add(preg);
                    preg.respuesta = gestor.ListaRespuesta(archivoRespuestas, preg);
                    CargarJuego(preg);
                }
            }
            else
            {
                MessageBox.Show("fuiste");
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
