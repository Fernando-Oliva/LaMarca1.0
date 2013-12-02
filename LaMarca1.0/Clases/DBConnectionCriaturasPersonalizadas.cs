using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Configuration;

namespace LaMarva1._0.Clases
{
    class DBConnectionCriaturasPersonalizadas
    {
        #region Declaraciones
        SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["LaMarva1._0.Properties.Settings.MordorConnectionString"].ToString());
        #endregion

       

        public void grabarCriatura(string _nombre, string _alineam, string _ataque, string _tesoro, string _moral,
                                   string _px, string _vida, string _dg, string _mov, string _ca,
                                   string _sVeneno, string _sVaritas, string _sPetrif, string _aliDrag,
                                   string _sorti, string _habilI, string _habilII, string _armasI,
                                   string _armasII, string _ruta)
        {
            int caPos = 12;
            int vidaMax = 40;

     

            #region Conversiones
            int ataque = Convert.ToInt32(_ataque);
            int tesoro = Convert.ToInt32(_tesoro);
            int moral = Convert.ToInt32(_moral);
            int px = Convert.ToInt32(_px);
            int vida = Convert.ToInt32(_vida);
            int dg = Convert.ToInt32(_dg);
            int mov = Convert.ToInt32(_mov);
            int ca = Convert.ToInt32(_ca);
            int sVeneno = Convert.ToInt32(_sVeneno);
            int sVaritas = Convert.ToInt32(_sVaritas);
            int sPetrif = Convert.ToInt32(_sPetrif);
            int aliDrag = Convert.ToInt32(_aliDrag);
            int sorti = Convert.ToInt32(_sorti);
            #endregion

            MordorContext mordorctxt = new MordorContext(conexion);

            foreach (var criatura in mordorctxt.CriaturasPersonalizadas)
            {
                criatura.Criatura_Nombre = _nombre;
                criatura.Criatura_CA_Neg = ca;
                criatura.Criatura_CA_Pos = caPos;
                criatura.Criatura_Vida_Media = vida;
                criatura.Criatura_Vida_Max = vidaMax;
                criatura.Criatura_Ataque = ataque;
                criatura.Criatura_Ataque_I = _armasI;
                criatura.Criatura_Ataque_II = _armasII;
                criatura.Criatura_S_VenMuer = sVeneno;
                criatura.Criatura_S_Varitas = sVaritas;
                criatura.Criatura_S_PetrifParal = sPetrif;
                criatura.Criatura_S_AlienDrag = aliDrag;
                criatura.Criatura_S_Sortilegios = sorti;
                criatura.Criatura_Mov = mov;
                criatura.Criatura_Moral = moral;
                criatura.Criatura_ValorTesoro = tesoro;
                criatura.Criatura_Alineam = _alineam;
                criatura.Criatura_ValorPX = px;
                criatura.Criatura_DG = dg;
                criatura.Criatura_Habilidades_I = _habilI;
                criatura.Criatura_Habilidades_II = _habilII;
                criatura.Criatura_Ruta = _ruta;

                mordorctxt.CriaturasPersonalizadas.InsertOnSubmit(criatura);
            }

            mordorctxt.Connection.Close();
        }

        public void llenarComboCriaturas(ComboBox _Combo)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var criaturaNombre = from criatura in mordorctxt.CriaturasPersonalizadas
                                 select criatura.Criatura_Nombre;

            _Combo.Items.Add(criaturaNombre);

            mordorctxt.Connection.Close();
        }

        public void llenarCriaturaPersonalizada(string _nombrecb, Label _Nombre, Label _VidaMed, Label _PX, Label _armCombI,
                                   Label _armCombII, Label _DG, Label _Moral, Label _Tesoro, Label _CA, Label _Alineam, Label _Movi,
                                   Label _SalVen, Label _SalVar, Label _SalPetrif, Label _SalAlienD, Label _SalSort, Label _HabilI, Label _HabilII, PictureBox _Imagen, Label _Ataque)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var criaturas = from criatura in mordorctxt.CriaturasPersonalizadas
                            where criatura.Criatura_Nombre.Contains(_nombrecb)
                            select criatura;

            foreach (var criatura in criaturas)
            {
                _Nombre.Text = criatura.Criatura_Nombre;
                _VidaMed.Text = criatura.Criatura_Vida_Media.ToString();
                _CA.Text = criatura.Criatura_CA_Neg.ToString();
                _Moral.Text = criatura.Criatura_Moral.ToString();
                _PX.Text = criatura.Criatura_ValorPX.ToString();
                _DG.Text = criatura.Criatura_DG.ToString();
                _armCombI.Text = criatura.Criatura_Ataque_I;
                _armCombII.Text = criatura.Criatura_Ataque_II;
                _Tesoro.Text = criatura.Criatura_ValorTesoro.ToString();
                _Alineam.Text = criatura.Criatura_Alineam;
                _Movi.Text = criatura.Criatura_Mov.ToString();
                _SalAlienD.Text = criatura.Criatura_S_AlienDrag.ToString();
                _SalVen.Text = criatura.Criatura_S_VenMuer.ToString();
                _SalPetrif.Text = criatura.Criatura_S_PetrifParal.ToString();
                _SalSort.Text = criatura.Criatura_S_Sortilegios.ToString();
                _SalVar.Text = criatura.Criatura_S_Varitas.ToString();
                _HabilI.Text = criatura.Criatura_Habilidades_I;
                _HabilII.Text = criatura.Criatura_Habilidades_II;
                _Imagen.ImageLocation = criatura.Criatura_Ruta;
                _Ataque.Text = criatura.Criatura_Ataque.ToString();
            }

            mordorctxt.Connection.Close();
        }
    }
}
