namespace LaMarva1._0
{
    partial class EquipoDescripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipoDescripcion));
            this.pbEquipo = new System.Windows.Forms.PictureBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEquipo
            // 
            this.pbEquipo.Location = new System.Drawing.Point(12, 12);
            this.pbEquipo.Name = "pbEquipo";
            this.pbEquipo.Size = new System.Drawing.Size(171, 160);
            this.pbEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEquipo.TabIndex = 0;
            this.pbEquipo.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.Location = new System.Drawing.Point(198, 12);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(336, 274);
            this.tbDescripcion.TabIndex = 1;
            // 
            // EquipoDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 322);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.pbEquipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquipoDescripcion";
            this.Text = "EquipoDescripcion";
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEquipo;
        private System.Windows.Forms.TextBox tbDescripcion;

    }
}