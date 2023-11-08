namespace CineFront
{
    partial class frmCrear
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtRepetirContraseña = new TextBox();
            txtMail = new TextBox();
            btnAceptar = new Button();
            btnVolver = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 58);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 112);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 162);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Repetir Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 216);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Mail";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(143, 76);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(143, 130);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 5;
            // 
            // txtRepetirContraseña
            // 
            txtRepetirContraseña.Location = new Point(143, 180);
            txtRepetirContraseña.Name = "txtRepetirContraseña";
            txtRepetirContraseña.Size = new Size(100, 23);
            txtRepetirContraseña.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(143, 234);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(112, 283);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(282, 383);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(202, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Crear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 451);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(txtMail);
            Controls.Add(txtRepetirContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Crear";
            Text = "Crear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtRepetirContraseña;
        private TextBox txtMail;
        private Button btnAceptar;
        private Button btnVolver;
        private Button btnCancelar;
    }
}