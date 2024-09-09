namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaArticulo
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
            this.lblContenidoDB = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnConfirmarAgregar = new System.Windows.Forms.Button();
            this.btnUrlCheck = new System.Windows.Forms.Button();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pbxUrlImagen = new System.Windows.Forms.PictureBox();
            this.txbIngresarPrecio = new System.Windows.Forms.TextBox();
            this.txbIngresarIdCategoria = new System.Windows.Forms.TextBox();
            this.txbIngresarIdMarca = new System.Windows.Forms.TextBox();
            this.txbIngresarDescripcion = new System.Windows.Forms.TextBox();
            this.txbIngresarNombre = new System.Windows.Forms.TextBox();
            this.lblIdCateogria = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbIngresarCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlFondoBusqueda = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbNombreBuscar = new System.Windows.Forms.TextBox();
            this.txbCodigoBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.lblCodigoBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).BeginInit();
            this.pnlFondoBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContenidoDB
            // 
            this.lblContenidoDB.AutoSize = true;
            this.lblContenidoDB.Location = new System.Drawing.Point(14, 18);
            this.lblContenidoDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoDB.Name = "lblContenidoDB";
            this.lblContenidoDB.Size = new System.Drawing.Size(83, 16);
            this.lblContenidoDB.TabIndex = 0;
            this.lblContenidoDB.Text = "ARTICULOS";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(13, 64);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(874, 207);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(17, 310);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(249, 219);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 2;
            this.pbxProducto.TabStop = false;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(903, 64);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(149, 40);
            this.btnMostrarTodo.TabIndex = 3;
            this.btnMostrarTodo.Text = "MOSTRAR";
            this.btnMostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(903, 172);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(149, 43);
            this.btnAgregarArticulo.TabIndex = 4;
            this.btnAgregarArticulo.Text = "AGREGAR";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlFondo.Controls.Add(this.btnConfirmarAgregar);
            this.pnlFondo.Controls.Add(this.btnUrlCheck);
            this.pnlFondo.Controls.Add(this.txbUrlImagen);
            this.pnlFondo.Controls.Add(this.lblUrl);
            this.pnlFondo.Controls.Add(this.pbxUrlImagen);
            this.pnlFondo.Controls.Add(this.txbIngresarPrecio);
            this.pnlFondo.Controls.Add(this.txbIngresarIdCategoria);
            this.pnlFondo.Controls.Add(this.txbIngresarIdMarca);
            this.pnlFondo.Controls.Add(this.txbIngresarDescripcion);
            this.pnlFondo.Controls.Add(this.txbIngresarNombre);
            this.pnlFondo.Controls.Add(this.lblIdCateogria);
            this.pnlFondo.Controls.Add(this.lblIdMarca);
            this.pnlFondo.Controls.Add(this.lblDescripcion);
            this.pnlFondo.Controls.Add(this.lblPrecio);
            this.pnlFondo.Controls.Add(this.lblNombre);
            this.pnlFondo.Controls.Add(this.txbIngresarCodigo);
            this.pnlFondo.Controls.Add(this.lblCodigo);
            this.pnlFondo.Location = new System.Drawing.Point(283, 310);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(604, 219);
            this.pnlFondo.TabIndex = 6;
            // 
            // btnConfirmarAgregar
            // 
            this.btnConfirmarAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAgregar.Location = new System.Drawing.Point(513, 153);
            this.btnConfirmarAgregar.Name = "btnConfirmarAgregar";
            this.btnConfirmarAgregar.Size = new System.Drawing.Size(75, 44);
            this.btnConfirmarAgregar.TabIndex = 16;
            this.btnConfirmarAgregar.Text = "ACEPTAR";
            this.btnConfirmarAgregar.UseVisualStyleBackColor = true;
            this.btnConfirmarAgregar.Click += new System.EventHandler(this.btnConfirmarAgregar_Click);
            // 
            // btnUrlCheck
            // 
            this.btnUrlCheck.Location = new System.Drawing.Point(513, 47);
            this.btnUrlCheck.Name = "btnUrlCheck";
            this.btnUrlCheck.Size = new System.Drawing.Size(75, 47);
            this.btnUrlCheck.TabIndex = 15;
            this.btnUrlCheck.Text = "URL CHECK";
            this.btnUrlCheck.UseVisualStyleBackColor = true;
            this.btnUrlCheck.Click += new System.EventHandler(this.btnUrlCheck_Click);
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(341, 15);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(247, 22);
            this.txbUrlImagen.TabIndex = 14;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.BackColor = System.Drawing.Color.DarkGray;
            this.lblUrl.Location = new System.Drawing.Point(254, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(75, 16);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Url Imagen:";
            // 
            // pbxUrlImagen
            // 
            this.pbxUrlImagen.Location = new System.Drawing.Point(341, 47);
            this.pbxUrlImagen.Name = "pbxUrlImagen";
            this.pbxUrlImagen.Size = new System.Drawing.Size(166, 150);
            this.pbxUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrlImagen.TabIndex = 12;
            this.pbxUrlImagen.TabStop = false;
            // 
            // txbIngresarPrecio
            // 
            this.txbIngresarPrecio.Location = new System.Drawing.Point(116, 175);
            this.txbIngresarPrecio.Name = "txbIngresarPrecio";
            this.txbIngresarPrecio.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarPrecio.TabIndex = 11;
            this.txbIngresarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIngresarPrecio_KeyPress);
            // 
            // txbIngresarIdCategoria
            // 
            this.txbIngresarIdCategoria.Location = new System.Drawing.Point(116, 142);
            this.txbIngresarIdCategoria.Name = "txbIngresarIdCategoria";
            this.txbIngresarIdCategoria.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarIdCategoria.TabIndex = 10;
            this.txbIngresarIdCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIngresarIdCategoria_KeyPress);
            // 
            // txbIngresarIdMarca
            // 
            this.txbIngresarIdMarca.Location = new System.Drawing.Point(116, 111);
            this.txbIngresarIdMarca.Name = "txbIngresarIdMarca";
            this.txbIngresarIdMarca.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarIdMarca.TabIndex = 9;
            this.txbIngresarIdMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIngresarIdMarca_KeyPress);
            // 
            // txbIngresarDescripcion
            // 
            this.txbIngresarDescripcion.Location = new System.Drawing.Point(116, 78);
            this.txbIngresarDescripcion.Name = "txbIngresarDescripcion";
            this.txbIngresarDescripcion.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarDescripcion.TabIndex = 8;
            // 
            // txbIngresarNombre
            // 
            this.txbIngresarNombre.Location = new System.Drawing.Point(116, 44);
            this.txbIngresarNombre.Name = "txbIngresarNombre";
            this.txbIngresarNombre.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarNombre.TabIndex = 7;
            // 
            // lblIdCateogria
            // 
            this.lblIdCateogria.AutoSize = true;
            this.lblIdCateogria.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdCateogria.Enabled = false;
            this.lblIdCateogria.Location = new System.Drawing.Point(17, 145);
            this.lblIdCateogria.Name = "lblIdCateogria";
            this.lblIdCateogria.Size = new System.Drawing.Size(83, 16);
            this.lblIdCateogria.TabIndex = 6;
            this.lblIdCateogria.Text = "Id Categoria:";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdMarca.Location = new System.Drawing.Point(17, 114);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(62, 16);
            this.lblIdMarca.TabIndex = 5;
            this.lblIdMarca.Text = "Id Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.DarkGray;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblPrecio.Location = new System.Drawing.Point(17, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombre.Location = new System.Drawing.Point(17, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbIngresarCodigo
            // 
            this.txbIngresarCodigo.Location = new System.Drawing.Point(116, 15);
            this.txbIngresarCodigo.Name = "txbIngresarCodigo";
            this.txbIngresarCodigo.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigo.Location = new System.Drawing.Point(17, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(903, 117);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(149, 41);
            this.btnBuscarArticulo.TabIndex = 7;
            this.btnBuscarArticulo.Text = "BUSCAR";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(903, 228);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 43);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.pnlFondoBusqueda.Location = new System.Drawing.Point(903, 310);
            this.pnlFondoBusqueda.Name = "pnlFondoBusqueda";
            this.pnlFondoBusqueda.Size = new System.Drawing.Size(149, 219);
            this.pnlFondoBusqueda.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(25, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbNombreBuscar
            // 
            this.txbNombreBuscar.Location = new System.Drawing.Point(24, 93);
            this.txbNombreBuscar.Name = "txbNombreBuscar";
            this.txbNombreBuscar.Size = new System.Drawing.Size(100, 22);
            this.txbNombreBuscar.TabIndex = 3;
            this.txbNombreBuscar.Click += new System.EventHandler(this.txbNombreBuscar_Click);
            this.txbNombreBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNombreBuscar_KeyDown);
            // 
            // txbCodigoBuscar
            // 
            this.txbCodigoBuscar.Location = new System.Drawing.Point(24, 41);
            this.txbCodigoBuscar.Name = "txbCodigoBuscar";
            this.txbCodigoBuscar.Size = new System.Drawing.Size(100, 22);
            this.txbCodigoBuscar.TabIndex = 2;
            this.txbCodigoBuscar.Click += new System.EventHandler(this.txbCodigoBuscar_Click);
            this.txbCodigoBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCodigoBuscar_KeyDown);
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(43, 73);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(59, 16);
            this.lblNombreBusqueda.TabIndex = 1;
            this.lblNombreBusqueda.Text = "Nombre:";
            // 
            // lblCodigoBusqueda
            // 
            this.lblCodigoBusqueda.AutoSize = true;
            this.lblCodigoBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigoBusqueda.Location = new System.Drawing.Point(45, 18);
            this.lblCodigoBusqueda.Name = "lblCodigoBusqueda";
            this.lblCodigoBusqueda.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoBusqueda.TabIndex = 0;
            this.lblCodigoBusqueda.Text = "Codigo:";
            // 
            // frmVentanaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlFondoBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblContenidoDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentanaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Base de Datos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).EndInit();
            this.pnlFondoBusqueda.ResumeLayout(false);
            this.pnlFondoBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContenidoDB;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbIngresarCodigo;
        private System.Windows.Forms.Label lblIdCateogria;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbIngresarNombre;
        private System.Windows.Forms.TextBox txbIngresarPrecio;
        private System.Windows.Forms.TextBox txbIngresarIdCategoria;
        private System.Windows.Forms.TextBox txbIngresarIdMarca;
        private System.Windows.Forms.TextBox txbIngresarDescripcion;
        private System.Windows.Forms.PictureBox pbxUrlImagen;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnUrlCheck;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnConfirmarAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlFondoBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.Label lblCodigoBusqueda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNombreBuscar;
        private System.Windows.Forms.TextBox txbCodigoBuscar;
    }
}