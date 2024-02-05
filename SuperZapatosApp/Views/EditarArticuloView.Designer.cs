namespace SuperZapatosApp.Views
{
    partial class EditarArticuloView
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
            dgvFiltroArticulo = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            total_in_shelf = new DataGridViewTextBoxColumn();
            total_in_vault = new DataGridViewTextBoxColumn();
            store_name = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label4 = new Label();
            btnEditarArticulo = new Button();
            cmbSelectStore = new ComboBox();
            txtTotal_In_Vault = new TextBox();
            txtTotal_In_Shelf = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            btnCrear = new Button();
            btnCancelar = new Button();
            txtSelectedStore = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFiltroArticulo).BeginInit();
            SuspendLayout();
            // 
            // dgvFiltroArticulo
            // 
            dgvFiltroArticulo.AllowUserToAddRows = false;
            dgvFiltroArticulo.AllowUserToDeleteRows = false;
            dgvFiltroArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiltroArticulo.Columns.AddRange(new DataGridViewColumn[] { id, name, description, price, total_in_shelf, total_in_vault, store_name });
            dgvFiltroArticulo.Location = new Point(12, 92);
            dgvFiltroArticulo.Name = "dgvFiltroArticulo";
            dgvFiltroArticulo.ReadOnly = true;
            dgvFiltroArticulo.RowHeadersWidth = 51;
            dgvFiltroArticulo.RowTemplate.Height = 29;
            dgvFiltroArticulo.Size = new Size(640, 225);
            dgvFiltroArticulo.TabIndex = 5;
            dgvFiltroArticulo.CellContentClick += dgvFiltroArticulo_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 6;
            label1.Text = "Actualizar Articulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(230, 20);
            label4.TabIndex = 9;
            label4.Text = "Selecciona el articulo en la tabla";
            // 
            // btnEditarArticulo
            // 
            btnEditarArticulo.BackColor = Color.Khaki;
            btnEditarArticulo.Location = new Point(248, 48);
            btnEditarArticulo.Name = "btnEditarArticulo";
            btnEditarArticulo.Size = new Size(158, 29);
            btnEditarArticulo.TabIndex = 10;
            btnEditarArticulo.Text = "Editar ese articulo";
            btnEditarArticulo.UseVisualStyleBackColor = false;
            btnEditarArticulo.Click += btnEditarArticulo_Click;
            // 
            // cmbSelectStore
            // 
            cmbSelectStore.FormattingEnabled = true;
            cmbSelectStore.Location = new Point(499, 340);
            cmbSelectStore.Name = "cmbSelectStore";
            cmbSelectStore.Size = new Size(151, 28);
            cmbSelectStore.TabIndex = 27;
            cmbSelectStore.Text = "Selecciona una tienda";
            // 
            // txtTotal_In_Vault
            // 
            txtTotal_In_Vault.Location = new Point(499, 410);
            txtTotal_In_Vault.Name = "txtTotal_In_Vault";
            txtTotal_In_Vault.Size = new Size(151, 27);
            txtTotal_In_Vault.TabIndex = 26;
            // 
            // txtTotal_In_Shelf
            // 
            txtTotal_In_Shelf.Location = new Point(499, 374);
            txtTotal_In_Shelf.Name = "txtTotal_In_Shelf";
            txtTotal_In_Shelf.Size = new Size(151, 27);
            txtTotal_In_Shelf.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(124, 410);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 27);
            txtPrice.TabIndex = 24;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(124, 377);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(160, 27);
            txtDescription.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 344);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 27);
            txtName.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Info;
            label7.Location = new Point(296, 412);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 21;
            label7.Text = "Articulos en Bodega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(296, 376);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 20;
            label6.Text = "Articulos en tienda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(296, 343);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 19;
            label5.Text = "Tienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(7, 412);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 18;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(7, 376);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 17;
            label3.Text = "Descripción";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Info;
            label8.Location = new Point(7, 343);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 16;
            label8.Text = "Nombre";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Lime;
            btnCrear.Location = new Point(190, 453);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 28;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(314, 453);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSelectedStore
            // 
            txtSelectedStore.Location = new Point(368, 340);
            txtSelectedStore.Name = "txtSelectedStore";
            txtSelectedStore.ReadOnly = true;
            txtSelectedStore.Size = new Size(125, 27);
            txtSelectedStore.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 31;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditarArticuloView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(button1);
            Controls.Add(txtSelectedStore);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(cmbSelectStore);
            Controls.Add(txtTotal_In_Vault);
            Controls.Add(txtTotal_In_Shelf);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(btnEditarArticulo);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dgvFiltroArticulo);
            Name = "EditarArticuloView";
            Text = "EditarArticuloView";
            ((System.ComponentModel.ISupportInitialize)dgvFiltroArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFiltroArticulo;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total_in_shelf;
        private DataGridViewTextBoxColumn total_in_vault;
        private DataGridViewTextBoxColumn store_name;
        private Label label1;
        private Label label4;
        private Button btnEditarArticulo;
        private ComboBox cmbSelectStore;
        private TextBox txtTotal_In_Vault;
        private TextBox txtTotal_In_Shelf;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label8;
        private Button btnCrear;
        private Button btnCancelar;
        private TextBox txtSelectedStore;
        private Button button1;
    }
}