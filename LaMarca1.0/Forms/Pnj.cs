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
    public partial class formPnj : Form
    {
        Clases.DBConnectionPnj pnjs = new Clases.DBConnectionPnj();
        Clases.DBConnectionConjuros conjurosSeleccionados = new Clases.DBConnectionConjuros();
        public formPnj()
        {
            InitializeComponent();
        }

        private void btAbrirImgPnj_Click(object sender, EventArgs e)
        {
            string _fileName;
            OpenFileDialog buscar = new OpenFileDialog();

            //buscar.Filter = "Image files (*.png, *.jpg)|*.png, *.jpg";
            buscar.ShowDialog();
            _fileName = buscar.FileName;
            tbRutaPnj.Text = _fileName;
            pbPnjCarga.ImageLocation = _fileName;
        }

        private void btGuardarPnj_Click(object sender, EventArgs e)
        {
            int _ca;
            int _caTotal;
            string _atqArma;
            Clases.DBConnectionPnj pnj = new Clases.DBConnectionPnj();

            _ca = Convert.ToInt32(pnjs.obtenerCA(cbArmadura.Text));

            if (cbEscudo.Text == "Si")
            {
                _caTotal = _ca - 1;
            }
            else 
            {
                _caTotal =  _ca;
            }

            _atqArma = pnjs.obtenerAtqArma(cbArma.Text);
            pnjs.almacenarPnj(cbClase.Text, cbNivel.Text, tbNombrePnj.Text,cbAlinePnj.Text, cbArma.Text, cbArmadura.Text, cbEscudo.Text, tbRutaPnj.Text, _caTotal.ToString(), _atqArma);
           
            this.Close();
            
        }

        private void Pnj_Load(object sender, EventArgs e)
        {
            pnjs.llenarComboArmas(cbArma);
            pnjs.llenarComboArmaduras(cbArmadura);
        }

        private void cbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClase.Text == "Mago")
            {
                dgvSelectConjuros.Visible = true;
                conjurosSeleccionados.llenarArcanos(dgvSelectConjuros);
            }
        }


    }
}
