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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarOtraImagen = new System.Windows.Forms.Button();
            this.pbxImagenUrl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(90, 26);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(743, 26);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnAgregarOtraImagen
            // 
            this.btnAgregarOtraImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarOtraImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOtraImagen.Location = new System.Drawing.Point(368, 466);
            this.btnAgregarOtraImagen.Name = "btnAgregarOtraImagen";
            this.btnAgregarOtraImagen.Size = new System.Drawing.Size(121, 37);
            this.btnAgregarOtraImagen.TabIndex = 2;
            this.btnAgregarOtraImagen.Text = "Agregar";
            this.btnAgregarOtraImagen.UseVisualStyleBackColor = true;
            this.btnAgregarOtraImagen.Click += new System.EventHandler(this.btnAgregarOtraImagen_Click);
            // 
            // pbxImagenUrl
            // 
            this.pbxImagenUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagenUrl.Location = new System.Drawing.Point(151, 84);
            this.pbxImagenUrl.Name = "pbxImagenUrl";
            this.pbxImagenUrl.Size = new System.Drawing.Size(577, 342);
            this.pbxImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenUrl.TabIndex = 3;
            this.pbxImagenUrl.TabStop = false;
            // 
            // frmVentana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 523);
            this.Controls.Add(this.pbxImagenUrl);
            this.Controls.Add(this.btnAgregarOtraImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.MaximumSize = new System.Drawing.Size(874, 562);
            this.MinimumSize = new System.Drawing.Size(874, 562);
            this.Name = "frmVentana2";
            this.Text = "Agregar imagen";
            this.Load += new System.EventHandler(this.frmVentana2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarOtraImagen;
        private System.Windows.Forms.PictureBox pbxImagenUrl;
    }
}