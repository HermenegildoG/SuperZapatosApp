namespace SuperZapatosApp.Views
{
    partial class ArticulosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvArticulos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            total_in_shelf = new DataGridViewTextBoxColumn();
            total_in_vault = new DataGridViewTextBoxColumn();
            store_name = new DataGridViewTextBoxColumn();
            cmbTiendas = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(231, 24);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Todos los Articulos";
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { id, name, description, price, total_in_shelf, total_in_vault, store_name });
            dgvArticulos.Location = new Point(25, 125);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.RowTemplate.Height = 29;
            dgvArticulos.Size = new Size(627, 356);
            dgvArticulos.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // description
            // 
            description.HeaderText = "Descripción";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Precio";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 90;
            // 
            // total_in_shelf
            // 
            total_in_shelf.HeaderText = "Disponibles en tienda";
            total_in_shelf.MinimumWidth = 6;
            total_in_shelf.Name = "total_in_shelf";
            total_in_shelf.ReadOnly = true;
            total_in_shelf.Width = 125;
            // 
            // total_in_vault
            // 
            total_in_vault.HeaderText = "Disponibles en bodega";
            total_in_vault.MinimumWidth = 6;
            total_in_vault.Name = "total_in_vault";
            total_in_vault.ReadOnly = true;
            total_in_vault.Width = 125;
            // 
            // store_name
            // 
            store_name.HeaderText = "Tienda";
            store_name.MinimumWidth = 6;
            store_name.Name = "store_name";
            store_name.ReadOnly = true;
            store_name.Width = 125;
            // 
            // cmbTiendas
            // 
            cmbTiendas.FormattingEnabled = true;
            cmbTiendas.Location = new Point(321, 79);
            cmbTiendas.Name = "cmbTiendas";
            cmbTiendas.Size = new Size(151, 28);
            cmbTiendas.TabIndex = 2;
            cmbTiendas.SelectedIndexChanged += cmbTiendas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(129, 84);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 3;
            label2.Text = "Selecciona una Tienda";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ArticulosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbTiendas);
            Controls.Add(dgvArticulos);
            Controls.Add(label1);
            Name = "ArticulosView";
            Text = "Articulos";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvArticulos;
        private ComboBox cmbTiendas;
        private Label label2;
        private Button button1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total_in_shelf;
        private DataGridViewTextBoxColumn total_in_vault;
        private DataGridViewTextBoxColumn store_name;
    }
}