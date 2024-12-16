namespace TPWinForm_equipo_A
{
    partial class frmVentana2
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
            this.lblBusquedaArticulo = new System.Windows.Forms.Label();
            this.txtBuscarElemento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblBusquedaArticulo
            // 
            this.lblBusquedaArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusquedaArticulo.AutoSize = true;
            this.lblBusquedaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaArticulo.Location = new System.Drawing.Point(216, 63);
            this.lblBusquedaArticulo.Name = "lblBusquedaArticulo";
            this.lblBusquedaArticulo.Size = new System.Drawing.Size(138, 24);
            this.lblBusquedaArticulo.TabIndex = 0;
            this.lblBusquedaArticulo.Text = "Búscar artículo:";
            // 
            // txtBuscarElemento
            // 
            this.txtBuscarElemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscarElemento.Location = new System.Drawing.Point(360, 63);
            this.txtBuscarElemento.Name = "txtBuscarElemento";
            this.txtBuscarElemento.Size = new System.Drawing.Size(413, 20);
            this.txtBuscarElemento.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(799, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(220, 112);
            this.lwElementos.MinimumSize = new System.Drawing.Size(654, 519);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(654, 519);
            this.lwElementos.TabIndex = 4;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // frmVentana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1133, 753);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarElemento);
            this.Controls.Add(this.lblBusquedaArticulo);
            this.MinimumSize = new System.Drawing.Size(1149, 792);
            this.Name = "frmVentana2";
            this.Text = "Búsqueda de artículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusquedaArticulo;
        private System.Windows.Forms.TextBox txtBuscarElemento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lwElementos;
    }
}