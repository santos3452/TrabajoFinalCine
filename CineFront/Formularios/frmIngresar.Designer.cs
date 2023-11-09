namespace CineFront
{
    partial class frmIngresar
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
            Usuario = new Label();
            Contraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnVolver = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.ForeColor = SystemColors.ButtonFace;
            Usuario.Location = new Point(153, 34);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.ForeColor = SystemColors.ControlLightLight;
            Contraseña.Location = new Point(144, 133);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(67, 15);
            Contraseña.TabIndex = 1;
            Contraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(130, 79);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(130, 167);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(63, 220);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(290, 293);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // frmIngresar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(377, 328);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(Contraseña);
            Controls.Add(Usuario);
            Name = "frmIngresar";
            Text = "Ingresar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuario;
        private Label Contraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnVolver;
        private Button btnCancelar;
    }
}