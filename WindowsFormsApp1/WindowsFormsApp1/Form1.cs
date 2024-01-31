using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GestorLibros gestor = new GestorLibros();

        string archivoLibro = "LibrosPorComas.txt";
        public Form1()
        {
            InitializeComponent();
            this.listBox1.DataSource = gestor.LeerLibros(archivoLibro);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Contar();
        }

        public void Contar()
        {
            List<Libro> libros = gestor.LeerLibros(archivoLibro);

            var librosPorAutor = libros.GroupBy(libro => libro.autor)
                                .Select(grupo => new {Autor = grupo.Key, CantidadLibros = grupo.Count()})
                                .ToList();

            foreach(var libro in librosPorAutor)
            {
                string texto = $"{libro.Autor}: {libro.CantidadLibros} libros";
                listBox2.Items.Add(texto);
            }
        }

    }
}
