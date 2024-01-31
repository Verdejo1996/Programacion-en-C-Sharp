using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_ProgramacionII_Punto1
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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int n, x, suma;

            if(int.TryParse(txtPrimerN.Text, out n) && (int.TryParse(txtSegN.Text, out x))  )
            {
                suma = n + x;
                MessageBox.Show("La suma es " + suma);
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }

                

            

            




            

        }
    }
}
