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
            this.pbImagenLugar.Location = new System.Drawing.Point(16, 15);
            this.pbImagenLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenLugar.Name = "pbImagenLugar";
            this.pbImagenLugar.Size = new System.Drawing.Size(709, 891);
            this.pbImagenLugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenLugar.TabIndex = 0;
            this.pbImagenLugar.TabStop = false;
            // 
            // tbDescripcionLugar
            // 
            this.tbDescripcionLugar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcionLugar.Location = new System.Drawing.Point(733, 15);
            this.tbDescripcionLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcionLugar.Multiline = true;
            this.tbDescripcionLugar.Name = "tbDescripcionLugar";
            this.tbDescripcionLugar.ReadOnly = true;
            this.tbDescripcionLugar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcionLugar.Size = new System.Drawing.Size(527, 426);
            this.tbDescripcionLugar.TabIndex = 1;
            // 
            // lNombreLugar
            // 
            this.lNombreLugar.AutoSize = true;
            this.lNombreLugar.Font = new System.Drawing.Font("UnZialish", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreLugar.Location = new System.Drawing.Point(919, 581);
            this.lNombreLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreLugar.Name = "lNombreLugar";
            this.lNombreLugar.Size = new System.Drawing.Size(165, 55);
            this.lNombreLugar.TabIndex = 2;
            this.lNombreLugar.Text = "label1";
            // 
            // Localizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 921);
            this.Controls.Add(this.lNombreLugar);
            this.Controls.Add(this.tbDescripcionLugar);
            this.Controls.Add(this.pbImagenLugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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