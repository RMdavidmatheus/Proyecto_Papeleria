using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Visual.Vistas
{
    public partial class Lista_proveedores : Form
    {
        public Lista_proveedores()
        {
            InitializeComponent();
            Tabla_Proveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        Capa_Logica.Metodos Metodos = new Capa_Logica.Metodos();

        private void Lista_proveedores_Load(object sender, EventArgs e)
        {
            Metodos.Llenar_DataGrid(Tabla_Proveedores);
        }
    }
}
