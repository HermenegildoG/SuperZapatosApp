namespace SuperZapatosApp.Views
{
    partial class FiltrarArticulosView
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
            txtFiltroArticulo = new TextBox();
            lblNameDescription = new Label();
            dgvFiltroArticulo = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            total_in_shelf = new DataGridViewTextBoxColumn();
            total_in_vault = new DataGridViewTextBoxColumn();
            store_name = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label4 = new Label();
            btnEliminarArticulo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFiltroArticulo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(228, 16);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 1;
            label1.Text = "Filtrar Articulo";
            label1.Click += label1_Click;
            // 
            // txtFiltroArticulo
            // 
            txtFiltroArticulo.Location = new Point(228, 93);
            txtFiltroArticulo.Name = "txtFiltroArticulo";
            txtFiltroArticulo.Size = new Size(359, 27);
            txtFiltroArticulo.TabIndex = 2;
            txtFiltroArticulo.TextChanged += txtFiltroArticulo_TextChanged;
            // 
            // lblNameDescription
            // 
            lblNameDescription.AutoSize = true;
            lblNameDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameDescription.ForeColor = SystemColors.Info;
            lblNameDescription.Location = new Point(89, 94);
            lblNameDescription.Name = "lblNameDescription";
            lblNameDescription.Size = new Size(133, 23);
            lblNameDescription.TabIndex = 3;
            lblNameDescription.Text = "Ingresa el filtro";
            // 
            // dgvFiltroArticulo
            // 
            dgvFiltroArticulo.AllowUserToAddRows = false;
            dgvFiltroArticulo.AllowUserToDeleteRows = false;
            dgvFiltroArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiltroArticulo.Columns.AddRange(new DataGridViewColumn[] { id, name, description, price, total_in_shelf, total_in_vault, store_name });
            dgvFiltroArticulo.Location = new Point(24, 146);
            dgvFiltroArticulo.Name = "dgvFiltroArticulo";
            dgvFiltroArticulo.ReadOnly = true;
            dgvFiltroArticulo.RowHeadersWidth = 51;
            dgvFiltroArticulo.RowTemplate.Height = 29;
            dgvFiltroArticulo.Size = new Size(604, 316);
            dgvFiltroArticulo.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
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
            price.Width = 125;
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
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(172, 54);
            label4.Name = "label4";
            label4.Size = new Size(316, 20);
            label4.TabIndex = 8;
            label4.Text = "Filtrar por Nombre, descripción, ID o Tienda";
            // 
            // btnEliminarArticulo
            // 
            btnEliminarArticulo.BackColor = Color.Red;
            btnEliminarArticulo.ForeColor = SystemColors.Control;
            btnEliminarArticulo.Location = new Point(24, 465);
            btnEliminarArticulo.Name = "btnEliminarArticulo";
            btnEliminarArticulo.Size = new Size(144, 29);
            btnEliminarArticulo.TabIndex = 9;
            btnEliminarArticulo.Text = "Eliminar articulo";
            btnEliminarArticulo.UseVisualStyleBackColor = false;
            btnEliminarArticulo.Click += btnEliminarArticulo_Click;
            // 
            // FiltrarArticulosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(btnEliminarArticulo);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dgvFiltroArticulo);
            Controls.Add(lblNameDescription);
            Controls.Add(txtFiltroArticulo);
            Controls.Add(label1);
            Name = "FiltrarArticulosView";
            Text = "FiltrarArticulosView";
            ((System.ComponentModel.ISupportInitialize)dgvFiltroArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltroArticulo;
        private Label lblNameDescription;
        private DataGridView dgvFiltroArticulo;
        private Button button1;
        private Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total_in_shelf;
        private DataGridViewTextBoxColumn total_in_vault;
        private DataGridViewTextBoxColumn store_name;
        private Button btnEliminarArticulo;
    }
}