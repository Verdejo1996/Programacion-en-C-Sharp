using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GestorLibros
    {

        public List<Libro> LeerLibros(string archivo)
        {
            List<Libro> libroLista = new List<Libro>();

            using (FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    string[] datos;
                    string linea = sw.ReadLine();

                    while (linea != null)
                    {
                        datos = linea.Split(',');

                        Libro preguntaleida = new Libro();
                        preguntaleida.titulo = datos[0];
                        preguntaleida.autor = datos[1];

                        libroLista.Add(preguntaleida);
                        linea = sw.ReadLine();

                        
                    }
                }
                fs.Close();
            }
            return libroLista;
        }
    }
}
