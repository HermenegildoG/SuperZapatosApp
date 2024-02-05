namespace SuperZapatosApp.Views
{
    partial class AgregarArticuloView
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtTotal_In_Shelf = new TextBox();
            txtTotal_In_Vault = new TextBox();
            cmbSelectStore = new ComboBox();
            btnCrear = new Button();
            button1 = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(243, 94);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 2;
            label1.Text = "Crear Nuevo Articulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(8, 162);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(8, 221);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(8, 286);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(339, 162);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 6;
            label5.Text = "Tienda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(297, 221);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 7;
            label6.Text = "Articulos en tienda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Info;
            label7.Location = new Point(297, 286);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 8;
            label7.Text = "Articulos en Bodega";
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 163);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 27);
            txtName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(125, 222);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(160, 27);
            txtDescription.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(125, 284);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtTotal_In_Shelf
            // 
            txtTotal_In_Shelf.Location = new Point(500, 219);
            txtTotal_In_Shelf.Name = "txtTotal_In_Shelf";
            txtTotal_In_Shelf.Size = new Size(151, 27);
            txtTotal_In_Shelf.TabIndex = 13;
            // 
            // txtTotal_In_Vault
            // 
            txtTotal_In_Vault.Location = new Point(500, 284);
            txtTotal_In_Vault.Name = "txtTotal_In_Vault";
            txtTotal_In_Vault.Size = new Size(151, 27);
            txtTotal_In_Vault.TabIndex = 14;
            // 
            // cmbSelectStore
            // 
            cmbSelectStore.FormattingEnabled = true;
            cmbSelectStore.Location = new Point(500, 159);
            cmbSelectStore.Name = "cmbSelectStore";
            cmbSelectStore.Size = new Size(151, 28);
            cmbSelectStore.TabIndex = 15;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Lime;
            btnCrear.Location = new Point(243, 349);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 17;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(339, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarArticuloView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarArticuloView";
            Text = "Agregar Articulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtTotal_In_Shelf;
        private TextBox txtTotal_In_Vault;
        private ComboBox cmbSelectStore;
        private Button btnCrear;
        private Button button1;
        private Button btnCancelar;
    }
}