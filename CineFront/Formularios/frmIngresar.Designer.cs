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
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.FlatStyle = FlatStyle.Flat;
            Usuario.ForeColor = SystemColors.ButtonFace;
            Usuario.Location = new Point(154, 99);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(56, 15);
            Usuario.TabIndex = 0;
            Usuario.Text = "USUARIO";
            Usuario.Click += Usuario_Click;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.ForeColor = SystemColors.ControlLightLight;
            Contraseña.Location = new Point(142, 176);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(83, 15);
            Contraseña.TabIndex = 1;
            Contraseña.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(130, 132);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(111, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(130, 204);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(111, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(63, 248);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
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
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(238, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 79);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(104, 27);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 3;
            label1.Text = "CINES UTN";
            // 
            // frmIngresar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(377, 328);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(Contraseña);
            Controls.Add(Usuario);
            Name = "frmIngresar";
            Text = "Ingresar";
            Load += frmIngresar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label1;
    }
}