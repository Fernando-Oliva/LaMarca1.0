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
            MordorContext mordorctxt = new MordorContext(conexion);

            var armas = from arma in mordorctxt.Armas
                        select arma.Arma_Nombre;

            _Combo.Items.Add(armas);

            mordorctxt.Connection.Close();
        }

        public void llenarComboArmaduras(ComboBox _Combo)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var armaduras = from armadura in mordorctxt.Armaduras
                            select armadura.Armadura_Nombre;

            _Combo.Items.Add(armaduras);

            mordorctxt.Connection.Close();
        }

        public void almacenarPnj(string _clase, string _nivel, string _nombre, string _alineam, string _arma, string _armadura, string _escudo, string _ruta, string _ca, string _atqArma)
        {
            if (_clase == "Guerrero")
            {
                MordorContext mordorctxt = new MordorContext(conexion);

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

                foreach (var pnj in mordorctxt.Pnj)
                {
                    pnj.Pnj_Nombre = _nombre;
                    pnj.Pnj_Clase = _clase;
                    pnj.Pnj_Nivel = nivel;
                    pnj.Pnj_Alineamiento = _alineam;
                    pnj.Pnj_Arma = _arma;
                    pnj.Pnj_Armadura = _armadura;
                    pnj.Pnj_Escudo = _escudo;
                    pnj.Pnj_CA_Neg = ca;
                    pnj.Pnj_CA_Pos = caPos;
                    pnj.Pnj_Vida_Med = vidaMediaGuerrero;
                    pnj.Pnj_Vida_Max = vidaMaxGuerrero;
                    pnj.Pnj_Ataque_Arma = _atqArma;
                    pnj.Pnj_Ataque = atq;
                    pnj.Pnj_S_Veneno = salvacionVeneno;
                    pnj.Pnj_S_Varitas = salvacionVaritas;
                    pnj.Pnj_S_Petrif = salvacionPetrif;
                    pnj.Pnj_S_AliDrag = salvacionAliDrag;
                    pnj.Pnj_S_Sorti = salvacionSorti;
                    pnj.Pnj_PX = valorPX;
                    pnj.Pnj_Mov = movimientoGuerrero;
                    pnj.Pnj_Tesoro = tesoro;
                    pnj.Pnj_Texto = texto;
                    pnj.Pnj_Ruta = _ruta;

                    mordorctxt.Pnj.InsertOnSubmit(pnj);
                }

                mordorctxt.Connection.Close();
            }
 
        }

        public void mostrarPnj(string _nombrecb, Label _nombre, Label _clase, Label _nivel, Label _aline, Label _vida, Label _ca,
                               Label _px, Label _mov, Label _tesoro, Label _arma, Label _veneno,
                               Label _varitas, Label _petrif, Label _aliDrag, Label _sorti, PictureBox _imagen, Label _texto)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var pnjs = from pnj in mordorctxt.Pnj
                       where pnj.Pnj_Nombre.Contains(_nombrecb)
                       select pnj;

            foreach (var pnj in pnjs)
            {
                _nombre.Text = pnj.Pnj_Nombre;
                _clase.Text = pnj.Pnj_Clase;
                _nivel.Text = pnj.Pnj_Nivel.ToString();
                _aline.Text = pnj.Pnj_Alineamiento;
                _vida.Text = pnj.Pnj_Vida_Med.ToString();
                _ca.Text = pnj.Pnj_CA_Neg.ToString();
                _px.Text = pnj.Pnj_PX.ToString();
                _mov.Text = pnj.Pnj_Mov.ToString();
                _tesoro.Text = pnj.Pnj_Tesoro.ToString();
                _arma.Text = pnj.Pnj_Arma;
                _veneno.Text = pnj.Pnj_S_Veneno.ToString();
                _varitas.Text = pnj.Pnj_S_Varitas.ToString();
                _petrif.Text = pnj.Pnj_S_Petrif.ToString();
                _aliDrag.Text = pnj.Pnj_S_AliDrag.ToString();
                _sorti.Text = pnj.Pnj_S_Sorti.ToString();
                _texto.Text = pnj.Pnj_Texto;
                _imagen.ImageLocation = pnj.Pnj_Ruta;
            }

            mordorctxt.Connection.Close();
        }

        public string obtenerCA(string _armaduraNombre)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var armadurasCA = from armadura in mordorctxt.Armaduras
                              where armadura.Armadura_Nombre.Contains(_armaduraNombre)
                              select armadura.Armadura_CA;

            mordorctxt.Connection.Close();

            return armadurasCA.ToString();
        }

        public string obtenerAtqArma(string _armaNombre)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var armaDanio = from arma in mordorctxt.Armas
                            where arma.Arma_Nombre.Contains(_armaNombre)
                            select arma.Arma_Danio;

            mordorctxt.Connection.Close();

            return armaDanio.ToString();
        }

        public void llenarComboPnj(ComboBox _Combo)
        {
            MordorContext mordorCtxt = new MordorContext(conexion);

            var todosPnj = from pnj in mordorCtxt.Pnj select pnj.Pnj_Nombre;

            _Combo.DataSource = todosPnj;

            mordorCtxt.Connection.Close();
        }
    }
}
