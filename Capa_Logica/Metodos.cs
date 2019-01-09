using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Logica
{
    public class Metodos
    {
        private Conexion_SQL_SERVER Conectar = new Conexion_SQL_SERVER();
        
        public void Llenar_Panel(Panel Panel_Receptor,object Formulario)
        {
            if (Panel_Receptor.Controls.Count >= 0)
            {
                Panel_Receptor.Controls.Clear();
                Form son_form = Formulario as Form;

                if (son_form.Visible==true)
                {
                    son_form.BringToFront();
                }
                else
                {
                    son_form.TopLevel = false;
                    son_form.Dock = DockStyle.Fill;
                    Panel_Receptor.Controls.Add(son_form);
                    Panel_Receptor.Tag = son_form;
                    son_form.Show();
                }
            }
        }
        public void Llenar_DataGrid(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("Select * from Proveedores",Conectar.Conectar());
                SqlDataAdapter rs = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt; 
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error al llenar la tabla proveedores "+e.Message);
            }
            Conectar.Desconectar();
        }
    }
}
