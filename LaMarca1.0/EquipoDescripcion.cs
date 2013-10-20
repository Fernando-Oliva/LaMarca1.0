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
    public partial class EquipoDescripcion : Form
    {
        public EquipoDescripcion(string celda0,int fila)
        {
            InitializeComponent();
            //colocamos el nombre en la ventana
            if (fila == 0)
            {
                this.Text = celda0;
                Clases.DescripcionesEquipocs description = new Clases.DescripcionesEquipocs();

                //(description.equipo(celda0,tbDescripcion);
            }
            else if (fila == 2)
            {
                this.Text = celda0;
                Clases.DescripcionesEquipocs description = new Clases.DescripcionesEquipocs();

                description.equipo(celda0, tbDescripcion, pbEquipo);
            }
        }

 
    }
}
