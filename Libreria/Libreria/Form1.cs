using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Form1 : Form
    {
        Gestor gestor = new Gestor();
        Stack<Libro> libros = new Stack<Libro>();
        Queue<Libro> prestamos = new Queue<Libro>();
        string archivo = "Libros.csv";

        public Form1()
        {
            InitializeComponent();
            libros = gestor.CargarStackLibros(archivo);
            lbLibros.DataSource = libros.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if(lbLibros.SelectedItems.Count > 0)
            {
                lbEstante1.Items.Add(libros.Pop());
                lbLibros.DataSource = libros.ToList();
                
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            if (lbLibros.SelectedItems.Count > 0)
            {
                lbEstante2.Items.Add(libros.Pop());
                lbLibros.DataSource = libros.ToList();

            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if(lbEstante1.SelectedItems.Count > 0)
            {
                prestamos.Enqueue((Libro)lbEstante1.SelectedItem);
                lbPrestamos.DataSource = prestamos.ToList();
                lbEstante1.Items.Remove(lbEstante1.SelectedItem);
            }
        }

        private void btnPrestar2_Click(object sender, EventArgs e)
        {
            if (lbEstante2.SelectedItems.Count > 0)
            {
                prestamos.Enqueue((Libro)lbEstante2.SelectedItem);
                lbPrestamos.DataSource = prestamos.ToList();
                lbEstante2.Items.Remove(lbEstante2.SelectedItem);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if(lbPrestamos.SelectedItems.Count > 0)
            {
                libros.Push(prestamos.Dequeue());
                lbLibros.DataSource = libros.ToList();
                lbPrestamos.DataSource = prestamos.ToList();
            }
        }
    }
}
