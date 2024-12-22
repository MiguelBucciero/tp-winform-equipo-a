using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace TPWinForm_equipo_A
{
    public partial class frmVentana3 : Form
    {
        private Articulo nuevo = null;
        private OpenFileDialog archivo = null;
        public frmVentana3()
        {
            InitializeComponent();
        }
        public frmVentana3(Articulo nuevo)
        {
            InitializeComponent();
            this.nuevo = nuevo;
            Text = "Modificar Artículo";
        }

        private void frmVentana3_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarcaDelProducto.DataSource = marcaNegocio.listar();
                cboMarcaDelProducto.ValueMember = "Id";
                cboMarcaDelProducto.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if (nuevo != null)
                {
                    txtCodigoDeProducto.Text = nuevo.CodigoArticulo;
                    txtNombreDelProducto.Text = nuevo.Nombre;
                    txtDescripcionDelProducto.Text = nuevo.Descripcion;
                    txtPrecio.Text = nuevo.Precio.ToString();
                    txtUrlImagen.Text = nuevo.Imagen.Url;
                    cargarImagen(nuevo.Imagen.Url);
                    cboMarcaDelProducto.SelectedValue = nuevo.Marca.Descripcion;
                    cboCategoria.SelectedValue = nuevo.Categoria.Descripcion;
                }
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
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(nuevo == null)
                    nuevo = new Articulo();
                nuevo.CodigoArticulo = txtCodigoDeProducto.Text;
                nuevo.Nombre = txtNombreDelProducto.Text;
                nuevo.Descripcion = txtDescripcionDelProducto.Text;
                nuevo.Marca = (Marca)cboMarcaDelProducto.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;
                if (decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    nuevo.Precio = precio;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return;
                }
                if (nuevo.Id != 0)
                {
                    negocio.modificar(nuevo);
                    int id = nuevo.Id;
                    Imagen img = new Imagen();
                    img.Url = txtUrlImagen.Text;
                    img.IdArticulo = id;
                    negocio.modificarImagen(img);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(nuevo);
                    int id = negocio.ultimoRegistro(nuevo);
                    Imagen img = new Imagen();
                    img.Url = txtUrlImagen.Text;
                    img.IdArticulo = id;
                    negocio.agregarImagen(img);
                    MessageBox.Show("Agregado exitosamente.");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            {try
                {
                    pbxImagen.Load(imagen);
                }
                catch (Exception ex)
                {
                    pbxImagen.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
                }
            }

        }

        private void txtUrlImagen_TextChanged_1(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnAgregarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "JPG|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagen"] + archivo.SafeFileName);
            }
        }

    }
}
