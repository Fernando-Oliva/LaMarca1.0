using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Configuration;

namespace LaMarva1._0.Clases
{
    class DBConnectionTienda
    {
        #region declaraciones
            SqlCeCommand comando;
            SqlCeDataReader valores;
            string _consulta;
            int f;
            int i;
            int j;
            int x;
            int w;
            int k;
            int n;
            int t;
            SqlCeConnection conexion = new SqlCeConnection(ConfigurationManager.ConnectionStrings["LaMarva1._0.Properties.Settings.MordorConnectionString"].ToString());
        #endregion

        public void llenarGridArmas(DataGridView dgvArmasReceived)
        {
            f = 0;
            _consulta = "select Arma_Nombre, Arma_Coste, Arma_Danio, Arma_Peso from Armas";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvArmasReceived.Rows.Add();
                dgvArmasReceived[0, f].Value = valores["Arma_Nombre"].ToString();
                dgvArmasReceived[1, f].Value = valores["Arma_Coste"].ToString();
                dgvArmasReceived[2, f].Value = valores["Arma_Danio"].ToString();
                dgvArmasReceived[3, f].Value = valores["Arma_Peso"].ToString();

                f = f + 1;
            }
            conexion.Close();
        }

        public void busquedaArmas(string nombreArma, DataGridView dgvBusquedaArmas)
        {
            w = 0;
           
            _consulta = "select * from Armas where Arma_Nombre like '" + nombreArma + "%'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvBusquedaArmas.Rows.Add();
                dgvBusquedaArmas[0, w].Value = valores["Arma_Nombre"].ToString();
                dgvBusquedaArmas[1, w].Value = valores["Arma_Coste"].ToString();
                dgvBusquedaArmas[2, w].Value = valores["Arma_Danio"].ToString();
                dgvBusquedaArmas[3, w].Value = valores["Arma_Peso"].ToString();

                w = w + 1;
            }
            conexion.Close();
        }

        public void llenarGridArmaduras(DataGridView dgvArmadurasReceived)
        {
            i = 0;
            _consulta = "select Armadura_Nombre, Armadura_Coste, Armadura_CA, Armadura_Peso from Armaduras";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvArmadurasReceived.Rows.Add();
                dgvArmadurasReceived[0, i].Value = valores["Armadura_Nombre"].ToString();
                dgvArmadurasReceived[1, i].Value = valores["Armadura_Coste"].ToString();
                dgvArmadurasReceived[2, i].Value = valores["Armadura_CA"].ToString();
                dgvArmadurasReceived[3, i].Value = valores["Armadura_Peso"].ToString();

                i = i + 1;
            }
            conexion.Close();
        }

        public void busquedaArmaduras(string nombreArmadura, DataGridView dgvBusquedaArmaduras)
        {
            k = 0;
           
            _consulta = "select * from Armaduras where Armadura_Nombre like '" + nombreArmadura + "%'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvBusquedaArmaduras.Rows.Add();
                dgvBusquedaArmaduras[0, k].Value = valores["Armadura_Nombre"].ToString();
                dgvBusquedaArmaduras[1, k].Value = valores["Armadura_Coste"].ToString();
                dgvBusquedaArmaduras[2, k].Value = valores["Armadura_CA"].ToString();
                dgvBusquedaArmaduras[3, k].Value = valores["Armadura_Peso"].ToString();

                k = k + 1;
            }
            conexion.Close();
        }

        public void llenarGridEquipo(DataGridView dgvEquipoReceived)
        {
            j = 0;
            _consulta = "select Equipo_Nombre, Equipo_Coste, Equipo_Peso from Equipo";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvEquipoReceived.Rows.Add();
                dgvEquipoReceived[0, j].Value = valores["Equipo_Nombre"].ToString();
                dgvEquipoReceived[1, j].Value = valores["Equipo_Coste"].ToString();
                dgvEquipoReceived[2, j].Value = valores["Equipo_Peso"].ToString();

                j = j + 1;
            }
            conexion.Close();
        }

        public void busquedaEquipo(string nombreEquipo, DataGridView dgvBusquedaEquipo)
        {
            n = 0;

            _consulta = "select * from Equipo where Equipo_Nombre like '" + nombreEquipo + "%'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvBusquedaEquipo.Rows.Add();
                dgvBusquedaEquipo[0, n].Value = valores["Equipo_Nombre"].ToString();
                dgvBusquedaEquipo[1, n].Value = valores["Equipo_Coste"].ToString();
                dgvBusquedaEquipo[2, n].Value = valores["Equipo_Peso"].ToString();

                n = n + 1;
            }
            conexion.Close();
        }

        public void llenarGridTransporte(DataGridView dgvTransporteReceived)
        {
            x = 0;
            _consulta = "select Transporte_Nombre, Transporte_Coste from Transporte";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvTransporteReceived.Rows.Add();
                dgvTransporteReceived[0, x].Value = valores["Transporte_Nombre"].ToString();
                dgvTransporteReceived[1, x].Value = valores["Transporte_Coste"].ToString();

                x = x + 1;
            }
            conexion.Close();
        }

        public void busquedaTransporte(string nombreTransporte, DataGridView dgvBusquedaTransporte)
        {
            t = 0;

            _consulta = "select * from Transporte where Transporte_Nombre like '" + nombreTransporte + "%'";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvBusquedaTransporte.Rows.Add();
                dgvBusquedaTransporte[0, t].Value = valores["Transporte_Nombre"].ToString();
                dgvBusquedaTransporte[1, t].Value = valores["Transporte_Coste"].ToString();

                t = t + 1;
            }
            conexion.Close();
        }
    }
}
