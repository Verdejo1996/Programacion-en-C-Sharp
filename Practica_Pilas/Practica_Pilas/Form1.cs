using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Pilas
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibros = new List<Libro>();
        Stack<Libro> stackLibros = new Stack<Libro>();
        Stack<Libro> stackPedidos = new Stack<Libro>();
        Stack<Libro> stackEspera = new Stack<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Libro l1 = new Libro("Padre rico, Padre pobre", "Robert Kiyosaki");
            listaLibros.Add(l1);
            Libro l2 = new Libro("Ready Player One", "Ernest Cline");
            listaLibros.Add(l2);
            Libro l3 = new Libro("Cien anios de Soledad", "Gabriel Garcia Marquez");
            listaLibros.Add(l3);
            Libro l4 = new Libro("1984", "George Orwell");
            listaLibros.Add(l4);
            Libro l5 = new Libro("El senior de los anillos", "J.R.R. Tolien");
            listaLibros.Add(l5);
            Libro l6 = new Libro("Orgullo y prejuicio", "Jane Austen");
            listaLibros.Add(l6);
            Libro l7 = new Libro("Haryy Potter y la piedra filosofal", "J.K. Rowling");
            listaLibros.Add(l7);

            foreach(Libro l in listaLibros)
            {
                lbLibros.Items.Add(l.ToString());
            }
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            if(lbLibros.SelectedItems.Count > 0)
            {
                Libro librosParaStack = new Libro();
                librosParaStack.titulo = lbLibros.SelectedItem.ToString();
                stackLibros.Push(librosParaStack);
                lbAlquilados.DataSource = stackLibros.ToList();
                lbLibros.Items.Remove(lbLibros.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay mas libros para alquilar");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if(lbAlquilados.SelectedItems.Count > 0)
            {
                lbLibros.Items.Add(stackLibros.Pop());
                lbAlquilados.DataSource = stackLibros.ToList();
                
            }
            else
            {
                MessageBox.Show("No hay libros alquilados");
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            if(lbLibros.SelectedItems.Count > 0)
            {
                Libro libroParaStack = new Libro();
                libroParaStack.titulo=lbLibros.SelectedItem.ToString();
                stackPedidos.Push(libroParaStack);
                lbPedidos.DataSource = stackPedidos.ToList();
                lbLibros.Items.Remove(lbLibros.SelectedItem) ;
            }
            else
            {
                MessageBox.Show("No hay libros para pedir");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(lbLibros.SelectedItems.Count > 0)
            {
                Libro libroPara = new Libro();
                libroPara.titulo = lbLibros.SelectedItem.ToString();
                stackEspera.Push(libroPara);
                lbEnEspera.DataSource = stackEspera.ToList();
                lbLibros.Items.Remove(lbLibros.SelectedItem.ToString()) ;
            }
            else
            {
                MessageBox.Show("No hay mas libros en lista de espera");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lbPedidos.SelectedItems.Count > 0)
            {
                lbLibros.Items.Add(lbPedidos.SelectedItem.ToString());
                stackPedidos.Pop();
                lbPedidos.DataSource= stackPedidos.ToList();
            }
        }
    }
}
