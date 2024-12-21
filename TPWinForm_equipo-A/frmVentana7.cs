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
    public partial class frmVentana7 : Form
    {
        public frmVentana7()
        {
            InitializeComponent();
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
        //private void btnAgregarImagen_Click(object sender, EventArgs e)
        //{
        //    Articulo nuevo = new Articulo();
        //    ArticuloNegocio negocio = new ArticuloNegocio();
        //    Imagen img = new Imagen();
        //    try
        //    {
        //        negocio.ultimoRegistro(nuevo);
        //        nuevo.Id = img.IdArticulo;
        //        img.Url = txtUrlImagen.Text;
        //        negocio.agregarImagen(img);
        //        MessageBox.Show("Imagen agregada correctamente");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }

}
