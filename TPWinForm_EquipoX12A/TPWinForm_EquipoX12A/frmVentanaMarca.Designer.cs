namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaMarca
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
            this.pnlFondoBusqueda = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbNombreBuscar = new System.Windows.Forms.TextBox();
            this.txbCodigoBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.lblCodigoBusqueda = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnConfirmarBusqueda = new System.Windows.Forms.Button();
            this.btnUrlCheck = new System.Windows.Forms.Button();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pbxUrlImagen = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbIngresarNombre = new System.Windows.Forms.TextBox();
            this.lblIdCateogria = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbIngresarCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pnlFondoBusqueda.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondoBusqueda
            // 
            this.pnlFondoBusqueda.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlFondoBusqueda.Controls.Add(this.btnLimpiar);
            this.pnlFondoBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFondoBusqueda.Controls.Add(this.txbNombreBuscar);
            this.pnlFondoBusqueda.Controls.Add(this.txbCodigoBuscar);
            this.pnlFondoBusqueda.Controls.Add(this.lblNombreBusqueda);
            this.pnlFondoBusqueda.Controls.Add(this.lblCodigoBusqueda);
            this.pnlFondoBusqueda.Location = new System.Drawing.Point(678, 236);
            this.pnlFondoBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFondoBusqueda.Name = "pnlFondoBusqueda";
            this.pnlFondoBusqueda.Size = new System.Drawing.Size(112, 178);
            this.pnlFondoBusqueda.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(19, 136);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 24);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(19, 108);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbNombreBuscar
            // 
            this.txbNombreBuscar.Location = new System.Drawing.Point(18, 76);
            this.txbNombreBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txbNombreBuscar.Name = "txbNombreBuscar";
            this.txbNombreBuscar.Size = new System.Drawing.Size(76, 20);
            this.txbNombreBuscar.TabIndex = 3;
            // 
            // txbCodigoBuscar
            // 
            this.txbCodigoBuscar.Location = new System.Drawing.Point(18, 33);
            this.txbCodigoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txbCodigoBuscar.Name = "txbCodigoBuscar";
            this.txbCodigoBuscar.Size = new System.Drawing.Size(76, 20);
            this.txbCodigoBuscar.TabIndex = 2;
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(32, 59);
            this.lblNombreBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBusqueda.TabIndex = 1;
            this.lblNombreBusqueda.Text = "Nombre:";
            // 
            // lblCodigoBusqueda
            // 
            this.lblCodigoBusqueda.AutoSize = true;
            this.lblCodigoBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigoBusqueda.Location = new System.Drawing.Point(34, 15);
            this.lblCodigoBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoBusqueda.Name = "lblCodigoBusqueda";
            this.lblCodigoBusqueda.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoBusqueda.TabIndex = 0;
            this.lblCodigoBusqueda.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(678, 170);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(678, 79);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(112, 33);
            this.btnBuscarArticulo.TabIndex = 15;
            this.btnBuscarArticulo.Text = "BUSCAR";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlFondo.Controls.Add(this.btnConfirmarBusqueda);
            this.pnlFondo.Controls.Add(this.btnUrlCheck);
            this.pnlFondo.Controls.Add(this.txbUrlImagen);
            this.pnlFondo.Controls.Add(this.lblUrl);
            this.pnlFondo.Controls.Add(this.pbxUrlImagen);
            this.pnlFondo.Controls.Add(this.textBox4);
            this.pnlFondo.Controls.Add(this.textBox3);
            this.pnlFondo.Controls.Add(this.textBox2);
            this.pnlFondo.Controls.Add(this.textBox1);
            this.pnlFondo.Controls.Add(this.txbIngresarNombre);
            this.pnlFondo.Controls.Add(this.lblIdCateogria);
            this.pnlFondo.Controls.Add(this.lblIdMarca);
            this.pnlFondo.Controls.Add(this.lblDescripcion);
            this.pnlFondo.Controls.Add(this.lblPrecio);
            this.pnlFondo.Controls.Add(this.lblNombre);
            this.pnlFondo.Controls.Add(this.txbIngresarCodigo);
            this.pnlFondo.Controls.Add(this.lblCodigo);
            this.pnlFondo.Location = new System.Drawing.Point(212, 236);
            this.pnlFondo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(453, 178);
            this.pnlFondo.TabIndex = 14;
            // 
            // btnConfirmarBusqueda
            // 
            this.btnConfirmarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarBusqueda.Location = new System.Drawing.Point(385, 124);
            this.btnConfirmarBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarBusqueda.Name = "btnConfirmarBusqueda";
            this.btnConfirmarBusqueda.Size = new System.Drawing.Size(56, 36);
            this.btnConfirmarBusqueda.TabIndex = 16;
            this.btnConfirmarBusqueda.Text = "ACEPTAR";
            this.btnConfirmarBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnUrlCheck
            // 
            this.btnUrlCheck.Location = new System.Drawing.Point(385, 38);
            this.btnUrlCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrlCheck.Name = "btnUrlCheck";
            this.btnUrlCheck.Size = new System.Drawing.Size(56, 38);
            this.btnUrlCheck.TabIndex = 15;
            this.btnUrlCheck.Text = "URL CHECK";
            this.btnUrlCheck.UseVisualStyleBackColor = true;
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(256, 12);
            this.txbUrlImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(186, 20);
            this.txbUrlImagen.TabIndex = 14;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.BackColor = System.Drawing.Color.DarkGray;
            this.lblUrl.Location = new System.Drawing.Point(190, 15);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(61, 13);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Url Imagen:";
            // 
            // pbxUrlImagen
            // 
            this.pbxUrlImagen.Location = new System.Drawing.Point(256, 38);
            this.pbxUrlImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbxUrlImagen.Name = "pbxUrlImagen";
            this.pbxUrlImagen.Size = new System.Drawing.Size(124, 122);
            this.pbxUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrlImagen.TabIndex = 12;
            this.pbxUrlImagen.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 142);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 115);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 90);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 8;
            // 
            // txbIngresarNombre
            // 
            this.txbIngresarNombre.Location = new System.Drawing.Point(87, 36);
            this.txbIngresarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txbIngresarNombre.Name = "txbIngresarNombre";
            this.txbIngresarNombre.Size = new System.Drawing.Size(91, 20);
            this.txbIngresarNombre.TabIndex = 7;
            // 
            // lblIdCateogria
            // 
            this.lblIdCateogria.AutoSize = true;
            this.lblIdCateogria.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdCateogria.Enabled = false;
            this.lblIdCateogria.Location = new System.Drawing.Point(13, 118);
            this.lblIdCateogria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCateogria.Name = "lblIdCateogria";
            this.lblIdCateogria.Size = new System.Drawing.Size(67, 13);
            this.lblIdCateogria.TabIndex = 6;
            this.lblIdCateogria.Text = "Id Categoria:";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdMarca.Location = new System.Drawing.Point(13, 93);
            this.lblIdMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(52, 13);
            this.lblIdMarca.TabIndex = 5;
            this.lblIdMarca.Text = "Id Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.DarkGray;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 66);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblPrecio.Location = new System.Drawing.Point(13, 145);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombre.Location = new System.Drawing.Point(13, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbIngresarCodigo
            // 
            this.txbIngresarCodigo.Location = new System.Drawing.Point(87, 12);
            this.txbIngresarCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txbIngresarCodigo.Name = "txbIngresarCodigo";
            this.txbIngresarCodigo.Size = new System.Drawing.Size(91, 20);
            this.txbIngresarCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigo.Location = new System.Drawing.Point(13, 15);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(678, 124);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarArticulo.TabIndex = 13;
            this.btnAgregarArticulo.Text = "AGREGAR";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(678, 36);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(112, 32);
            this.btnMostrarTodo.TabIndex = 12;
            this.btnMostrarTodo.Text = "MOSTRAR";
            this.btnMostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(13, 236);
            this.pbxProducto.Margin = new System.Windows.Forms.Padding(2);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(187, 178);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 11;
            this.pbxProducto.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 36);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(656, 168);
            this.dgvArticulos.TabIndex = 10;
            // 
            // frmVentanaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFondoBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmVentanaMarca";
            this.Text = "Ventana de Marcas";
            this.pnlFondoBusqueda.ResumeLayout(false);
            this.pnlFondoBusqueda.PerformLayout();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondoBusqueda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNombreBuscar;
        private System.Windows.Forms.TextBox txbCodigoBuscar;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.Label lblCodigoBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Button btnConfirmarBusqueda;
        private System.Windows.Forms.Button btnUrlCheck;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.PictureBox pbxUrlImagen;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbIngresarNombre;
        private System.Windows.Forms.Label lblIdCateogria;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbIngresarCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}