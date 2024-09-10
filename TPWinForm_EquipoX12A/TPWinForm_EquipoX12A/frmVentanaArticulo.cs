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

namespace TPWinForm_EquipoX12A
{
    
    public partial class frmVentanaArticulo : Form
    {
        public List<Articulo> Articulos;
        public frmVentanaArticulo()
        {
            InitializeComponent();
        }

        private void VentanaDB_Load(object sender, EventArgs e)
        {
            pnlFondo.Visible = false;
            pnlFondoBusqueda.Visible = false;
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = false;
            pnlFondoBusqueda.Visible = false;
            pbxProducto.Load("https://plus.unsplash.com/premium_photo-1682310093719-443b6fe140e8?q=80&w=1824&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            ImagenNegocio imgNeg = new ImagenNegocio();
            Articulos = ArtNeg.listar();
            dgvArticulos.DataSource = Articulos;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = true;
            pnlFondoBusqueda.Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imgNeg = new ImagenNegocio();
            List<Imagen> listaImagen = imgNeg.listar();

            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                foreach (Imagen imagen in listaImagen)
                {
                    if(imagen.IdArticulo == seleccionado.Id)
                    {
                        pbxProducto.Load(imagen.UrlImagen);
                        break;
                    }
                }
                
            }
            catch (Exception)
            {
                pbxProducto.Load("https://plus.unsplash.com/premium_photo-1682310093719-443b6fe140e8?q=80&w=1824&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
            }


        }

        private void btnUrlCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string urlImagen = txbUrlImagen.Text;
                pbxUrlImagen.Load(urlImagen);
            }
            catch (Exception)
            {

                pbxUrlImagen.Load("https://plus.unsplash.com/premium_photo-1682310093719-443b6fe140e8?q=80&w=1824&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            }

        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = false;
            pnlFondoBusqueda.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Articulo articulo = new Articulo();
                articulo.Codigo = (string)txbCodigoBuscar.Text;
                articulo.Nombre = (string)txbNombreBuscar.Text;

                Articulos = articuloNegocio.buscarArticulo(articulo);
                dgvArticulos.DataSource = Articulos;
                dgvArticulos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCodigoBuscar.Enabled = true;
            txbNombreBuscar.Enabled = true;
        }

        private void txbCodigoBuscar_Click(object sender, EventArgs e)
        {
            txbNombreBuscar.Enabled = false;
        }

        private void txbNombreBuscar_Click(object sender, EventArgs e)
        {
            txbCodigoBuscar.Enabled = false;
        }

        private void txbCodigoBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar al método del botón al presionar Enter
                btnBuscar_Click(sender, e);
            }
        }

        private void txbNombreBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar al método del botón al presionar Enter
                btnBuscar_Click(sender, e);
            }
        }

     

        private void txbIngresarIdMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbIngresarIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbIngresarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirmarAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Articulo articulo = new Articulo();
                articulo.Codigo = txbIngresarCodigo.Text;
                articulo.Nombre = txbIngresarNombre.Text;
                articulo.Descripcion = txbIngresarDescripcion.Text;
                articulo.Precio = decimal.Parse(txbIngresarPrecio.Text);
                articuloNegocio.cargarArticulo(articulo);

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en el formato de los datos ingresados...", "Error");
            }

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
