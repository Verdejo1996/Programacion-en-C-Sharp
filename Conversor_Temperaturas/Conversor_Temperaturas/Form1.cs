using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Temperaturas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTemperatura.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });
            cmbEF.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string escalaInicial = cmbTemperatura.SelectedItem.ToString();
            string escalaFinal = cmbEF.SelectedItem.ToString();
            double tempInicial = 0;
            double cel, far, kel, ran;

            if (double.TryParse(txtEscalaIn.Text, out tempInicial))
            {
                if (escalaInicial == "Celsius")
                {
                    if (escalaFinal == "Fahrenheit")
                    {
                        far = (tempInicial * 9 / 5) + 32;
                        txtResultado.Text = far.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if (escalaFinal == "Kelvin")
                    {
                        kel = tempInicial + 273.15;
                        txtResultado.Text = kel.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if (escalaFinal == "Rankine")
                    {
                        ran = (tempInicial + 273.15) * 9 / 5;
                        txtResultado.Text = ran.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                }
                else if (escalaInicial == "Fahrenheit")
                {
                    if (escalaFinal == "Celsius")
                    {
                        cel = (tempInicial - 32) * 5 / 9;
                        txtResultado.Text = cel.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if (escalaFinal == "Kelvin")
                    {
                        kel = (tempInicial - 32) * 5 / 9 + 273.15;
                        txtResultado.Text = kel.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if (escalaFinal == "Rankine")
                    {
                        ran = tempInicial + 459.67;
                        txtResultado.Text = ran.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                }
                else if(escalaInicial == "Kelvin")
                {
                    if (escalaFinal == "Celsius")
                    {
                        cel = tempInicial - 273.15;
                        txtResultado.Text = cel.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if (escalaFinal == "Fahrenheit")
                    {
                        far = (tempInicial - 273.15) * 9 / 5 + 32;
                        txtResultado.Text = far.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if(escalaFinal == "Rankine")
                    {
                        ran = tempInicial * 9 / 5;
                        txtResultado.Text = ran.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                }
                else if(escalaInicial == "Rankine")
                {
                    if(escalaFinal == "Celsius")
                    {
                        cel = (tempInicial - 491.67) * 5 / 9;
                        txtResultado.Text = cel.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if(escalaFinal == "Fahrenheit")
                    {
                        far = tempInicial - 459.67;
                        txtResultado.Text = far.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                    else if(escalaFinal == "Kelvin")
                    {
                        kel = (tempInicial - 491.67) * 5 / 9 + 273.15;
                        txtResultado.Text = kel.ToString("0.00");
                        dtgTemperaturas.Rows.Add(txtEscalaIn.Text, cmbTemperatura.SelectedItem.ToString(), cmbEF.SelectedItem.ToString(), txtResultado.Text);
                    }
                }
            }           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEscalaIn.Clear();
            txtResultado.Clear();
        }
    }
}
