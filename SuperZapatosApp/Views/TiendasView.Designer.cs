namespace SuperZapatosApp.Views
{
    partial class TiendasView
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
            button1 = new Button();
            dgvTodasTiendas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            adress = new DataGridViewTextBoxColumn();
            lblNameDescription = new Label();
            txtFiltroTienda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTodasTiendas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(236, 32);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 1;
            label1.Text = "Todos las Tiendas";
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
            // dgvTodasTiendas
            // 
            dgvTodasTiendas.AllowUserToAddRows = false;
            dgvTodasTiendas.AllowUserToDeleteRows = false;
            dgvTodasTiendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodasTiendas.Columns.AddRange(new DataGridViewColumn[] { id, name, adress });
            dgvTodasTiendas.Location = new Point(55, 119);
            dgvTodasTiendas.Name = "dgvTodasTiendas";
            dgvTodasTiendas.ReadOnly = true;
            dgvTodasTiendas.RowHeadersWidth = 51;
            dgvTodasTiendas.RowTemplate.Height = 29;
            dgvTodasTiendas.Size = new Size(567, 358);
            dgvTodasTiendas.TabIndex = 7;
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
            // lblNameDescription
            // 
            lblNameDescription.AutoSize = true;
            lblNameDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameDescription.ForeColor = SystemColors.Info;
            lblNameDescription.Location = new Point(55, 87);
            lblNameDescription.Name = "lblNameDescription";
            lblNameDescription.Size = new Size(193, 23);
            lblNameDescription.TabIndex = 9;
            lblNameDescription.Text = "Ingresa el nombre o ID";
            // 
            // txtFiltroTienda
            // 
            txtFiltroTienda.Location = new Point(263, 87);
            txtFiltroTienda.Name = "txtFiltroTienda";
            txtFiltroTienda.Size = new Size(359, 27);
            txtFiltroTienda.TabIndex = 8;
            txtFiltroTienda.TextChanged += txtFiltroTienda_TextChanged;
            // 
            // TiendasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(lblNameDescription);
            Controls.Add(txtFiltroTienda);
            Controls.Add(dgvTodasTiendas);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "TiendasView";
            Text = "TiendasView";
            ((System.ComponentModel.ISupportInitialize)dgvTodasTiendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dgvTodasTiendas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn adress;
        private Label lblNameDescription;
        private TextBox txtFiltroTienda;
    }
}