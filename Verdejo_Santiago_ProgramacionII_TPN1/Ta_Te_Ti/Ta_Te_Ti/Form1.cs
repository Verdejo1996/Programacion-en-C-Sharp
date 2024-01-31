using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ta_Te_Ti
{
    public partial class Form1 : Form
    {
        List<Button> listaBotones = new List<Button>();
        private int turno = 0;
        private char jugador = 'X';
        private bool BanderaGanador = false;
        private int jugadas = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void botones_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (string.IsNullOrEmpty(boton.Text) && !BanderaGanador)
            {
                if(turno == 0)
                {
                    jugador = 'X';
                    boton.Text = jugador.ToString();
                    turno = 1;
                    lblJugador.Text = "O";
                    Ganador(jugador);
                    jugadas++;
                }
                else
                {
                    jugador = 'O';
                    boton.Text = jugador.ToString();
                    turno = 0;
                    lblJugador.Text = "X";
                    Ganador(jugador);
                    jugadas++;
                }
                TableroLleno(jugadas);
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblJugador.Text = "X";
            listaBotones.Add(btn0);
            listaBotones.Add(btn1);
            listaBotones.Add(btn2);
            listaBotones.Add(btn3);
            listaBotones.Add(btn4);
            listaBotones.Add(btn5);
            listaBotones.Add(btn6);
            listaBotones.Add(btn7);
            listaBotones.Add(btn8);
            foreach(var boton in listaBotones)
            {
                boton.Enabled = false;
            }
        }

        private void Ganador(char jugador)
        {
            if (btn0.Text == jugador.ToString() && btn4.Text == jugador.ToString() && btn8.Text == jugador.ToString() ||
                btn0.Text == jugador.ToString() && btn3.Text == jugador.ToString() && btn6.Text == jugador.ToString() ||
                btn1.Text == jugador.ToString() && btn4.Text == jugador.ToString() && btn7.Text == jugador.ToString() ||
                btn2.Text == jugador.ToString() && btn5.Text == jugador.ToString() && btn8.Text == jugador.ToString() ||
                btn2.Text == jugador.ToString() && btn4.Text == jugador.ToString() && btn6.Text == jugador.ToString() ||
                btn3.Text == jugador.ToString() && btn4.Text == jugador.ToString() && btn5.Text == jugador.ToString() ||
                btn6.Text == jugador.ToString() && btn7.Text == jugador.ToString() && btn8.Text == jugador.ToString() ||
                btn0.Text == jugador.ToString() && btn1.Text == jugador.ToString() && btn2.Text == jugador.ToString())
            {
                DialogResult result = MessageBox.Show("Quiere jugar de nuevo?", "Gano el jugador " + jugador, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) { 
                BanderaGanador = true;
                Reiniciar();
                }
                else
                {
                    this.Close();
                        }
            }
        }

        private void Reiniciar()
        {
            BanderaGanador = false;
            jugadas = 0;
            turno= 0;
            lblJugador.Text = "X";
            for(int i = 0; i < 9; i++)
            {
                listaBotones[i].Text = "";
            }
            
        }

        private void TableroLleno(int jugadas)
        {
            if (jugadas < 9)
            {
                jugadas++;
            }
            else
            {
                MessageBox.Show("Quiere jugar de nuevo?", "Empate", MessageBoxButtons.YesNo);
                Reiniciar();
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            foreach(var boton in listaBotones)
            {
                boton.Enabled = true;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
