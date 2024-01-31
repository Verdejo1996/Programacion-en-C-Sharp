using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContarLibrosPorAutor
{
    public partial class Form1 : Form
    {
        Gestor gestor = new Gestor();
        string archivo = "LibrosPorComas.txt";

        public Form1()
        {
            InitializeComponent();
            lbLibros.DataSource = gestor.LeerLibros(archivo);

            
            //lbAutores.DataSource = gestor.Contar(gestor.LeerLibros(archivo));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContarAutores();
        }

        public void ContarAutores()
        {
            List<Libro> listaLibros = gestor.LeerLibros(archivo);
            //List<Libro> autores = gestor.LeerLibros(archivo);
            //List<Autor> autoresContados = new List<Autor>();

            var autoresContados = listaLibros.GroupBy(libros => libros.autor)
                .Select(grupo => new { Autor = grupo.Key, Cantidad = grupo.Count() }).ToList();

            foreach (var l in autoresContados)
            {
                string texto = $"{l.Autor} : {l.Cantidad} libros";
                lbAutores.Items.Add(texto);
            }
            
/*            for (int i = 0; i < autoresC.Count(); i++)
            {
                Autor a = new Autor();
                a.nombre = libros[i].autor;
                //a.cantidad = libros[i].cantidad;

                //int contador = 0;
                autoresContados.Add(a);

                for (int j = 0; j < autores.Count; j++)
                {
                    if (autoresContados[i].nombre == libros[j].autor)
                    {
                        //contador++;
                        a.cantidad++;

                    }
                    
                }
*//*                string texto = $"Autor: {a.nombre} : {a.cantidad} libros";
                lbAutores.Items.Add(texto);*//*
            }*/
            //lbAutores.DataSource = autoresContados;
            

/*            foreach(Libro libro in autores)
            {
                for(int i = 0;i < autores.Count;i++)
                {
                    if()
                }
                string texto = $"Autor: {libro.autor} : {libro.cantidad}";
                lbAutores.Items.Add(texto);
            }*/

/*            var librosPorAutor = libros.GroupBy(libro => libro.autor)
                .Select(grupo => new { Autor = grupo.Key, CantidadLibros = grupo.Count() }).ToList();

            foreach (var libro in librosPorAutor)
            {
                string texto = $"{libro.Autor} : {libro.CantidadLibros} libros";
                lbAutores.Items.Add(texto);
            }*/


            //lbAutores.DataSource = librosPorAutor;


        }
    }
}
