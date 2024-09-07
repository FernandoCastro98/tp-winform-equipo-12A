using System;
using System.Collections;
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

namespace TPWinForm_EquipoX12A
{
    public partial class BusquedaArticulo : Form
    {
        public BusquedaArticulo()
        {
            InitializeComponent();

        }

        private bool updatingGrid = false;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                string codigo = txbCodigo.Text;
                string nombre = txbNombre.Text;

                Articulo articulo = new Articulo();
                articulo.Codigo = codigo;
                articulo.Nombre = nombre;

                List<Articulo> lista = articuloNegocio.buscarArticulo(articulo);
                dgvBusqueda.DataSource = lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void txbCodigo_Click(object sender, EventArgs e)
        {
            txbNombre.Enabled = false;  
        }

        private void txbNombre_Click(object sender, EventArgs e)
        {
            txbCodigo.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCodigo.Enabled = true;
            txbNombre.Enabled = true;
            dgvBusqueda.DataSource = new List<Articulo>();
        }
    }
}
