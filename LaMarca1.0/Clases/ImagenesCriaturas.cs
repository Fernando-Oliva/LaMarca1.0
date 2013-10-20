using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaMarva1._0.Clases
{
    class ImagenesCriaturas
    {
        public void colocarImagen(string _nombre, PictureBox imagen)
        {
            if(_nombre == "Aboleth")
            {
                imagen.Image = LaMarva1._0.Properties.Resources.Aboleth;
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (_nombre == "Ankheg")
            {
                imagen.Image = LaMarva1._0.Properties.Resources.Ankheg;
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
