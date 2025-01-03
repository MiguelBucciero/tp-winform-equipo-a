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
        private Articulo nuevo;
        private List<string> listaImagenes;
        public frmVentana6(Articulo nuevo)
        {
            InitializeComponent();
            this.nuevo = nuevo;
            listaImagenes = new List<string>();
        }
        private void frmVentana6_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            try
            {
                List<Articulo> listaArticulos = new List<Articulo> { nuevo };
                dgvDetalleArticulo.DataSource = listaArticulos;
                dgvDetalleArticulo.Columns["Id"].Visible = false;
                dgvDetalleArticulo.Columns["Imagen"].Visible = false;
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaImagenes = negocio.listarImagenes(nuevo).Select(x => x.Imagen.Url).ToList();
                lbxImagenes.DataSource = listaImagenes;
                cargarImagen(listaImagenes[0]);
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
        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedImageUrl = lbxImagenes.SelectedItem.ToString();
            cargarImagen(selectedImageUrl);
        }
    }
}
