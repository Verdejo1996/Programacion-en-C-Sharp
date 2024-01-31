using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_ProgramacionII_Punto3
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Calcula la suma de los números ingresados
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }

            // Muestra la suma en el Label
            lblSuma.Text = suma.ToString();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string input = txtNum.Text.Trim();
            int numero;

            if (int.TryParse(input, out numero))
            {
                // Agrega el número a la lista
                numeros.Add(numero);

                // Actualiza el TextBox con los números ingresados
                txtIngresos.Text = string.Join(", ", numeros);

                // Limpia el TextBox de entrada para el próximo número
                txtNum.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
