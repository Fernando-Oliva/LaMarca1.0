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
    public partial class Localizacion : Form
    {
        public Localizacion(string _lugar)
        {
            Clases.EnlaceLocalizacionees lugares = new Clases.EnlaceLocalizacionees();
            string nombreLugar;

            InitializeComponent();

            if (_lugar == "pRobleda")
            {
                nombreLugar = "Robleda";
                this.Text = nombreLugar;
                lugares.abrirLocalizacion(nombreLugar, pbImagenLugar, tbDescripcionLugar, lNombreLugar);
                
            }
            else if (_lugar == "pPuertaNegra")
            {
                nombreLugar = "La Puerta Negra";
                this.Text = nombreLugar;
                lugares.abrirLocalizacion(nombreLugar, pbImagenLugar, tbDescripcionLugar, lNombreLugar);
            }
        }
    }
}
