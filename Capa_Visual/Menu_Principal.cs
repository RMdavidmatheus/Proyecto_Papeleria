using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Visual
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            Seleccion.Hide();
        }

        Capa_Logica.Metodos Metodos = new Capa_Logica.Metodos();

        // METODO MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN METODO MOVER PANTALLA

        private int LX, LY; 

        private void Proveedores_Click(object sender, EventArgs e)
        {
            Metodos.Llenar_Panel(Panel_Contenido,new Vistas.Lista_proveedores());
            Titulo.Text = Proveedores.Text;
            if (Seleccion.Visible == true)
            {
                Seleccion.Height = Proveedores.Height;
                Seleccion.Top = Proveedores.Top;
            }
            else
            {
                Seleccion.Show();
                Seleccion.Height = Proveedores.Height;
                Seleccion.Top = Proveedores.Top;
            }
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Titulo.Text = Clientes.Text;
            if (Seleccion.Visible==true)
            {
            Seleccion.Height = Clientes.Height;
            Seleccion.Top = Clientes.Top;
            }
            else
            {
                Seleccion.Show();
                Seleccion.Height = Clientes.Height;
                Seleccion.Top = Clientes.Top;
            }
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            Titulo.Text = Ventas.Text;

            if (Seleccion.Visible == true)
            {
                Seleccion.Height = Ventas.Height;
                Seleccion.Top = Ventas.Top;
            }
            else
            {
                Seleccion.Show();
                Seleccion.Height = Ventas.Height;
                Seleccion.Top = Ventas.Top;
            }
        }

        private void Menu_Slide_Click_1(object sender, EventArgs e)
        {
            if (Panel_Menu.Width == 60)
            {
                Panel_Menu.Visible = false;
                Panel_Menu.Width = 259;
                Panel_Animacion.ShowSync(Panel_Menu);
                Panel_Animacion.ShowSync(Menu_Slide);
                Logo_Hide.ShowSync(Logo);
            }
            else
            {
                Logo_Hide.Hide(Logo);
                Panel_Menu.Visible = false;
                Panel_Menu.Width = 60;
                Panel_Animacion.ShowSync(Panel_Menu);
                Panel_Animacion.ShowSync(Menu_Slide);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            this.Size = new Size(1280, 720);
            this.Location = new Point(LX, LY);
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }
    }
}
