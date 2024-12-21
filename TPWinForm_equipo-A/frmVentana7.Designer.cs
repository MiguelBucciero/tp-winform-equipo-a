namespace TPWinForm_equipo_A
{
    partial class frmVentana7
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
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblDireccionUrl = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(322, 531);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(90, 33);
            this.btnAgregarImagen.TabIndex = 0;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagen.Location = new System.Drawing.Point(78, 97);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(640, 410);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 1;
            this.pbxImagen.TabStop = false;
            // 
            // lblDireccionUrl
            // 
            this.lblDireccionUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccionUrl.AutoSize = true;
            this.lblDireccionUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUrl.Location = new System.Drawing.Point(74, 56);
            this.lblDireccionUrl.Name = "lblDireccionUrl";
            this.lblDireccionUrl.Size = new System.Drawing.Size(100, 20);
            this.lblDireccionUrl.TabIndex = 2;
            this.lblDireccionUrl.Text = "Dirección url:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlImagen.Location = new System.Drawing.Point(180, 50);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(538, 26);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            // 
            // frmVentana7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblDireccionUrl);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.MinimumSize = new System.Drawing.Size(816, 637);
            this.Name = "frmVentana7";
            this.Text = "frmVentana7";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblDireccionUrl;
        private System.Windows.Forms.TextBox txtUrlImagen;
    }
}