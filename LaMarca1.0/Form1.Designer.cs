namespace LaMarva1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMasterScreen = new System.Windows.Forms.Panel();
            this.pInfo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pMasterScreen);
            this.panel1.Controls.Add(this.pInfo);
            this.panel1.Location = new System.Drawing.Point(16, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 393);
            this.panel1.TabIndex = 0;
            // 
            // pMasterScreen
            // 
            this.pMasterScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMasterScreen.Location = new System.Drawing.Point(61, 193);
            this.pMasterScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMasterScreen.Name = "pMasterScreen";
            this.pMasterScreen.Size = new System.Drawing.Size(531, 38);
            this.pMasterScreen.TabIndex = 1;
            this.pMasterScreen.Click += new System.EventHandler(this.pMasterScreen_Click);
            // 
            // pInfo
            // 
            this.pInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pInfo.Location = new System.Drawing.Point(263, 267);
            this.pInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(119, 38);
            this.pInfo.TabIndex = 0;
            this.pInfo.Click += new System.EventHandler(this.pInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 801);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "LaMarca1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Panel pMasterScreen;


    }
}

