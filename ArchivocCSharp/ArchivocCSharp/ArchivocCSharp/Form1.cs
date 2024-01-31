using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivocCSharp
{
    public partial class Form1 : Form
    {

        GestorAlumnos alumnos = new GestorAlumnos();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LlenarGrilla();
        }

        private void cmdAlta_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno((long)this.numDNI.Value)
            {
               
                Apellido = this.txtApellido.Text,
                Nombre = this.txtNombre.Text
            };

            alumnos.Alta(alumno);
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = alumnos.Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                Alumno seleccionado = (Alumno)this.dataGridView1.SelectedRows[0].DataBoundItem;
                alumnos.Baja(seleccionado.DNI);
                LlenarGrilla();
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
