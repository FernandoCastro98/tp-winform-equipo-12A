using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_EquipoX12A
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();

        }



        private void tsbtnMostrarDB_Click(object sender, EventArgs e)
        {

            VentanaDB ventanaDB = new VentanaDB();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VentanaDB))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
            }
            CerrarVentanasAbiertas();
            ventanaDB.MdiParent = this;
            ventanaDB.Show();


        }



        private void tsbtnMostrarMarca_Click(object sender, EventArgs e)
        {
            frmVentanaMarca ventanaMarca = new frmVentanaMarca();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVentanaMarca))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
            }
            CerrarVentanasAbiertas();
            ventanaMarca.MdiParent = this;
            ventanaMarca.Show();

        }

        private void tsbtnMostrarDescripcion_Click(object sender, EventArgs e)
        {
            frmVertanaDescripcion ventanaDesc = new frmVertanaDescripcion();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVertanaDescripcion))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
            }
            CerrarVentanasAbiertas();
            ventanaDesc.MdiParent = this;
            ventanaDesc.Show();

        }
        private void CerrarVentanasAbiertas()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

    }
}
