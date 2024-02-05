namespace SuperZapatosApp.Views
{
    partial class AgregarTiendaView
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
            btnCancelar = new Button();
            button1 = new Button();
            btnCrear = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(339, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(12, 10);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 33;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Lime;
            btnCrear.Location = new Point(243, 347);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 32;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(283, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(166, 140);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(243, 58);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 19;
            label1.Text = "Crear Nueva Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(166, 199);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 21;
            label3.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(283, 200);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 110);
            txtDireccion.TabIndex = 27;
            // 
            // AgregarTiendaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(664, 506);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(btnCrear);
            Controls.Add(txtDireccion);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarTiendaView";
            Text = "AgregarTiendaView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button button1;
        private Button btnCrear;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtDireccion;
    }
}