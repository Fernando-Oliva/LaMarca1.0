using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Configuration;

namespace LaMarva1._0.Clases
{
    class DBConnectionPnj
    {
        #region Declaraciones
        Clases.EstadisticasGuerrero guerrero = new EstadisticasGuerrero();
        SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["LaMarva1._0.Properties.Settings.MordorConnectionString"].ToString());
        SqlCeCommand comando;
        SqlCeDataReader valores;
        string _consulta;
        int vidaMediaGuerrero;
        int vidaMaxGuerrero;
        int salvacionVeneno;
        int salvacionVaritas;
        int salvacionPetrif;
        int salvacionAliDrag;
        int salvacionSorti;
        int valorPX;
        int tesoro;
        string texto;
        int movimientoGuerrero;
        #endregion

        public void llenarComboArmas(ComboBox _Combo)
        {
            int f = 0;
            _consulta = "select Arma_Nombre from Armas";
            comando = new SqlCeCommand(_consulta, conexion);
            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {


                _Combo.Items.Insert(f, valores["Arma_Nombre"].ToString());


                f = f + 1;
            }
            conexion.Close();
        }

        public void llenarComboArmaduras(ComboBox _Combo)
        {
            int f = 0;
            _consulta = "select Armadura_Nombre from Armaduras";
            comando = new SqlCeCommand(_consulta, conexion);
            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {


                _Combo.Items.Insert(f, valores["Armadura_Nombre"].ToString());


                f = f + 1;
            }
            conexion.Close();
        }

        public void almacenarPnj(string _clase, string _nivel, string _nombre, string _alineam, string _arma, string _armadura, string _escudo, string _ruta, string _ca, string _atqArma)
        {
            if (_clase == "Guerrero")
            {
                int nivel = Convert.ToInt32(_nivel);
                int ca = Convert.ToInt32(_ca);
                int caPos = 12;
               
                int atq = 12;
                vidaMediaGuerrero = guerrero.vidaMedia(nivel);
                vidaMaxGuerrero = guerrero.vidaMaxima(nivel);
                salvacionVeneno = guerrero.salvacionVeneno(nivel);
                salvacionVaritas = guerrero.salvacionVaritas(nivel);
                salvacionPetrif = guerrero.salvacionPetrif(nivel);
                salvacionAliDrag = guerrero.salvacionAliDrag(nivel);
                salvacionSorti = guerrero.salvacionSorti(nivel);
                valorPX = guerrero.valorPX(nivel);
                tesoro = guerrero.tesoro(nivel);
                texto = guerrero.texto(nivel);
                movimientoGuerrero = 10;
                //revisar por si devuelve 0

                _consulta = "insert into Pnj values ('" + _nombre + "','" + _clase + "'," + nivel +",'" + _alineam + "','" + _arma + "','" +
                            _armadura + "','" + _escudo + "'," + ca + "," + caPos + "," + vidaMediaGuerrero + "," + vidaMaxGuerrero + ",'" +
                            _atqArma + "'," + atq + "," + salvacionVeneno + "," + salvacionVaritas + "," + salvacionPetrif + "," + salvacionAliDrag + "," + salvacionSorti +
                            "," + valorPX + "," + movimientoGuerrero + "," + tesoro + ",'" + texto + "','" + _ruta + "')";

                comando = new SqlCeCommand(_consulta, conexion);

                conexion.Open();
                comando.ExecuteNonQuery();

                conexion.Close();
            }
 
        }

        public void mostrarPnj(string _nombrecb, Label _nombre, Label _clase, Label _nivel, Label _aline, Label _vida, Label _ca,
                               Label _px, Label _mov, Label _tesoro, Label _arma, Label _veneno,
                               Label _varitas, Label _petrif, Label _aliDrag, Label _sorti, PictureBox _imagen, Label _texto)
        {
            _consulta = "select Pnj_Nombre, Pnj_Clase, Pnj_Nivel," +
                                 "Pnj_Alineamiento, Pnj_Arma, Pnj_Armadura, Pnj_Escudo, Pnj_CA_Neg, Pnj_Vida_Med," +
                                 "Pnj_S_Veneno, Pnj_S_Varitas, Pnj_S_Petrif, Pnj_S_AliDrag, " +
                                 "Pnj_S_Sorti, Pnj_PX, Pnj_Mov, Pnj_Ataque_Arma, " +
                                 "Pnj_Tesoro, Pnj_Texto, Pnj_Ruta from Pnj where Pnj_Nombre = '" + _nombrecb + "'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {

                _nombre.Text = "- " + valores["Pnj_Nombre"].ToString() + " -";
                _clase.Text = valores["Pnj_Clase"].ToString();
                _nivel.Text = valores["Pnj_Nivel"].ToString();
                _aline.Text = valores["Pnj_Alineamiento"].ToString();
                _vida.Text = valores["Pnj_Vida_Med"].ToString();
                _ca.Text = valores["Pnj_CA_Neg"].ToString();
                _px.Text = valores["Pnj_PX"].ToString();
                //_dg.Text = valores["Criatura_Ataque_II"].ToString();
                _mov.Text = valores["Pnj_Mov"].ToString();
                _tesoro.Text = valores["Pnj_Tesoro"].ToString();
                _arma.Text = valores["Pnj_Arma"].ToString() + " (" + valores["Pnj_Ataque_Arma"].ToString() + ")";
                _veneno.Text = valores["Pnj_S_Veneno"].ToString();
                _varitas.Text = valores["Pnj_S_Varitas"].ToString();
                _petrif.Text = valores["Pnj_S_Petrif"].ToString();
                _aliDrag.Text = valores["Pnj_S_AliDrag"].ToString();
                _sorti.Text = valores["Pnj_S_Sorti"].ToString();
                _texto.Text = valores["Pnj_Texto"].ToString();
                _imagen.ImageLocation = valores["Pnj_Ruta"].ToString();
            }
            conexion.Close();
        }

        public string obtenerCA(string _armaduraNombre)
        {
            string _caArm = "";

            _consulta = "select Armadura_CA from Armaduras where Armadura_Nombre = '" + _armaduraNombre + "'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                _caArm = valores["Armadura_CA"].ToString();
            }
            conexion.Close();

            return _caArm;
        }

        public string obtenerAtqArma(string _armaNombre)
        {
            string _armaDanio = "";
            _consulta = "select Arma_Danio from Armas where Arma_Nombre = '" + _armaNombre + "'";

            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                _armaDanio = valores["Arma_Danio"].ToString();
            }
            conexion.Close();

            return _armaDanio;
        }

        public void llenarComboPnj(ComboBox _Combo)
        {
            MordorContext mordorCtxt = new MordorContext(conexion);

            var todosPnj = from pnj in mordorCtxt.Pnj select pnj.Pnj_Nombre;

            _Combo.DataSource = todosPnj;
            //int f = 0;
            //_consulta = "select Pnj_Nombre from Pnj";
            //comando = new SqlCeCommand(_consulta, conexion);
            //conexion.Open();

            //valores = comando.ExecuteReader();

            //while (valores.Read())
            //{


            //    _Combo.Items.Insert(f, valores["Pnj_Nombre"].ToString());


            //    f = f + 1;
            //}
            //conexion.Close();

        }
    }
}
