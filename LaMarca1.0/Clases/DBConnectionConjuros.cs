using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace LaMarva1._0.Clases
{
    class DBConnectionConjuros
    {
        #region Declaraciones
        SqlCeCommand comando;
        SqlCeDataReader valores;
        string _consulta;
        int f;
        SqlCeConnection conexion = new SqlCeConnection(DBConnectionConfig.dbConnection);

        #endregion

        public void llenarArcanos(DataGridView dgvReceived)
        {
            f = 0;
            _consulta = "select C_Arcano_Nivel, C_Arcano_Nombre, C_Arcano_Alcance, C_Arcano_Duracion, C_Arcano_Descripcion from ConjurosArcanos";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvReceived.Rows.Add();
                dgvReceived[0, f].Value = valores["C_Arcano_Nivel"].ToString();
                dgvReceived[1, f].Value = valores["C_Arcano_Nombre"].ToString();
                dgvReceived[2, f].Value = valores["C_Arcano_Alcance"].ToString();
                dgvReceived[3, f].Value = valores["C_Arcano_Duracion"].ToString();
                dgvReceived[4, f].Value = valores["C_Arcano_Descripcion"].ToString();

                f = f + 1;
            }
            conexion.Close();
        }

        public void llenarDivinos(DataGridView dgvReceived)
        {
            f = 0;
            _consulta = "select C_Divino_Nivel, C_Divino_Nombre, C_Divino_Alcance, C_Divino_Duracion, C_Divino_Descripcion from ConjurosDivinos";
            comando = new SqlCeCommand(_consulta, conexion);

            conexion.Open();

            valores = comando.ExecuteReader();

            while (valores.Read())
            {
                dgvReceived.Rows.Add();
                dgvReceived[0, f].Value = valores["C_Divino_Nivel"].ToString();
                dgvReceived[1, f].Value = valores["C_Divino_Nombre"].ToString();
                dgvReceived[2, f].Value = valores["C_Divino_Alcance"].ToString();
                dgvReceived[3, f].Value = valores["C_Divino_Duracion"].ToString();
                dgvReceived[4, f].Value = valores["C_Divino_Descripcion"].ToString();

                f = f + 1;
            }
            conexion.Close();
        }
    }
}
