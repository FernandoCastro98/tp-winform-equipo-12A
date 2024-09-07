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
        public List<Articulo> Articulos;
        public BusquedaArticulo()
        {
            InitializeComponent();

        }
        public bool ButtonPresionado { get; private set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ButtonPresionado = true;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                string codigo = txbCodigo.Text;
                string nombre = txbNombre.Text;

                Articulo articulo = new Articulo();
                articulo.Codigo = codigo;
                articulo.Nombre = nombre;

                Articulos = articuloNegocio.buscarArticulo(articulo);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.Close();
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
        }

        private void BusquedaArticulo_Load(object sender, EventArgs e)
        {

        }
    }
}
