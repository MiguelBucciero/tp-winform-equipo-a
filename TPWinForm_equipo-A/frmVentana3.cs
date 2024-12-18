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
    public partial class frmVentana3 : Form
    {
        public frmVentana3()
        {
            InitializeComponent();
        }

        private void frmVentana3_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarcaDelProducto.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                art.CodigoArticulo = txtCodigoDeProducto.Text; 
                art.Nombre = txtNombreDelProducto.Text;
                art.Descripcion = txtDescripcionDelProducto.Text;
                art.Marca = (Marca)cboMarcaDelProducto.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                if (decimal.TryParse(txtPrecio.Text, out decimal precio)) 
                { art.Precio = precio; 
                } 
                else 
                { 
                    MessageBox.Show("Por favor, ingrese un precio válido."); return; 
                }

                negocio.agregar(art);
                MessageBox.Show("Agregado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
