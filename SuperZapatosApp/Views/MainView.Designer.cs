namespace SuperZapatosApp
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            panelArticulosSubMenu = new Panel();
            BtnEditarArticulo = new Button();
            btnAgregarArticulo = new Button();
            btnFiltrarArticulos = new Button();
            btnTodosArticulos = new Button();
            btnArticulosSubMenu = new Button();
            panelTiendasSubMenu = new Panel();
            btnEditarTienda = new Button();
            btnAgregarTienda = new Button();
            btnTiendas = new Button();
            btnTiendasSubMenu = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            panelContainerChild = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelArticulosSubMenu.SuspendLayout();
            panelTiendasSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = SystemColors.Desktop;
            panelSideMenu.BorderStyle = BorderStyle.Fixed3D;
            panelSideMenu.Controls.Add(panelArticulosSubMenu);
            panelSideMenu.Controls.Add(btnArticulosSubMenu);
            panelSideMenu.Controls.Add(panelTiendasSubMenu);
            panelSideMenu.Controls.Add(btnTiendasSubMenu);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 553);
            panelSideMenu.TabIndex = 0;
            // 
            // panelArticulosSubMenu
            // 
            panelArticulosSubMenu.BackColor = Color.DarkSlateGray;
            panelArticulosSubMenu.Controls.Add(BtnEditarArticulo);
            panelArticulosSubMenu.Controls.Add(btnAgregarArticulo);
            panelArticulosSubMenu.Controls.Add(btnFiltrarArticulos);
            panelArticulosSubMenu.Controls.Add(btnTodosArticulos);
            panelArticulosSubMenu.Dock = DockStyle.Top;
            panelArticulosSubMenu.Location = new Point(0, 353);
            panelArticulosSubMenu.Name = "panelArticulosSubMenu";
            panelArticulosSubMenu.Size = new Size(246, 160);
            panelArticulosSubMenu.TabIndex = 4;
            // 
            // BtnEditarArticulo
            // 
            BtnEditarArticulo.BackColor = Color.DarkSlateGray;
            BtnEditarArticulo.Dock = DockStyle.Top;
            BtnEditarArticulo.FlatAppearance.BorderSize = 0;
            BtnEditarArticulo.FlatStyle = FlatStyle.Flat;
            BtnEditarArticulo.ForeColor = SystemColors.Info;
            BtnEditarArticulo.Location = new Point(0, 120);
            BtnEditarArticulo.Name = "BtnEditarArticulo";
            BtnEditarArticulo.Padding = new Padding(35, 0, 0, 0);
            BtnEditarArticulo.Size = new Size(246, 40);
            BtnEditarArticulo.TabIndex = 3;
            BtnEditarArticulo.Text = "Editar Articulo";
            BtnEditarArticulo.TextAlign = ContentAlignment.MiddleLeft;
            BtnEditarArticulo.UseVisualStyleBackColor = false;
            BtnEditarArticulo.Click += BtnEditarArticulo_Click;
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.BackColor = Color.DarkSlateGray;
            btnAgregarArticulo.Dock = DockStyle.Top;
            btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            btnAgregarArticulo.FlatStyle = FlatStyle.Flat;
            btnAgregarArticulo.ForeColor = SystemColors.Info;
            btnAgregarArticulo.Location = new Point(0, 80);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Padding = new Padding(35, 0, 0, 0);
            btnAgregarArticulo.Size = new Size(246, 40);
            btnAgregarArticulo.TabIndex = 2;
            btnAgregarArticulo.Text = "Agregar Articulo";
            btnAgregarArticulo.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarArticulo.UseVisualStyleBackColor = false;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click;
            // 
            // btnFiltrarArticulos
            // 
            btnFiltrarArticulos.BackColor = Color.DarkSlateGray;
            btnFiltrarArticulos.Dock = DockStyle.Top;
            btnFiltrarArticulos.FlatAppearance.BorderSize = 0;
            btnFiltrarArticulos.FlatStyle = FlatStyle.Flat;
            btnFiltrarArticulos.ForeColor = SystemColors.Info;
            btnFiltrarArticulos.Location = new Point(0, 40);
            btnFiltrarArticulos.Name = "btnFiltrarArticulos";
            btnFiltrarArticulos.Padding = new Padding(35, 0, 0, 0);
            btnFiltrarArticulos.Size = new Size(246, 40);
            btnFiltrarArticulos.TabIndex = 1;
            btnFiltrarArticulos.Text = "Filtrar Articulos";
            btnFiltrarArticulos.TextAlign = ContentAlignment.MiddleLeft;
            btnFiltrarArticulos.UseVisualStyleBackColor = false;
            btnFiltrarArticulos.Click += btnFiltrarArticulos_Click;
            // 
            // btnTodosArticulos
            // 
            btnTodosArticulos.BackColor = Color.DarkSlateGray;
            btnTodosArticulos.Dock = DockStyle.Top;
            btnTodosArticulos.FlatAppearance.BorderSize = 0;
            btnTodosArticulos.FlatStyle = FlatStyle.Flat;
            btnTodosArticulos.ForeColor = SystemColors.Info;
            btnTodosArticulos.Location = new Point(0, 0);
            btnTodosArticulos.Name = "btnTodosArticulos";
            btnTodosArticulos.Padding = new Padding(35, 0, 0, 0);
            btnTodosArticulos.Size = new Size(246, 40);
            btnTodosArticulos.TabIndex = 0;
            btnTodosArticulos.Text = "Todos los articulos";
            btnTodosArticulos.TextAlign = ContentAlignment.MiddleLeft;
            btnTodosArticulos.UseVisualStyleBackColor = false;
            btnTodosArticulos.Click += btnTodosArticulos_Click;
            // 
            // btnArticulosSubMenu
            // 
            btnArticulosSubMenu.Dock = DockStyle.Top;
            btnArticulosSubMenu.FlatAppearance.BorderSize = 0;
            btnArticulosSubMenu.FlatStyle = FlatStyle.Flat;
            btnArticulosSubMenu.ForeColor = SystemColors.Info;
            btnArticulosSubMenu.Location = new Point(0, 308);
            btnArticulosSubMenu.Name = "btnArticulosSubMenu";
            btnArticulosSubMenu.Padding = new Padding(10, 0, 0, 0);
            btnArticulosSubMenu.Size = new Size(246, 45);
            btnArticulosSubMenu.TabIndex = 3;
            btnArticulosSubMenu.Text = "Articulos";
            btnArticulosSubMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnArticulosSubMenu.UseVisualStyleBackColor = true;
            btnArticulosSubMenu.Click += btnArticulosSubMenu_Click;
            // 
            // panelTiendasSubMenu
            // 
            panelTiendasSubMenu.BackColor = Color.DarkSlateGray;
            panelTiendasSubMenu.Controls.Add(btnEditarTienda);
            panelTiendasSubMenu.Controls.Add(btnAgregarTienda);
            panelTiendasSubMenu.Controls.Add(btnTiendas);
            panelTiendasSubMenu.Dock = DockStyle.Top;
            panelTiendasSubMenu.Location = new Point(0, 183);
            panelTiendasSubMenu.Name = "panelTiendasSubMenu";
            panelTiendasSubMenu.Size = new Size(246, 125);
            panelTiendasSubMenu.TabIndex = 2;
            // 
            // btnEditarTienda
            // 
            btnEditarTienda.BackColor = Color.DarkSlateGray;
            btnEditarTienda.Dock = DockStyle.Top;
            btnEditarTienda.FlatAppearance.BorderSize = 0;
            btnEditarTienda.FlatStyle = FlatStyle.Flat;
            btnEditarTienda.ForeColor = SystemColors.Info;
            btnEditarTienda.Location = new Point(0, 80);
            btnEditarTienda.Name = "btnEditarTienda";
            btnEditarTienda.Padding = new Padding(35, 0, 0, 0);
            btnEditarTienda.Size = new Size(246, 40);
            btnEditarTienda.TabIndex = 2;
            btnEditarTienda.Text = "Editar Tienda";
            btnEditarTienda.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarTienda.UseVisualStyleBackColor = false;
            btnEditarTienda.Click += btnEditarTienda_Click;
            // 
            // btnAgregarTienda
            // 
            btnAgregarTienda.BackColor = Color.DarkSlateGray;
            btnAgregarTienda.Dock = DockStyle.Top;
            btnAgregarTienda.FlatAppearance.BorderSize = 0;
            btnAgregarTienda.FlatStyle = FlatStyle.Flat;
            btnAgregarTienda.ForeColor = SystemColors.Info;
            btnAgregarTienda.Location = new Point(0, 40);
            btnAgregarTienda.Name = "btnAgregarTienda";
            btnAgregarTienda.Padding = new Padding(35, 0, 0, 0);
            btnAgregarTienda.Size = new Size(246, 40);
            btnAgregarTienda.TabIndex = 1;
            btnAgregarTienda.Text = "Agregar Tienda";
            btnAgregarTienda.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarTienda.UseVisualStyleBackColor = false;
            btnAgregarTienda.Click += btnAgregarTienda_Click;
            // 
            // btnTiendas
            // 
            btnTiendas.BackColor = Color.DarkSlateGray;
            btnTiendas.Dock = DockStyle.Top;
            btnTiendas.FlatAppearance.BorderSize = 0;
            btnTiendas.FlatStyle = FlatStyle.Flat;
            btnTiendas.ForeColor = SystemColors.Info;
            btnTiendas.Location = new Point(0, 0);
            btnTiendas.Name = "btnTiendas";
            btnTiendas.Padding = new Padding(35, 0, 0, 0);
            btnTiendas.Size = new Size(246, 40);
            btnTiendas.TabIndex = 0;
            btnTiendas.Text = "Todas las tiendas";
            btnTiendas.TextAlign = ContentAlignment.MiddleLeft;
            btnTiendas.UseVisualStyleBackColor = false;
            btnTiendas.Click += btnTiendas_Click;
            // 
            // btnTiendasSubMenu
            // 
            btnTiendasSubMenu.Dock = DockStyle.Top;
            btnTiendasSubMenu.FlatAppearance.BorderSize = 0;
            btnTiendasSubMenu.FlatStyle = FlatStyle.Flat;
            btnTiendasSubMenu.ForeColor = SystemColors.Info;
            btnTiendasSubMenu.Location = new Point(0, 138);
            btnTiendasSubMenu.Name = "btnTiendasSubMenu";
            btnTiendasSubMenu.Padding = new Padding(10, 0, 0, 0);
            btnTiendasSubMenu.Size = new Size(246, 45);
            btnTiendasSubMenu.TabIndex = 1;
            btnTiendasSubMenu.Text = "Tiendas";
            btnTiendasSubMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnTiendasSubMenu.UseVisualStyleBackColor = true;
            btnTiendasSubMenu.Click += btnTiendasSubMenu_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(246, 138);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.sz;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelContainerChild
            // 
            panelContainerChild.BackColor = Color.DarkSlateGray;
            panelContainerChild.Controls.Add(pictureBox1);
            panelContainerChild.Dock = DockStyle.Fill;
            panelContainerChild.Location = new Point(250, 0);
            panelContainerChild.Name = "panelContainerChild";
            panelContainerChild.Size = new Size(682, 553);
            panelContainerChild.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.sz;
            pictureBox1.Location = new Point(253, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(panelContainerChild);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainView";
            Text = "ADMINISTRACIÓN";
            panelSideMenu.ResumeLayout(false);
            panelArticulosSubMenu.ResumeLayout(false);
            panelTiendasSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContainerChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panelTiendasSubMenu;
        private Button btnTiendas;
        private Button btnTiendasSubMenu;
        private Button btnEditarTienda;
        private Button btnAgregarTienda;
        private Button btnArticulosSubMenu;
        private Panel panelArticulosSubMenu;
        private Button btnAgregarArticulo;
        private Button btnFiltrarArticulos;
        private Button btnTodosArticulos;
        private Panel panelContainerChild;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BtnEditarArticulo;
    }
}
