using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LaMarva1._0
{
    public partial class PantallaDM : Form
    {

        #region Clases
        Clases.DBConnectionTienda tienda = new Clases.DBConnectionTienda();
        Clases.DBConnectionCriaturas bichos = new Clases.DBConnectionCriaturas();
        Clases.ImagenesCriaturas imgCriatura = new Clases.ImagenesCriaturas();
        Clases.DBConnectionCriaturasPersonalizadas criaturaPersonalizada = new Clases.DBConnectionCriaturasPersonalizadas();
        Clases.DBConnectionConjuros conjuros = new Clases.DBConnectionConjuros();
        Clases.DBConnectionPnj pnjs = new Clases.DBConnectionPnj();
        CriaturasPersonalizadas criaturaPropia = new CriaturasPersonalizadas();
        #endregion

        #region Declaraciones
        Random lanzarDado = new Random();
        int _d4;
        int _d6;
        int _d8;
        int _d10;
        int _d12;
        int _d20;
        int _vidaMax;
        #endregion
        

        public PantallaDM()
        {
            InitializeComponent();
        }


        private void PantallaDM_Load(object sender, EventArgs e)
        {
            tienda.llenarGridArmas(dgvArmas);
            tienda.llenarGridArmaduras(dgvArmaduras);
            tienda.llenarGridEquipo(dgvEquipo);
            tienda.llenarGridTransporte(dgvTransporte);

            

            bichos.llenarCriatura(cbCriaturas.Text,lNombreC,lVida,lPX, lArmasCombI, lArmasCombII, lDG,lMoral, lTesoro,lCA, lAlineamiento, lMovimiento,lSVen,lSVar,lSPetrif,lSAliD,lSSort,lHabilidadI,lHabilidadII,lAtaque);
            imgCriatura.colocarImagen(cbCriaturas.Text, pbCriatura);
            criaturaPersonalizada.llenarComboCriaturas(cbSelecCriatura);
            pnjs.llenarComboPnj(cbPnj);
            _vidaMax = Convert.ToInt32(bichos.vidaMaxima(cbCriaturas.Text));

        }
        private void btLanzarD20_Click(object sender, EventArgs e)
        {
            _d20 = Convert.ToInt32(cbD20.Text);
            tbResultadoD20.Text = (lanzarDado.Next(1, 21) * _d20).ToString();
        }

        private void btLanzarD4_Click(object sender, EventArgs e)
        {
            _d4 = Convert.ToInt32(cbD4.Text);
            tbD4.Text = (lanzarDado.Next(1, 5) * _d4).ToString();
        }

        private void btLanzarD6_Click(object sender, EventArgs e)
        {
            _d6 = Convert.ToInt32(cbD6.Text);
            tbD6.Text = (lanzarDado.Next(1, 7) * _d6).ToString();
        }

        private void btLanzarD8_Click(object sender, EventArgs e)
        {
            _d8 = Convert.ToInt32(cbD8.Text);
            tbD8.Text = (lanzarDado.Next(1, 9) * _d8).ToString();
        }

        private void btLanzarD10_Click(object sender, EventArgs e)
        {
            _d10 = Convert.ToInt32(cbD10.Text);
            tbD10.Text = (lanzarDado.Next(1, 11) * _d10).ToString();
        }

        private void btLanzarD12_Click(object sender, EventArgs e)
        {
            _d12 = Convert.ToInt32(cbD12.Text);
            tbD12.Text = (lanzarDado.Next(1, 13) * _d12).ToString();
        }

        private void tbBusquedaArmas_TextChanged(object sender, EventArgs e)
        {
            dgvArmas.Rows.Clear();
            tienda.busquedaArmas(tbBusquedaArmas.Text, dgvArmas);
        }

        private void tbBusquedaArmadura_TextChanged(object sender, EventArgs e)
        {
            dgvArmaduras.Rows.Clear();
            tienda.busquedaArmaduras(tbBusquedaArmadura.Text, dgvArmaduras);
        }

        private void tbBusquedaTransporte_TextChanged(object sender, EventArgs e)
        {
            dgvTransporte.Rows.Clear();
            tienda.busquedaTransporte(tbBusquedaTransporte.Text, dgvTransporte);
        }

        private void tbBusquedaEquipo_TextChanged(object sender, EventArgs e)
        {
            dgvEquipo.Rows.Clear();
            tienda.busquedaEquipo(tbBusquedaEquipo.Text, dgvEquipo);
        }



        private void dgvEquipo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string celda;
            int a;
            celda = dgvEquipo.CurrentRow.Cells[0].Value.ToString();
            a = dgvEquipo.CurrentRow.Index;

            EquipoDescripcion eq = new EquipoDescripcion(celda,a);
            eq.Show();


        }

        private void cbCriaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bichos.llenarCriatura2(cbCriaturas.Text, lNombreC, lVida, lPX, lArmasCombI, lArmasCombII, lDG, lMoral, lTesoro, lCA, lAlineamiento, lMovimiento, lSVen, lSVar, lSPetrif, lSAliD, lSSort,lHabilidadI,lHabilidadII,lAtaque);
            imgCriatura.colocarImagen(cbCriaturas.Text, pbCriatura);
            _vidaMax = Convert.ToInt32(bichos.vidaMaxima(cbCriaturas.Text));
        }

        private void label10_Click(object sender, EventArgs e)
        {
            criaturaPropia.Show();
        }

        private void cbSelecCriatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            criaturaPersonalizada.llenarCriaturaPersonalizada(cbSelecCriatura.Text, lNombreCriatura, lCriaturaVida, lCriaturaPX,
                                                              lCriaturaArmasI, lCriaturaArmasII, lCriaturaDG, lCriaturaMoral, lCriaturaTesoro,
                                                              lCriaturaCA, lCriaturaAlineam, lCriaturaMov, lCriaturaVeneno, lCriaturaVaritas,
                                                              lCriaturasPetrif, lCriaturaAliDrag, lCriaturaSorti, lCriaturaHabilI, lCriaturaHabilII,
                                                              pbImagenCriatura,lCriaturaAtaque);
                                                              
        }

        private void cbConjuros_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvConjuros.Rows.Clear();
            if (cbConjuros.Text == "Arcanos")
            {
                conjuros.llenarArcanos(dgvConjuros);
            }
            else if (cbConjuros.Text == "Divinos")
            {
                conjuros.llenarDivinos(dgvConjuros);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Pnj nuevoPnj = new Pnj();
            nuevoPnj.Show();
        }

        private void cbPnj_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            pnjs.mostrarPnj(cbPnj.Text, lNombrePnj, lClase, lNivel, lAlinPnj, lVidaPnj, lCAPnj, lPXPnj, lMovPnj, lTesoroPnj,
                            lArmCombPnj, lSVenPnj, lSVarPnj, lSPetrfPnj, lSALiDPnj, lSortiPnj, pbPnj, lTexto);
            if (lClase.Text == "Guerrero")
            {
                pConjuros.Visible = false;
            }
        }

        private void cbPnj_Click(object sender, EventArgs e)
        {
            cbPnj.Items.Clear();
            pnjs.llenarComboPnj(cbPnj);
        }

        private void cbSelecCriatura_Click(object sender, EventArgs e)
        {
            cbSelecCriatura.Items.Clear();
            criaturaPersonalizada.llenarComboCriaturas(cbSelecCriatura);
        }

        private void pRobleda_Click(object sender, EventArgs e)
        {
            Localizacion lugar = new Localizacion(pRobleda.Name.ToString());

            lugar.Show();
        }

        private void pPuertaNegra_Click(object sender, EventArgs e)
        {
            Localizacion lugar = new Localizacion(pPuertaNegra.Name.ToString());

            lugar.Show();
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            int auxMax;
            auxMax = Convert.ToInt32(lVida.Text);

            if(auxMax<_vidaMax)
            {
            auxMax = Convert.ToInt32(lVida.Text) + 1;
            lVida.Text = auxMax.ToString();
            }
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            int auxMin;
            int _vidaMin = 0;
            auxMin = Convert.ToInt32(lVida.Text);

            if (auxMin > _vidaMin)
            {
                auxMin = Convert.ToInt32(lVida.Text) - 1;
                lVida.Text = auxMin.ToString();
            }
        }

        


        }
}
