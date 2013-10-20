namespace LaMarva1._0
{
    partial class Localizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localizacion));
            this.pbImagenLugar = new System.Windows.Forms.PictureBox();
            this.tbDescripcionLugar = new System.Windows.Forms.TextBox();
            this.lNombreLugar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLugar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenLugar
            // 
            this.pbImagenLugar.Location = new System.Drawing.Point(12, 12);
            this.pbImagenLugar.Name = "pbImagenLugar";
            this.pbImagenLugar.Size = new System.Drawing.Size(532, 724);
            this.pbImagenLugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenLugar.TabIndex = 0;
            this.pbImagenLugar.TabStop = false;
            // 
            // tbDescripcionLugar
            // 
            this.tbDescripcionLugar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcionLugar.Location = new System.Drawing.Point(550, 12);
            this.tbDescripcionLugar.Multiline = true;
            this.tbDescripcionLugar.Name = "tbDescripcionLugar";
            this.tbDescripcionLugar.ReadOnly = true;
            this.tbDescripcionLugar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcionLugar.Size = new System.Drawing.Size(396, 347);
            this.tbDescripcionLugar.TabIndex = 1;
            // 
            // lNombreLugar
            // 
            this.lNombreLugar.AutoSize = true;
            this.lNombreLugar.Font = new System.Drawing.Font("UnZialish", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreLugar.Location = new System.Drawing.Point(689, 472);
            this.lNombreLugar.Name = "lNombreLugar";
            this.lNombreLugar.Size = new System.Drawing.Size(133, 43);
            this.lNombreLugar.TabIndex = 2;
            this.lNombreLugar.Text = "label1";
            // 
            // Localizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 748);
            this.Controls.Add(this.lNombreLugar);
            this.Controls.Add(this.tbDescripcionLugar);
            this.Controls.Add(this.pbImagenLugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Localizacion";
            this.Text = "Localizacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenLugar;
        private System.Windows.Forms.TextBox tbDescripcionLugar;
        private System.Windows.Forms.Label lNombreLugar;
    }
}