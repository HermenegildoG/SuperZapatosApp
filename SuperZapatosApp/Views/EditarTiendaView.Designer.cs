namespace SuperZapatosApp.Views
{
    partial class EditarTiendaView
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
            button1 = new Button();
            btnEditarTienda = new Button();
            label4 = new Label();
            label1 = new Label();
            dgvTodasTiendas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            adress = new DataGridViewTextBoxColumn();
            txtUbicacion = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label8 = new Label();
            btnCancelar = new Button();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTodasTiendas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 35;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEditarTienda
            // 
            btnEditarTienda.BackColor = Color.Khaki;
            btnEditarTienda.Location = new Point(279, 82);
            btnEditarTienda.Name = "btnEditarTienda";
            btnEditarTienda.Size = new Size(158, 29);
            btnEditarTienda.TabIndex = 34;
            btnEditarTienda.Text = "Editar Tienda";
            btnEditarTienda.UseVisualStyleBackColor = false;
            btnEditarTienda.Click += btnEditarTienda_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(43, 86);
            label4.Name = "label4";
            label4.Size = new Size(221, 20);
            label4.TabIndex = 33;
            label4.Text = "Selecciona la tienda en la tabla";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(281, 43);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 32;
            label1.Text = "Actualizar Tienda";
            // 
            // dgvTodasTiendas
            // 
            dgvTodasTiendas.AllowUserToAddRows = false;
            dgvTodasTiendas.AllowUserToDeleteRows = false;
            dgvTodasTiendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodasTiendas.Columns.AddRange(new DataGridViewColumn[] { id, name, adress });
            dgvTodasTiendas.Location = new Point(43, 117);
            dgvTodasTiendas.Name = "dgvTodasTiendas";
            dgvTodasTiendas.ReadOnly = true;
            dgvTodasTiendas.RowHeadersWidth = 51;
            dgvTodasTiendas.RowTemplate.Height = 29;
            dgvTodasTiendas.Size = new Size(566, 217);
            dgvTodasTiendas.TabIndex = 36;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 65;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 200;
            // 
            // adress
            // 
            adress.HeaderText = "Ubicación";
            adress.MinimumWidth = 6;
            adress.Name = "adress";
            adress.ReadOnly = true;
            adress.Width = 250;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(277, 384);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(160, 27);
            txtUbicacion.TabIndex = 40;
            // 
            // txtName
            // 
            txtName.Location = new Point(277, 351);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 27);
            txtName.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(160, 383);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 38;
            label3.Text = "Ubicación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Info;
            label8.Location = new Point(160, 350);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 37;
            label8.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(343, 447);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Lime;
            btnCrear.Location = new Point(219, 447);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 41;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // EditarTiendaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(txtUbicacion);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(dgvTodasTiendas);
            Controls.Add(button1);
            Controls.Add(btnEditarTienda);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "EditarTiendaView";
            Text = "EditarTiendaView";
            ((System.ComponentModel.ISupportInitialize)dgvTodasTiendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnEditarTienda;
        private Label label4;
        private Label label1;
        private DataGridView dgvTodasTiendas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn adress;
        private TextBox txtUbicacion;
        private TextBox txtName;
        private Label label3;
        private Label label8;
        private Button btnCancelar;
        private Button btnCrear;
    }
}