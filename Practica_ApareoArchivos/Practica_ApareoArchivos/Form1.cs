using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_ApareoArchivos
{
    public partial class Form1 : Form
    {
        Gestor gestor = new Gestor();

        List<Autor> autores = new List<Autor>();

        Autor autor = new Autor();

        string archivoAutores = "Autores.txt";
        string archivoLibros = "Libros.txt";

        public int indiceAutores;

        public Form1()
        {
            InitializeComponent();
            indiceAutores = 0;
            autores = gestor.LeerAutores(archivoAutores);
            autor = autores[indiceAutores];
            autor.Libros = gestor.Libros(archivoLibros, autor);


            CargarPrograma(autor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarPrograma(Autor autor)
        {

            lblAutor.Text = autores[indiceAutores].ToString();

            List<string> lista = new List<string>
            {
                autor.Libros[0].libro,
                autor.Libros[1].libro1

            };

            lbLibros.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indiceAutores++;

            if(indiceAutores == 5)
            {
                MessageBox.Show("No hay mas autores");
                this.Close();
            }
            else
            {
                autor = autores[indiceAutores];
                autor.Libros = gestor.Libros(archivoLibros, autor);
                CargarPrograma(autor);

            }
        }
    }
}
