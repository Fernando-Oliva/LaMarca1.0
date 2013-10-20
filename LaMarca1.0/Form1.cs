using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaMarva1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    





        private void pInfo_Click(object sender, EventArgs e)
        {
            Info informacion = new Info();

            informacion.Show();
        }

        private void pMasterScreen_Click(object sender, EventArgs e)
        {
            PantallaDM MasterScreen = new PantallaDM();

            MasterScreen.Show();
        }



    

      }
}
