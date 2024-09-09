namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnMostrarDB = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMostrarMarca = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMostrarDescripcion = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMostrarDB,
            this.tsbtnMostrarMarca,
            this.tsbtnMostrarDescripcion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            
            // 
            // tsbtnMostrarDB
            // 
            this.tsbtnMostrarDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMostrarDB.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMostrarDB.Image")));
            this.tsbtnMostrarDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMostrarDB.Name = "tsbtnMostrarDB";
            this.tsbtnMostrarDB.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMostrarDB.Text = "MostrarVentana";
            this.tsbtnMostrarDB.Click += new System.EventHandler(this.tsbtnMostrarDB_Click);
            // 
            // tsbtnMostrarMarca
            // 
            this.tsbtnMostrarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMostrarMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMostrarMarca.Image")));
            this.tsbtnMostrarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMostrarMarca.Name = "tsbtnMostrarMarca";
            this.tsbtnMostrarMarca.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMostrarMarca.Text = "MostrarMarca";
            this.tsbtnMostrarMarca.Click += new System.EventHandler(this.tsbtnMostrarMarca_Click);
            // 
            // tsbtnMostrarDescripcion
            // 
            this.tsbtnMostrarDescripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMostrarDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMostrarDescripcion.Image")));
            this.tsbtnMostrarDescripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMostrarDescripcion.Name = "tsbtnMostrarDescripcion";
            this.tsbtnMostrarDescripcion.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMostrarDescripcion.Text = "MostrarDescripcion";
            this.tsbtnMostrarDescripcion.Click += new System.EventHandler(this.tsbtnMostrarDescripcion_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVentanaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnMostrarDB;
        private System.Windows.Forms.ToolStripButton tsbtnMostrarMarca;
        private System.Windows.Forms.ToolStripButton tsbtnMostrarDescripcion;
    }
}