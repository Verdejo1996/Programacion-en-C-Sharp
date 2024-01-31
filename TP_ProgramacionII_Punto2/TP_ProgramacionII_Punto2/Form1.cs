using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_ProgramacionII_Punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n, x, suma;

            if(int.TryParse(txtN1.Text, out n) && (int.TryParse(txtN2.Text, out x)))
            {
                suma = n + x;
                lblSuma.Text = suma.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }
        }
    }
}
