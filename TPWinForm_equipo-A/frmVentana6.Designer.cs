namespace TPWinForm_equipo_A
{
    partial class frmVentana6
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
            this.dgvDetalleArticulo = new System.Windows.Forms.DataGridView();
            this.lblDetalleDelArticulo = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleArticulo
            // 
            this.dgvDetalleArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulo.Location = new System.Drawing.Point(21, 199);
            this.dgvDetalleArticulo.Name = "dgvDetalleArticulo";
            this.dgvDetalleArticulo.Size = new System.Drawing.Size(909, 550);
            this.dgvDetalleArticulo.TabIndex = 0;
            this.dgvDetalleArticulo.SelectionChanged += new System.EventHandler(this.dgvDetalleArticulo_SelectionChanged);
            // 
            // lblDetalleDelArticulo
            // 
            this.lblDetalleDelArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetalleDelArticulo.AutoSize = true;
            this.lblDetalleDelArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDelArticulo.Location = new System.Drawing.Point(715, 89);
            this.lblDetalleDelArticulo.Name = "lblDetalleDelArticulo";
            this.lblDetalleDelArticulo.Size = new System.Drawing.Size(215, 29);
            this.lblDetalleDelArticulo.TabIndex = 1;
            this.lblDetalleDelArticulo.Text = "Detalle del Articulo";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagen.Location = new System.Drawing.Point(964, 199);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(639, 550);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 4;
            this.pbxImagen.TabStop = false;
            // 
            // frmVentana6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 894);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblDetalleDelArticulo);
            this.Controls.Add(this.dgvDetalleArticulo);
            this.MaximumSize = new System.Drawing.Size(1644, 933);
            this.Name = "frmVentana6";
            this.Text = "Ver detalle de un artículo";
            this.Load += new System.EventHandler(this.frmVentana6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleArticulo;
        private System.Windows.Forms.Label lblDetalleDelArticulo;
        private System.Windows.Forms.PictureBox pbxImagen;
    }
}