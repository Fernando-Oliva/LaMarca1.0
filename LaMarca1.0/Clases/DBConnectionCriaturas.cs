using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Configuration;

namespace LaMarva1._0.Clases
{
    class DBConnectionCriaturas
    {
        #region Declaraciones
        SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["LaMarva1._0.Properties.Settings.MordorConnectionString"].ToString());
        SqlCeCommand comando;
        SqlCeDataReader valores;
        string _consulta;
        #endregion

        public void llenarCriatura(string _nombrecb,Label _Nombre, Label _VidaMed, Label _PX, Label _armCombI,
                                   Label _armCombII, Label _DG, Label _Moral, Label _Tesoro, Label _CA, Label _Alineam, Label _Movi,
                                   Label _SalVen, Label _SalVar, Label _SalPetrif, Label _SalAlienD, Label _SalSort, Label _HabilI, Label _HabilII, Label _Ataque)
                                  
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var criaturas = from criatura in mordorctxt.Criaturas
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
                _Ataque.Text = criatura.Criatura_Ataque.ToString();
            }

            mordorctxt.Connection.Close();
        }

        public void llenarCriatura2(string _nombrecb,Label _Nombre, Label _VidaMed, Label _PX, Label _armCombI,
                                    Label _armCombII ,Label _DG, Label _Moral, Label _Tesoro, Label _CA, Label _Alineam, Label _Movi,
                                    Label _SalVen, Label _SalVar, Label _SalPetrif, Label _SalAlienD, Label _SalSort,
                                    Label _HabilI, Label _HabilII, Label _Ataque)
        {


            _consulta = "select Criatura_Nombre, Criatura_CA_Neg, Criatura_Vida_Media," +
                        "Criatura_Moral, Criatura_ValorPX, Criatura_DG, Criatura_Ataque_I," +
                        "Criatura_Mov, Criatura_S_AlienDrag, Criatura_Ataque," +
                        "Criatura_S_VenMuer, Criatura_S_PetrifParal, Criatura_S_Sortilegios," +
                        "Criatura_Habilidades_I, Criatura_Habilidades_II, Criatura_S_Varitas, Criatura_Ataque_II, Criatura_ValorTesoro, Criatura_Alineam from Criaturas" +
                        " where Criatura_Nombre = '" + _nombrecb + "'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {

                _Nombre.Text    = "- " + valores["Criatura_Nombre"].ToString() + " -";
                _VidaMed.Text   = valores["Criatura_Vida_Media"].ToString();
                _CA.Text        = valores["Criatura_CA_Neg"].ToString();
                _Moral.Text     = valores["Criatura_Moral"].ToString();
                _PX.Text        = valores["Criatura_ValorPX"].ToString();
                _DG.Text        = valores["Criatura_DG"].ToString();
                _armCombI.Text  = valores["Criatura_Ataque_I"].ToString();
                _armCombII.Text = valores["Criatura_Ataque_II"].ToString();
                _Tesoro.Text    = valores["Criatura_ValorTesoro"].ToString();
                _Alineam.Text   = valores["Criatura_Alineam"].ToString();
                _Movi.Text      = valores["Criatura_Mov"].ToString();
                _SalAlienD.Text = valores["Criatura_S_AlienDrag"].ToString();
                _SalVen.Text    = valores["Criatura_S_VenMuer"].ToString();
                _SalPetrif.Text = valores["Criatura_S_PetrifParal"].ToString();
                _SalSort.Text   = valores["Criatura_S_Sortilegios"].ToString();
                _SalVar.Text    = valores["Criatura_S_Varitas"].ToString();
                _HabilI.Text    = valores["Criatura_Habilidades_I"].ToString();
                _HabilII.Text   = valores["Criatura_Habilidades_II"].ToString();
                _Ataque.Text = valores["Criatura_Ataque"].ToString();
            }
            conexion.Close();
        }

        public string vidaMaxima(string _nombreCriatura)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var vidaMax = from vida in mordorctxt.Criaturas
                          where vida.Criatura_Nombre.Contains(_nombreCriatura)
                          select vida.Criatura_Vida_Max;

            string life = string.Empty;

            foreach (var vida in vidaMax)
            {
                life = vida.Value.ToString();
            }

            mordorctxt.Connection.Close();

            return life;
        }
    }
}
