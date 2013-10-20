using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace LaMarva1._0.Clases
{
    class DBConnectionCriaturas
    {
        #region Declaraciones
        SqlCeConnection conexion = new SqlCeConnection(DBConnectionConfig.dbConnection);
        SqlCeCommand comando;
        SqlCeDataReader valores;
        string _consulta;
        #endregion

        public void llenarCriatura(string _nombrecb,Label _Nombre, Label _VidaMed, Label _PX, Label _armCombI,
                                   Label _armCombII, Label _DG, Label _Moral, Label _Tesoro, Label _CA, Label _Alineam, Label _Movi,
                                   Label _SalVen, Label _SalVar, Label _SalPetrif, Label _SalAlienD, Label _SalSort, Label _HabilI, Label _HabilII, Label _Ataque)
                                  
        {
            
            _consulta = "select Criatura_Nombre, Criatura_CA_Neg, Criatura_Vida_Media," +
                        "Criatura_Moral, Criatura_ValorPX, Criatura_DG, Criatura_Ataque, Criatura_Ataque_I, Criatura_Ataque_II," +
                        "Criatura_ValorTesoro, Criatura_Alineam, Criatura_Mov, Criatura_S_AlienDrag, " +
                        "Criatura_S_VenMuer, Criatura_S_PetrifParal, Criatura_S_Sortilegios," +
                        "Criatura_Habilidades_I, Criatura_Habilidades_II, Criatura_S_Varitas from Criaturas where Criatura_Nombre = '" + _nombrecb + "'";
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
                _HabilI.Text = valores["Criatura_Habilidades_I"].ToString();
                _HabilII.Text = valores["Criatura_Habilidades_II"].ToString();
                _Ataque.Text = valores["Criatura_Ataque"].ToString();
            }
            conexion.Close();
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
            string _vidaMax = "";

            _consulta = "select Criatura_Vida_Max from Criaturas where Criatura_Nombre = '" + _nombreCriatura + "'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();
            while (valores.Read())
            {
                _vidaMax = valores["Criatura_Vida_Max"].ToString();
            }
            conexion.Close();

            return _vidaMax;

        }
    }
}
