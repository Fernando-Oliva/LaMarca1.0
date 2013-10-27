using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaMarva1._0.Clases
{
    class EnlaceLocalizacionees
    {
        
        public void abrirLocalizacion(string  _lugar, PictureBox _imagen, TextBox _descripcion, Label _nombre)
        {
            Clases.Textos descripcionLugar = new Textos();
        
            if (_lugar == "Robleda")
            {
                _nombre.Text = "- " + _lugar + " -";
                _imagen.Image = LaMarva1._0.Properties.Resources.RobledaMap;
                _descripcion.Text = descripcionLugar.descripcionRobleda();
            }
            else if (_lugar == "La Puerta Negra")
            {
                _nombre.Text = "- " + _lugar + " -";
                _imagen.Image = LaMarva1._0.Properties.Resources.La_Puerta_Negra;
                _descripcion.Text = descripcionLugar.descripcionPuertaNegra();
                
            }
        }
    }
}
