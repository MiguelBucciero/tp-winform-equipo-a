using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TPWinForm_equipo_A
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentana1 ventana = new frmVentana1();
            ventana.ShowDialog();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmVentana3 ventana3 = new frmVentana3();
            ventana3.ShowDialog();
        }
        private void listaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana1 ventana = new frmVentana1();
            ventana.ShowDialog();
        }

        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana3 ventana3 = new frmVentana3();
            ventana3.ShowDialog();
        }

        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            frmVentana3 ventana3 = new frmVentana3();
            ventana3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmVentana4 ventana = new frmVentana4();
            ventana.ShowDialog();
        }
    }
}
