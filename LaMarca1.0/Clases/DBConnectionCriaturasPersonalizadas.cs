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
        SqlCeCommand comando;
        SqlCeDataReader valores;
        string _consulta;
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

            _consulta = "insert into CriaturasPersonalizadas values ('" + _nombre + "'," + ca + "," + caPos +
                        "," + vida + "," + vidaMax + "," + ataque + ",'" + _armasI + "','" + _armasII + "'," + sVeneno +
                        "," + sVaritas + "," + sPetrif + "," + aliDrag + "," + sorti + "," + mov + "," + moral +
                        "," + tesoro + ",'" + _alineam + "'," + px + "," + dg + ",'" + _habilI + "','" + _habilII + "','" + _ruta + "')";

            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
         
            conexion.Close();
        }

        public void llenarComboCriaturas(ComboBox _Combo)
        {
            int f = 0;
            _consulta = "select Criatura_Nombre from CriaturasPersonalizadas";
            comando = new SqlCeCommand(_consulta, conexion);
            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
            

                _Combo.Items.Insert(f,valores["Criatura_Nombre"].ToString());


                f = f + 1;
            }
            conexion.Close();

        }

        public void llenarCriaturaPersonalizada(string _nombrecb, Label _Nombre, Label _VidaMed, Label _PX, Label _armCombI,
                                   Label _armCombII, Label _DG, Label _Moral, Label _Tesoro, Label _CA, Label _Alineam, Label _Movi,
                                   Label _SalVen, Label _SalVar, Label _SalPetrif, Label _SalAlienD, Label _SalSort, Label _HabilI, Label _HabilII, PictureBox _Imagen, Label _Ataque)
        {
            _consulta = "select Criatura_Nombre, Criatura_CA_Neg, Criatura_Vida_Media, Criatura_Ataque," +
                                   "Criatura_Moral, Criatura_ValorPX, Criatura_DG, Criatura_Ataque_I, Criatura_Ataque_II," +
                                   "Criatura_ValorTesoro, Criatura_Alineam, Criatura_Mov, Criatura_S_AlienDrag, " +
                                   "Criatura_S_VenMuer, Criatura_S_PetrifParal, Criatura_S_Sortilegios," +
                                   "Criatura_Habilidades_I, Criatura_Habilidades_II, Criatura_S_Varitas, Criatura_Ruta from CriaturasPersonalizadas where Criatura_Nombre = '" + _nombrecb + "'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {

                _Nombre.Text = "- " + valores["Criatura_Nombre"].ToString() + " -";
                _VidaMed.Text = valores["Criatura_Vida_Media"].ToString();
                _CA.Text = valores["Criatura_CA_Neg"].ToString();
                _Moral.Text = valores["Criatura_Moral"].ToString();
                _PX.Text = valores["Criatura_ValorPX"].ToString();
                _DG.Text = valores["Criatura_DG"].ToString();
                _armCombI.Text = valores["Criatura_Ataque_I"].ToString();
                _armCombII.Text = valores["Criatura_Ataque_II"].ToString();
                _Tesoro.Text = valores["Criatura_ValorTesoro"].ToString();
                _Alineam.Text = valores["Criatura_Alineam"].ToString();
                _Movi.Text = valores["Criatura_Mov"].ToString();
                _SalAlienD.Text = valores["Criatura_S_AlienDrag"].ToString();
                _SalVen.Text = valores["Criatura_S_VenMuer"].ToString();
                _SalPetrif.Text = valores["Criatura_S_PetrifParal"].ToString();
                _SalSort.Text = valores["Criatura_S_Sortilegios"].ToString();
                _SalVar.Text = valores["Criatura_S_Varitas"].ToString();
                _HabilI.Text = valores["Criatura_Habilidades_I"].ToString();
                _HabilII.Text = valores["Criatura_Habilidades_II"].ToString();
                _Imagen.ImageLocation = valores["Criatura_Ruta"].ToString();
                _Ataque.Text = valores["Criatura_Ataque"].ToString();
            }
            conexion.Close();
        }
    }
}
