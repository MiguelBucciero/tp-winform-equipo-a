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
        public frmVentana6()
        {
            InitializeComponent();
        }

        private void frmVentana6_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            dgvDetalleArticulo.DataSource = negocio.listar();
            
        }
    }
}
