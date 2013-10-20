using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaMarva1._0.Clases
{
    class DescripcionesEquipocs
    {
        public void equipo(string nombre,TextBox descripcion, PictureBox imagen)
        {
            if(nombre == "Agua Bendita (frasco)")
            {
                descripcion.Text = "Se trata de agua normal pero que ha sido bendecida por un clerigo. Se utiliza en rituales liturgicos y es un arma eficaz contra no-muertos";
                imagen.ImageLocation = @"C:\Users\Fernando\Documents\Visual Studio 2010\Projects\LaMarca1.0\LaMarca1.0\Imagenes API\Aguabendita.png";
            }
        }
    }
}
