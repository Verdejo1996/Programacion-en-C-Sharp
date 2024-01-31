using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Parcial
{
    public partial class Form1 : Form
    {
        List<Prenda> prendaList = new List<Prenda>();
        Stack<Prenda> maniqui = new Stack<Prenda>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Prenda p1 = new Prenda("Sombrero");
            prendaList.Add(p1);
            Prenda p2 = new Prenda("Remera");
            prendaList.Add(p2);
            Prenda p3 = new Prenda("Buzo");
            prendaList.Add(p3);
            Prenda p4 = new Prenda("Pantalon");
            prendaList.Add(p4);
            Prenda p5 = new Prenda("Zapatillas");
            prendaList.Add(p5);
            Prenda p6 = new Prenda("Boxer");
            prendaList.Add(p6);

            foreach (Prenda prenda in prendaList)
            {
                lbRopero.Items.Add(prenda);
            }
        }

        private void btnVestir_Click(object sender, EventArgs e)
        {
            if (lbRopero.SelectedItems.Count > 0)
            {
                Prenda prendas = new Prenda();
                prendas.nombrePrenda = lbRopero.SelectedItem.ToString();
                maniqui.Push(prendas);
                lbManiqui.DataSource = maniqui.ToList();
                lbRopero.Items.Remove(lbRopero.SelectedItem);           
            }
            else
            {
                MessageBox.Show("No hay mas prendas en el ropero");
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
  
            if (lbManiqui.SelectedItems.Count != 0)
            {
                lbRopero.Items.Add(maniqui.Pop());
                lbManiqui.DataSource = maniqui.ToList();   
            }
            else
            {
                MessageBox.Show("No hay prendas que quitar.");
            }
        }
    }
}
