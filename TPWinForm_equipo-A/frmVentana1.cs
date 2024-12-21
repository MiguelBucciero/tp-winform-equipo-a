using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_A
{
    public partial class frmVentana1 : Form
    {
        private List<Articulo> listaArticulos;
        public frmVentana1()
        {
            InitializeComponent();
        }

        private void frmVentana1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.Url);
        }  

        private void cargarImagen(string imagen) 
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                 pbImagen.Load("https://media.istockphoto.com/id/1222357475/vector/image-preview-icon-picture-placeholder-for-website-or-ui-ux-design-vector-illustration.jpg?s=612x612&w=0&k=20&c=KuCo-dRBYV7nz2gbk4J9w1WtTAgpTdznHu55W9FjimE=");
            }
            
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["CodigoArticulo"].Visible = false;
                dgvArticulos.Columns["Marca"].Visible = false;
                dgvArticulos.Columns["Categoria"].Visible = false;
                cargarImagen(listaArticulos[0].Imagen.Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmVentana3 alta = new frmVentana3();
            alta.ShowDialog();

        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            frmVentana6 detalleArticulos = new frmVentana6();
            detalleArticulos.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmVentana3 modificar = new frmVentana3(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado; 
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar el articulo?", "Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning );
                if(respuesta == DialogResult.Yes)
                {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.Id);
                cargar() ;
                  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

