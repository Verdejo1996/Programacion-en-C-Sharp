using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP2_ProgramacionII
{
    public partial class Form1 : Form
    {
        ListaJugadores jugadores;

        public Form1()
        {
            InitializeComponent();
            jugadores = new ListaJugadores();
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                dtgJugadores.DataSource = jugadores.CargaJugadores(openFileDialog.FileName.ToString());

            }
        }

        private void dtgJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgJugadores.Rows[e.RowIndex];

                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtEdad.Text = row.Cells["Edad"].Value.ToString();
                txtPosicion.Text = row.Cells["Posicion"].Value.ToString();
                txtEquipo.Text = row.Cells["Equipo"].Value.ToString();
                txtPase.Text = row.Cells["Pase"].Value.ToString();
                txtRegate.Text = row.Cells["Regate"].Value.ToString();
                txtDefensa.Text = row.Cells["Defensa"].Value.ToString();
                txtAtaque.Text = row.Cells["Ataque"].Value.ToString();
                txtDisparo.Text = row.Cells["Disparo"].Value.ToString();

                string imagen = Path.Combine(Application.StartupPath, "Tarjetas fifa\\" + row.Cells["Nombre"].Value.ToString() + ".jpg");
                pbJugador.Image = Image.FromFile(imagen);
            }
        }

        private void dtgJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
