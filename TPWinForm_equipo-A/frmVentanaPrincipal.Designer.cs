namespace TPWinForm_equipo_A
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListaArticulos = new System.Windows.Forms.Button();
            this.btnBusquedaArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.btnVerDetalleArticulo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elminarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallaDeUnArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaArticulos.Location = new System.Drawing.Point(354, 261);
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.Size = new System.Drawing.Size(128, 54);
            this.btnListaArticulos.TabIndex = 0;
            this.btnListaArticulos.Text = "Listado de artículos";
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            this.btnListaArticulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBusquedaArticulos
            // 
            this.btnBusquedaArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusquedaArticulos.Location = new System.Drawing.Point(728, 261);
            this.btnBusquedaArticulos.Name = "btnBusquedaArticulos";
            this.btnBusquedaArticulos.Size = new System.Drawing.Size(132, 54);
            this.btnBusquedaArticulos.TabIndex = 1;
            this.btnBusquedaArticulos.Text = "Búsqueda de artículos";
            this.btnBusquedaArticulos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(354, 421);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(128, 58);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar artículos";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarArticulos.Location = new System.Drawing.Point(728, 421);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(132, 58);
            this.btnModificarArticulos.TabIndex = 3;
            this.btnModificarArticulos.Text = "Modificar artículos";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarArticulos.Location = new System.Drawing.Point(354, 581);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(128, 54);
            this.btnEliminarArticulos.TabIndex = 4;
            this.btnEliminarArticulos.Text = "Eliminar artículos";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalleArticulo
            // 
            this.btnVerDetalleArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerDetalleArticulo.Location = new System.Drawing.Point(728, 581);
            this.btnVerDetalleArticulo.Name = "btnVerDetalleArticulo";
            this.btnVerDetalleArticulo.Size = new System.Drawing.Size(132, 54);
            this.btnVerDetalleArticulo.TabIndex = 5;
            this.btnVerDetalleArticulo.Text = "Ver detalle de un artículo";
            this.btnVerDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnVerDetalleArticulo.Click += new System.EventHandler(this.btnVerDetalleArticulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArticulosToolStripMenuItem,
            this.búsquedaDeArticulosToolStripMenuItem,
            this.agregarArtículosToolStripMenuItem,
            this.modificarArtículosToolStripMenuItem,
            this.elminarArtículosToolStripMenuItem,
            this.verDetallaDeUnArtículoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // listaDeArticulosToolStripMenuItem
            // 
            this.listaDeArticulosToolStripMenuItem.Name = "listaDeArticulosToolStripMenuItem";
            this.listaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.listaDeArticulosToolStripMenuItem.Text = "Lista de Artículos";
            this.listaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.listaDeArticulosToolStripMenuItem_Click);
            // 
            // búsquedaDeArticulosToolStripMenuItem
            // 
            this.búsquedaDeArticulosToolStripMenuItem.Name = "búsquedaDeArticulosToolStripMenuItem";
            this.búsquedaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.búsquedaDeArticulosToolStripMenuItem.Text = "Búsqueda de Artículos";
            // 
            // agregarArtículosToolStripMenuItem
            // 
            this.agregarArtículosToolStripMenuItem.Name = "agregarArtículosToolStripMenuItem";
            this.agregarArtículosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.agregarArtículosToolStripMenuItem.Text = "Agregar Artículos";
            this.agregarArtículosToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículosToolStripMenuItem_Click);
            // 
            // modificarArtículosToolStripMenuItem
            // 
            this.modificarArtículosToolStripMenuItem.Name = "modificarArtículosToolStripMenuItem";
            this.modificarArtículosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.modificarArtículosToolStripMenuItem.Text = "Modificar Artículos";
            // 
            // elminarArtículosToolStripMenuItem
            // 
            this.elminarArtículosToolStripMenuItem.Name = "elminarArtículosToolStripMenuItem";
            this.elminarArtículosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.elminarArtículosToolStripMenuItem.Text = "Elminar Artículos";
            // 
            // verDetallaDeUnArtículoToolStripMenuItem
            // 
            this.verDetallaDeUnArtículoToolStripMenuItem.Name = "verDetallaDeUnArtículoToolStripMenuItem";
            this.verDetallaDeUnArtículoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.verDetallaDeUnArtículoToolStripMenuItem.Text = "Ver detalla de un Artículo";
            this.verDetallaDeUnArtículoToolStripMenuItem.Click += new System.EventHandler(this.verDetallaDeUnArtículoToolStripMenuItem_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1252, 952);
            this.Controls.Add(this.btnVerDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnBusquedaArticulos);
            this.Controls.Add(this.btnListaArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1268, 991);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaArticulos;
        private System.Windows.Forms.Button btnBusquedaArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnEliminarArticulos;
        private System.Windows.Forms.Button btnVerDetalleArticulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elminarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetallaDeUnArtículoToolStripMenuItem;
    }
}

