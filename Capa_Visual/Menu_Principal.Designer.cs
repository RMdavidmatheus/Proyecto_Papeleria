namespace Capa_Visual
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.Contorno_App = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Todo = new System.Windows.Forms.Panel();
            this.Panel_Contenido = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Seleccion = new System.Windows.Forms.Panel();
            this.Menu_Slide = new Bunifu.Framework.UI.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Proveedores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_Herramientas = new System.Windows.Forms.Panel();
            this.Restaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Maximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.Panel_Animacion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Logo_Hide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Panel_Todo.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Slide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panel_Herramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Contorno_App
            // 
            this.Contorno_App.ElipseRadius = 6;
            this.Contorno_App.TargetControl = this;
            // 
            // Panel_Todo
            // 
            this.Panel_Todo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Todo.Controls.Add(this.Panel_Contenido);
            this.Panel_Todo.Controls.Add(this.Panel_Menu);
            this.Panel_Todo.Controls.Add(this.Panel_Herramientas);
            this.Logo_Hide.SetDecoration(this.Panel_Todo, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Panel_Todo, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Todo.Location = new System.Drawing.Point(-2, 0);
            this.Panel_Todo.Name = "Panel_Todo";
            this.Panel_Todo.Size = new System.Drawing.Size(1283, 724);
            this.Panel_Todo.TabIndex = 0;
            // 
            // Panel_Contenido
            // 
            this.Panel_Contenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo_Hide.SetDecoration(this.Panel_Contenido, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Panel_Contenido, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Contenido.Location = new System.Drawing.Point(265, 51);
            this.Panel_Contenido.Name = "Panel_Contenido";
            this.Panel_Contenido.Size = new System.Drawing.Size(1018, 670);
            this.Panel_Contenido.TabIndex = 2;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Panel_Menu.Controls.Add(this.Seleccion);
            this.Panel_Menu.Controls.Add(this.Menu_Slide);
            this.Panel_Menu.Controls.Add(this.Logo);
            this.Panel_Menu.Controls.Add(this.Ventas);
            this.Panel_Menu.Controls.Add(this.Clientes);
            this.Panel_Menu.Controls.Add(this.Proveedores);
            this.Logo_Hide.SetDecoration(this.Panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Menu.Location = new System.Drawing.Point(0, 51);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(259, 670);
            this.Panel_Menu.TabIndex = 1;
            // 
            // Seleccion
            // 
            this.Seleccion.BackColor = System.Drawing.Color.Aqua;
            this.Logo_Hide.SetDecoration(this.Seleccion, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Seleccion, BunifuAnimatorNS.DecorationType.None);
            this.Seleccion.Location = new System.Drawing.Point(0, 222);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(13, 71);
            this.Seleccion.TabIndex = 5;
            // 
            // Menu_Slide
            // 
            this.Menu_Slide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Logo_Hide.SetDecoration(this.Menu_Slide, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Menu_Slide, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Slide.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Slide.Image")));
            this.Menu_Slide.ImageActive = null;
            this.Menu_Slide.Location = new System.Drawing.Point(216, 167);
            this.Menu_Slide.Name = "Menu_Slide";
            this.Menu_Slide.Size = new System.Drawing.Size(31, 51);
            this.Menu_Slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu_Slide.TabIndex = 4;
            this.Menu_Slide.TabStop = false;
            this.Menu_Slide.Zoom = 10;
            this.Menu_Slide.Click += new System.EventHandler(this.Menu_Slide_Click_1);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Animacion.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Hide.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 21);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(256, 134);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Ventas
            // 
            this.Ventas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ventas.BorderRadius = 0;
            this.Ventas.ButtonText = " Ventas";
            this.Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animacion.SetDecoration(this.Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Hide.SetDecoration(this.Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Ventas.DisabledColor = System.Drawing.Color.Gray;
            this.Ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.Ventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Ventas.Iconimage")));
            this.Ventas.Iconimage_right = null;
            this.Ventas.Iconimage_right_Selected = null;
            this.Ventas.Iconimage_Selected = null;
            this.Ventas.IconMarginLeft = 0;
            this.Ventas.IconMarginRight = 0;
            this.Ventas.IconRightVisible = true;
            this.Ventas.IconRightZoom = 0D;
            this.Ventas.IconVisible = true;
            this.Ventas.IconZoom = 60D;
            this.Ventas.IsTab = false;
            this.Ventas.Location = new System.Drawing.Point(0, 371);
            this.Ventas.Name = "Ventas";
            this.Ventas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Ventas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(193)))), ((int)(((byte)(186)))));
            this.Ventas.OnHoverTextColor = System.Drawing.Color.White;
            this.Ventas.selected = false;
            this.Ventas.Size = new System.Drawing.Size(262, 65);
            this.Ventas.TabIndex = 2;
            this.Ventas.Text = " Ventas";
            this.Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.Textcolor = System.Drawing.Color.White;
            this.Ventas.TextFont = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Clientes
            // 
            this.Clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clientes.BorderRadius = 0;
            this.Clientes.ButtonText = " Clientes";
            this.Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animacion.SetDecoration(this.Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Hide.SetDecoration(this.Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Clientes.DisabledColor = System.Drawing.Color.Gray;
            this.Clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.Clientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("Clientes.Iconimage")));
            this.Clientes.Iconimage_right = null;
            this.Clientes.Iconimage_right_Selected = null;
            this.Clientes.Iconimage_Selected = null;
            this.Clientes.IconMarginLeft = 0;
            this.Clientes.IconMarginRight = 0;
            this.Clientes.IconRightVisible = true;
            this.Clientes.IconRightZoom = 0D;
            this.Clientes.IconVisible = true;
            this.Clientes.IconZoom = 60D;
            this.Clientes.IsTab = false;
            this.Clientes.Location = new System.Drawing.Point(0, 300);
            this.Clientes.Name = "Clientes";
            this.Clientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(193)))), ((int)(((byte)(186)))));
            this.Clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.Clientes.selected = false;
            this.Clientes.Size = new System.Drawing.Size(262, 65);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = " Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Textcolor = System.Drawing.Color.White;
            this.Clientes.TextFont = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.Proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proveedores.BorderRadius = 0;
            this.Proveedores.ButtonText = " Proveedores";
            this.Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animacion.SetDecoration(this.Proveedores, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Hide.SetDecoration(this.Proveedores, BunifuAnimatorNS.DecorationType.None);
            this.Proveedores.DisabledColor = System.Drawing.Color.Gray;
            this.Proveedores.Iconcolor = System.Drawing.Color.Transparent;
            this.Proveedores.Iconimage = ((System.Drawing.Image)(resources.GetObject("Proveedores.Iconimage")));
            this.Proveedores.Iconimage_right = null;
            this.Proveedores.Iconimage_right_Selected = null;
            this.Proveedores.Iconimage_Selected = null;
            this.Proveedores.IconMarginLeft = 0;
            this.Proveedores.IconMarginRight = 0;
            this.Proveedores.IconRightVisible = true;
            this.Proveedores.IconRightZoom = 0D;
            this.Proveedores.IconVisible = true;
            this.Proveedores.IconZoom = 60D;
            this.Proveedores.IsTab = false;
            this.Proveedores.Location = new System.Drawing.Point(0, 229);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.Proveedores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(193)))), ((int)(((byte)(186)))));
            this.Proveedores.OnHoverTextColor = System.Drawing.Color.White;
            this.Proveedores.selected = false;
            this.Proveedores.Size = new System.Drawing.Size(262, 65);
            this.Proveedores.TabIndex = 0;
            this.Proveedores.Text = " Proveedores";
            this.Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proveedores.Textcolor = System.Drawing.Color.White;
            this.Proveedores.TextFont = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // Panel_Herramientas
            // 
            this.Panel_Herramientas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Herramientas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Panel_Herramientas.Controls.Add(this.Maximizar);
            this.Panel_Herramientas.Controls.Add(this.Minimizar);
            this.Panel_Herramientas.Controls.Add(this.pictureBox1);
            this.Panel_Herramientas.Controls.Add(this.Cerrar);
            this.Panel_Herramientas.Controls.Add(this.Titulo);
            this.Panel_Herramientas.Controls.Add(this.Restaurar);
            this.Logo_Hide.SetDecoration(this.Panel_Herramientas, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Panel_Herramientas, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Herramientas.Location = new System.Drawing.Point(0, 0);
            this.Panel_Herramientas.Name = "Panel_Herramientas";
            this.Panel_Herramientas.Size = new System.Drawing.Size(1283, 52);
            this.Panel_Herramientas.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Logo_Hide.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.ImageActive = null;
            this.Restaurar.Location = new System.Drawing.Point(1188, 6);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(37, 40);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Zoom = 10;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Logo_Hide.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.ImageActive = null;
            this.Minimizar.Location = new System.Drawing.Point(1145, 5);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(37, 40);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Zoom = 10;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Logo_Hide.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.ImageActive = null;
            this.Maximizar.Location = new System.Drawing.Point(1188, 5);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(37, 40);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Zoom = 10;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // pictureBox1
            // 
            this.Panel_Animacion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Hide.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Logo_Hide.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageActive = null;
            this.Cerrar.Location = new System.Drawing.Point(1231, 5);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(37, 40);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 1;
            this.Cerrar.TabStop = false;
            this.Cerrar.Zoom = 10;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Panel_Animacion.SetDecoration(this.Titulo, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Hide.SetDecoration(this.Titulo, BunifuAnimatorNS.DecorationType.None);
            this.Titulo.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(276, 3);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(254, 43);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = " Menu principal";
            // 
            // Panel_Animacion
            // 
            this.Panel_Animacion.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.Panel_Animacion.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Panel_Animacion.DefaultAnimation = animation2;
            // 
            // Logo_Hide
            // 
            this.Logo_Hide.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Logo_Hide.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Logo_Hide.DefaultAnimation = animation1;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Panel_Todo);
            this.Logo_Hide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animacion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Panel_Todo.ResumeLayout(false);
            this.Panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Slide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panel_Herramientas.ResumeLayout(false);
            this.Panel_Herramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Contorno_App;
        private System.Windows.Forms.Panel Panel_Todo;
        private System.Windows.Forms.Panel Panel_Contenido;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Herramientas;
        private System.Windows.Forms.Label Titulo;
        private Bunifu.Framework.UI.BunifuFlatButton Proveedores;
        private Bunifu.Framework.UI.BunifuFlatButton Clientes;
        private Bunifu.Framework.UI.BunifuFlatButton Ventas;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuImageButton Menu_Slide;
        private System.Windows.Forms.Panel Seleccion;
        private BunifuAnimatorNS.BunifuTransition Panel_Animacion;
        private BunifuAnimatorNS.BunifuTransition Logo_Hide;
        private Bunifu.Framework.UI.BunifuImageButton Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton Maximizar;
        private Bunifu.Framework.UI.BunifuImageButton Minimizar;
        private Bunifu.Framework.UI.BunifuImageButton Restaurar;
    }
}

