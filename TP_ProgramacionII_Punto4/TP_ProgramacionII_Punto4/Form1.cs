using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_ProgramacionII_Punto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int x, n, suma;

            if (int.TryParse(txtNum1.Text, out x) && (int.TryParse(txtNum2.Text, out n)))
            {
                suma = x + n;
                lblSumar.Text = suma.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int x, n, resta=0;

            if (int.TryParse(txtNum1.Text, out x) && (int.TryParse(txtNum2.Text, out n)))
            {
                resta = x - n;
                lblRestar.Text = resta.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }      
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int x=0, n=0, multi=0;

            if (int.TryParse(txtNum1.Text, out x) && (int.TryParse(txtNum2.Text, out n)))
            {
                multi = x * n;
                lblMulti.Text = multi.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        { 
            double x, n, div;

            if (double.TryParse(txtNum1.Text, out x) && (double.TryParse(txtNum2.Text, out n)))
            {
                try
                {
                    div = x / n;
                    lblDividir.Text = div.ToString("N2");
                }
                catch (DivideByZeroException) 
                {
                    MessageBox.Show("El 0 no se puede dividir");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            int x = 0, n = 0, potencia = 0;

            if (int.TryParse(txtNum1.Text, out x) && (int.TryParse(txtNum2.Text, out n)))
            {
                potencia = (int)Math.Pow(x, n);
                lblPotencia.Text = potencia.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
            if (n == 0)
            {
                potencia = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, n, raiz1, raiz2;

            if (double.TryParse(txtNum1.Text, out x) && (double.TryParse(txtNum2.Text, out n)))
            {
                raiz1 = Math.Sqrt(x);
                lblRaiz.Text = raiz1.ToString("N2");
                raiz2 = Math.Sqrt(n);
                lblRaiz2.Text = raiz2.ToString("N2");
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
    }
}
