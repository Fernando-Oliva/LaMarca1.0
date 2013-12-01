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
    public partial class formCriaturasPersonalizadas : Form
    {
        public formCriaturasPersonalizadas()
        {
            InitializeComponent();
        }

        private void btAbrirImagen_Click(object sender, EventArgs e)
        {
            string _fileName;
            OpenFileDialog buscar = new OpenFileDialog();

            buscar.Filter = "Image files (*.png, *.jpg) | *.png";
            buscar.ShowDialog();
            _fileName = buscar.FileName;
            tbRutaImagen.Text = _fileName;
            pbCriaturaPers.ImageLocation = _fileName;
        }

        private void tbGuardar_Click(object sender, EventArgs e)
        {
            Clases.DBConnectionCriaturasPersonalizadas guardarCriatura = new Clases.DBConnectionCriaturasPersonalizadas();

            guardarCriatura.grabarCriatura(tbNombre.Text, cbAlineamiento.Text, tbAtaque.Text, tbTesoro.Text, tbMoral.Text,
                                           tbPX.Text, tbVida.Text, tbDG.Text, tbMovimiento.Text, tbCA.Text, tbVeneno.Text,
                                           tbVaritas.Text, tbPetrif.Text, tbAlienDrag.Text, tbSortileg.Text, tbHabilI.Text,
                                           tbHabilII.Text, tbArmasI.Text, tbArmasII.Text, tbRutaImagen.Text);


      
           
        }




    }
}
