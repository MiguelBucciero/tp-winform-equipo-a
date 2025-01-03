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
    public partial class frmVentana2 : Form
    {
        private Articulo nuevo;
        public frmVentana2(Articulo nuevo)
        {
            InitializeComponent();
            this.nuevo = nuevo;
        }

        private void frmVentana2_Load(object sender, EventArgs e)
        {
            nuevo.Imagen.Url = txtUrl.Text;
            cargarImagen(nuevo.Imagen.Url);
        }
        private void btnAgregarOtraImagen_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Imagen imagen = new Imagen();
                imagen.Url = txtUrl.Text;
                imagen.IdArticulo = nuevo.Imagen.IdArticulo;
                negocio.agregarImagen(imagen);
                MessageBox.Show("Imagen agregada exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            {
                try
                {
                    pbxImagenUrl.Load(imagen);
                }
                catch (Exception ex)
                {
                    pbxImagenUrl.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
                }
            }

        }
        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            nuevo.Imagen.Url = txtUrl.Text;
            cargarImagen(nuevo.Imagen.Url);
        }
    }
}
