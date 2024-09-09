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
        private VentanaDB ventanaDB = new VentanaDB();
        private frmVentanaMarca ventanaMarca = new frmVentanaMarca();
        private frmVertanaDescripcion ventanaDesc = new frmVertanaDescripcion();

        private void tsbtnMostrarDB_Click(object sender, EventArgs e)
        {

            
            foreach (var item in Application.OpenForms) 
            { 
                if (item.GetType() == typeof(VentanaDB))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
            }
            ventanaMarca.Close();
            ventanaDesc.Close();
            ventanaDB.MdiParent = this;                  
            ventanaDB.Show();
            

        }

        

        private void tsbtnMostrarMarca_Click(object sender, EventArgs e)
        {
            
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVentanaMarca))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
            }
            ventanaDB.Close();
            ventanaDesc.Close();
            ventanaMarca.MdiParent = this;
            ventanaMarca.Show();
            
        }

        private void tsbtnMostrarDescripcion_Click(object sender, EventArgs e)
        {
            
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmVertanaDescripcion))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return;
                }
            }
            ventanaDB.Close();
            ventanaMarca.Close();
            ventanaDesc.MdiParent = this;
            ventanaDesc.Show();
            
        }
        
    }
}
