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
    class DBConnectionTienda
    {
        #region declaraciones
            SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["LaMarva1._0.Properties.Settings.MordorConnectionString"].ToString());
        #endregion

        public void llenarGridArmas(DataGridView dgvArmasReceived)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var todasArmas = from arma in mordorctxt.Armas select arma;

            dgvArmasReceived.DataSource = todasArmas;

            mordorctxt.Connection.Close();
        }

        public void busquedaArmas(string nombreArma, DataGridView dgvBusquedaArmas)
        {

            MordorContext mordorctxt = new MordorContext(conexion);

            var armasFilter = from arma in mordorctxt.Armas
                              where arma.Arma_Nombre.Contains(nombreArma)
                              select arma;

            dgvBusquedaArmas.DataSource = armasFilter;

            mordorctxt.Connection.Close();
        }

        public void llenarGridArmaduras(DataGridView dgvArmadurasReceived)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var todasArmaduras = from armadura in mordorctxt.Armaduras
                                 select armadura;

            dgvArmadurasReceived.DataSource = todasArmaduras;

            mordorctxt.Connection.Close();
        }

        public void busquedaArmaduras(string nombreArmadura, DataGridView dgvBusquedaArmaduras)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var armadurasFilter = from armadura in mordorctxt.Armaduras
                                  where armadura.Armadura_Nombre.Contains(nombreArmadura)
                                  select armadura;

            dgvBusquedaArmaduras.DataSource = armadurasFilter;

            mordorctxt.Connection.Close();
        }

        public void llenarGridEquipo(DataGridView dgvEquipoReceived)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var equipoTodos = from equipo in mordorctxt.Equipo
                              select equipo;

            dgvEquipoReceived.DataSource = equipoTodos;

            mordorctxt.Connection.Close();
        }

        public void busquedaEquipo(string nombreEquipo, DataGridView dgvBusquedaEquipo)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var equipoFilter = from equipo in mordorctxt.Equipo
                               where equipo.Equipo_Nombre.Contains(nombreEquipo)
                               select equipo;

            dgvBusquedaEquipo.DataSource = equipoFilter;

            mordorctxt.Connection.Close();
        }

        public void llenarGridTransporte(DataGridView dgvTransporteReceived)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var transporteTodos = from transporte in mordorctxt.Transporte
                                  select transporte;

            dgvTransporteReceived.DataSource = transporteTodos;

            mordorctxt.Connection.Close();
        }

        public void busquedaTransporte(string nombreTransporte, DataGridView dgvBusquedaTransporte)
        {
            MordorContext mordorctxt = new MordorContext(conexion);

            var transporteFilter = from transporte in mordorctxt.Transporte
                                   where transporte.Transporte_Nombre.Contains(nombreTransporte)
                                   select transporte;

            dgvBusquedaTransporte.DataSource = transporteFilter;

            mordorctxt.Connection.Close();
        }
    }
}
