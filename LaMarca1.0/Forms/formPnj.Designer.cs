namespace LaMarva1._0
{
    partial class formPnj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPnj));
            this.cbAlineamiento = new System.Windows.Forms.ComboBox();
            this.tbNombrePnj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlinePnj = new System.Windows.Forms.ComboBox();
            this.cbClase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbArmadura = new System.Windows.Forms.ComboBox();
            this.tbHabilIPnj = new System.Windows.Forms.TextBox();
            this.tbHabilIIPnj = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btAbrirImgPnj = new System.Windows.Forms.Button();
            this.tbRutaPnj = new System.Windows.Forms.TextBox();
            this.pbPnjCarga = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btGuardarPnj = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cbEscudo = new System.Windows.Forms.ComboBox();
            this.dgvSelectConjuros = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nombre_Conj_Pers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_Conj_Pers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alcance_Conj_Pers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durac_Conj_Pers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Conj_Pers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPnjCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectConjuros)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAlineamiento
            // 
            this.cbAlineamiento.FormattingEnabled = true;
            this.cbAlineamiento.Items.AddRange(new object[] {
            "Legal",
            "Neutral",
            "Caotico"});
            this.cbAlineamiento.Location = new System.Drawing.Point(1422, 77);
            this.cbAlineamiento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAlineamiento.Name = "cbAlineamiento";
            this.cbAlineamiento.Size = new System.Drawing.Size(199, 23);
            this.cbAlineamiento.TabIndex = 25;
            // 
            // tbNombrePnj
            // 
            this.tbNombrePnj.Location = new System.Drawing.Point(532, 58);
            this.tbNombrePnj.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNombrePnj.Name = "tbNombrePnj";
            this.tbNombrePnj.Size = new System.Drawing.Size(185, 23);
            this.tbNombrePnj.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Alineamiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre:";
            // 
            // cbAlinePnj
            // 
            this.cbAlinePnj.FormattingEnabled = true;
            this.cbAlinePnj.Items.AddRange(new object[] {
            "Legal",
            "Neutral",
            "Caotico"});
            this.cbAlinePnj.Location = new System.Drawing.Point(891, 58);
            this.cbAlinePnj.Name = "cbAlinePnj";
            this.cbAlinePnj.Size = new System.Drawing.Size(121, 23);
            this.cbAlinePnj.TabIndex = 26;
            // 
            // cbClase
            // 
            this.cbClase.FormattingEnabled = true;
            this.cbClase.Items.AddRange(new object[] {
            "Clerigo",
            "Elfo",
            "Enano",
            "Explorador",
            "Guerrero",
            "Halfling",
            "Ladron",
            "Mago",
            "Paladin"});
            this.cbClase.Location = new System.Drawing.Point(532, 87);
            this.cbClase.Name = "cbClase";
            this.cbClase.Size = new System.Drawing.Size(121, 23);
            this.cbClase.TabIndex = 27;
            this.cbClase.SelectedIndexChanged += new System.EventHandler(this.cbClase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Clase:";
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbNivel.Location = new System.Drawing.Point(782, 87);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(64, 23);
            this.cbNivel.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nivel:";
            // 
            // cbArma
            // 
            this.cbArma.FormattingEnabled = true;
            this.cbArma.Location = new System.Drawing.Point(73, 148);
            this.cbArma.Name = "cbArma";
            this.cbArma.Size = new System.Drawing.Size(121, 23);
            this.cbArma.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Arma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Armadura:";
            // 
            // cbArmadura
            // 
            this.cbArmadura.FormattingEnabled = true;
            this.cbArmadura.Location = new System.Drawing.Point(292, 148);
            this.cbArmadura.Name = "cbArmadura";
            this.cbArmadura.Size = new System.Drawing.Size(121, 23);
            this.cbArmadura.TabIndex = 33;
            // 
            // tbHabilIPnj
            // 
            this.tbHabilIPnj.Location = new System.Drawing.Point(219, 221);
            this.tbHabilIPnj.Name = "tbHabilIPnj";
            this.tbHabilIPnj.Size = new System.Drawing.Size(326, 23);
            this.tbHabilIPnj.TabIndex = 49;
            // 
            // tbHabilIIPnj
            // 
            this.tbHabilIIPnj.Location = new System.Drawing.Point(219, 250);
            this.tbHabilIIPnj.Name = "tbHabilIIPnj";
            this.tbHabilIIPnj.Size = new System.Drawing.Size(326, 23);
            this.tbHabilIIPnj.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 250);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Habilidades Especiales II:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 224);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 15);
            this.label18.TabIndex = 46;
            this.label18.Text = "Habilidades Especiales I:";
            // 
            // btAbrirImgPnj
            // 
            this.btAbrirImgPnj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAbrirImgPnj.FlatAppearance.BorderSize = 0;
            this.btAbrirImgPnj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirImgPnj.Image = ((System.Drawing.Image)(resources.GetObject("btAbrirImgPnj.Image")));
            this.btAbrirImgPnj.Location = new System.Drawing.Point(910, 143);
            this.btAbrirImgPnj.Name = "btAbrirImgPnj";
            this.btAbrirImgPnj.Size = new System.Drawing.Size(29, 23);
            this.btAbrirImgPnj.TabIndex = 62;
            this.btAbrirImgPnj.UseVisualStyleBackColor = true;
            this.btAbrirImgPnj.Click += new System.EventHandler(this.btAbrirImgPnj_Click);
            // 
            // tbRutaPnj
            // 
            this.tbRutaPnj.Enabled = false;
            this.tbRutaPnj.Location = new System.Drawing.Point(646, 143);
            this.tbRutaPnj.Name = "tbRutaPnj";
            this.tbRutaPnj.Size = new System.Drawing.Size(258, 23);
            this.tbRutaPnj.TabIndex = 61;
            // 
            // pbPnjCarga
            // 
            this.pbPnjCarga.Location = new System.Drawing.Point(601, 180);
            this.pbPnjCarga.Name = "pbPnjCarga";
            this.pbPnjCarga.Size = new System.Drawing.Size(338, 435);
            this.pbPnjCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPnjCarga.TabIndex = 60;
            this.pbPnjCarga.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(576, 146);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 15);
            this.label19.TabIndex = 59;
            this.label19.Text = "Imagen:";
            // 
            // btGuardarPnj
            // 
            this.btGuardarPnj.Location = new System.Drawing.Point(179, 579);
            this.btGuardarPnj.Name = "btGuardarPnj";
            this.btGuardarPnj.Size = new System.Drawing.Size(107, 52);
            this.btGuardarPnj.TabIndex = 63;
            this.btGuardarPnj.Text = "Almacenar PNJ";
            this.btGuardarPnj.UseVisualStyleBackColor = true;
            this.btGuardarPnj.Click += new System.EventHandler(this.btGuardarPnj_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(419, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 15);
            this.label20.TabIndex = 65;
            this.label20.Text = "Escudo:";
            // 
            // cbEscudo
            // 
            this.cbEscudo.FormattingEnabled = true;
            this.cbEscudo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbEscudo.Location = new System.Drawing.Point(490, 148);
            this.cbEscudo.Name = "cbEscudo";
            this.cbEscudo.Size = new System.Drawing.Size(50, 23);
            this.cbEscudo.TabIndex = 64;
            // 
            // dgvSelectConjuros
            // 
            this.dgvSelectConjuros.AllowDrop = true;
            this.dgvSelectConjuros.AllowUserToAddRows = false;
            this.dgvSelectConjuros.AllowUserToDeleteRows = false;
            this.dgvSelectConjuros.AllowUserToResizeColumns = false;
            this.dgvSelectConjuros.AllowUserToResizeRows = false;
            this.dgvSelectConjuros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvSelectConjuros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectConjuros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Nombre_Conj_Pers,
            this.Nivel_Conj_Pers,
            this.Alcance_Conj_Pers,
            this.Durac_Conj_Pers,
            this.Descrip_Conj_Pers});
            this.dgvSelectConjuros.Location = new System.Drawing.Point(15, 336);
            this.dgvSelectConjuros.MultiSelect = false;
            this.dgvSelectConjuros.Name = "dgvSelectConjuros";
            this.dgvSelectConjuros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectConjuros.Size = new System.Drawing.Size(530, 150);
            this.dgvSelectConjuros.TabIndex = 66;
            this.dgvSelectConjuros.Visible = false;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Check.Width = 19;
            // 
            // Nombre_Conj_Pers
            // 
            this.Nombre_Conj_Pers.HeaderText = "Nombre";
            this.Nombre_Conj_Pers.Name = "Nombre_Conj_Pers";
            this.Nombre_Conj_Pers.ReadOnly = true;
            this.Nombre_Conj_Pers.Width = 85;
            // 
            // Nivel_Conj_Pers
            // 
            this.Nivel_Conj_Pers.HeaderText = "Nivel";
            this.Nivel_Conj_Pers.Name = "Nivel_Conj_Pers";
            this.Nivel_Conj_Pers.ReadOnly = true;
            this.Nivel_Conj_Pers.Width = 73;
            // 
            // Alcance_Conj_Pers
            // 
            this.Alcance_Conj_Pers.HeaderText = "Alcance";
            this.Alcance_Conj_Pers.Name = "Alcance_Conj_Pers";
            this.Alcance_Conj_Pers.ReadOnly = true;
            this.Alcance_Conj_Pers.Width = 93;
            // 
            // Durac_Conj_Pers
            // 
            this.Durac_Conj_Pers.HeaderText = "Duracion";
            this.Durac_Conj_Pers.Name = "Durac_Conj_Pers";
            this.Durac_Conj_Pers.ReadOnly = true;
            this.Durac_Conj_Pers.Width = 101;
            // 
            // Descrip_Conj_Pers
            // 
            this.Descrip_Conj_Pers.HeaderText = "Descripcion";
            this.Descrip_Conj_Pers.Name = "Descrip_Conj_Pers";
            this.Descrip_Conj_Pers.ReadOnly = true;
            this.Descrip_Conj_Pers.Width = 119;
            // 
            // formPnj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 652);
            this.Controls.Add(this.dgvSelectConjuros);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbEscudo);
            this.Controls.Add(this.btGuardarPnj);
            this.Controls.Add(this.btAbrirImgPnj);
            this.Controls.Add(this.tbRutaPnj);
            this.Controls.Add(this.pbPnjCarga);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbHabilIPnj);
            this.Controls.Add(this.tbHabilIIPnj);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbArmadura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbArma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbClase);
            this.Controls.Add(this.cbAlinePnj);
            this.Controls.Add(this.cbAlineamiento);
            this.Controls.Add(this.tbNombrePnj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UnZialish", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "formPnj";
            this.Text = "Pnj";
            this.Load += new System.EventHandler(this.Pnj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPnjCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectConjuros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAlineamiento;
        private System.Windows.Forms.TextBox tbNombrePnj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlinePnj;
        private System.Windows.Forms.ComboBox cbClase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbArma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbArmadura;
        private System.Windows.Forms.TextBox tbHabilIPnj;
        private System.Windows.Forms.TextBox tbHabilIIPnj;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btAbrirImgPnj;
        private System.Windows.Forms.TextBox tbRutaPnj;
        private System.Windows.Forms.PictureBox pbPnjCarga;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btGuardarPnj;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbEscudo;
        private System.Windows.Forms.DataGridView dgvSelectConjuros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Conj_Pers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_Conj_Pers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alcance_Conj_Pers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durac_Conj_Pers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Conj_Pers;
    }
}