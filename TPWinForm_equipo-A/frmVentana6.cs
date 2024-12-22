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
using negocio;

namespace TPWinForm_equipo_A
{
    public partial class frmVentana6 : Form
    {
        private List<Articulo> listaArticulos;
        public frmVentana6()
        {
            InitializeComponent();
        }

        private void frmVentana6_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvDetalleArticulo.DataSource = listaArticulos;
                dgvDetalleArticulo.Columns["Imagen"].Visible = false;
                cargarImagen(listaArticulos[0].Imagen.Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
            }
        }

        private void dgvDetalleArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetalleArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvDetalleArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen.Url);
            }
        }
    }
}
