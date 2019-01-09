using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Capa_Logica
{
    class Conexion_SQL_SERVER
    {
        private SqlConnection Conexion_SQL = new SqlConnection("Server=(local);DataBase= Papeleria;Integrated Security=true");

        public SqlConnection Conectar()
        {
            if (Conexion_SQL.State == ConnectionState.Closed)
            {
                Conexion_SQL.Open();
            }
            return Conexion_SQL;
        }

        public SqlConnection Desconectar()
        {
            if (Conexion_SQL.State==ConnectionState.Open)
            {
                Conexion_SQL.Close();
            }
            return Conexion_SQL;
        }
    }
}
