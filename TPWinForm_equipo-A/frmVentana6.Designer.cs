﻿namespace TPWinForm_equipo_A
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleArticulo
            // 
            this.dgvDetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulo.Location = new System.Drawing.Point(159, 230);
            this.dgvDetalleArticulo.Name = "dgvDetalleArticulo";
            this.dgvDetalleArticulo.Size = new System.Drawing.Size(945, 501);
            this.dgvDetalleArticulo.TabIndex = 0;
            // 
            // lblDetalleDelArticulo
            // 
            this.lblDetalleDelArticulo.AutoSize = true;
            this.lblDetalleDelArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDelArticulo.Location = new System.Drawing.Point(495, 80);
            this.lblDetalleDelArticulo.Name = "lblDetalleDelArticulo";
            this.lblDetalleDelArticulo.Size = new System.Drawing.Size(215, 29);
            this.lblDetalleDelArticulo.TabIndex = 1;
            this.lblDetalleDelArticulo.Text = "Detalle del Articulo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(432, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(364, 158);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(66, 20);
            this.lblArticulo.TabIndex = 3;
            this.lblArticulo.Text = "Articulo:";
            // 
            // frmVentana6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 894);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDetalleDelArticulo);
            this.Controls.Add(this.dgvDetalleArticulo);
            this.Name = "frmVentana6";
            this.Text = "Ver detalle de un artículo";
            this.Load += new System.EventHandler(this.frmVentana6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleArticulo;
        private System.Windows.Forms.Label lblDetalleDelArticulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblArticulo;
    }
}