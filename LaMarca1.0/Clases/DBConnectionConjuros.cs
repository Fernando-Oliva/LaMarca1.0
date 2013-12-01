using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Configuration;

namespace LaMarva1._0.Clases
{
    class DBConnectionConjuros
    {
        #region Declaraciones
        SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["LaMarva1._0.Properties.Settings.MordorConnectionString"].ToString());
        #endregion

        public void llenarArcanos(DataGridView dgvReceived)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var arcanos = from arcano in mordorctxt.ConjurosArcanos
                          select arcano;

            dgvReceived.DataSource = arcanos;

            mordorctxt.Connection.Close();
        }

        public void llenarDivinos(DataGridView dgvReceived)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var divinos = from divino in mordorctxt.ConjurosDivinos
                          select divino;

            dgvReceived.DataSource = divinos;

            mordorctxt.Connection.Close();
        }
    }
}
