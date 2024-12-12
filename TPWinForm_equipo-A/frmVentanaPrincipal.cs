using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnBusquedaArticulos_Click(object sender, EventArgs e)
        {
            frmVentana2 ventana2 = new frmVentana2();
            ventana2.ShowDialog();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmVentana3 ventana3 = new frmVentana3();
            ventana3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVentana4 ventana4 = new frmVentana4();
            ventana4.ShowDialog();
        }

        private void btnEliminarArticulos_Click(object sender, EventArgs e)
        {
            frmVentana5 ventana5 = new frmVentana5();
            ventana5.ShowDialog();
        }

        private void btnVerDetalleArticulo_Click(object sender, EventArgs e)
        {
            frmVentana6 ventana6 = new frmVentana6();
            ventana6.ShowDialog();
        }

        private void listaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana1 ventana = new frmVentana1();
            ventana.ShowDialog();
        }

        private void búsquedaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana2 ventana2 = new frmVentana2();
            ventana2.ShowDialog();
        }

        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana3 ventana3 = new frmVentana3();
            ventana3.ShowDialog();
        }

        private void modificarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana4 ventana4 = new frmVentana4();
            ventana4.ShowDialog();
        }

        private void elminarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana5 ventana5 = new frmVentana5();
            ventana5.ShowDialog();
        }

        private void verDetallaDeUnArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentana6 ventana6 = new frmVentana6();
            ventana6.ShowDialog();
        }
    }
}
