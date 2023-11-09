namespace CineFront
{
    partial class frmInicio
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
            components = new System.ComponentModel.Container();
            BtnIngresar = new Button();
            BtnCrear = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblTiempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(148, 205);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(144, 23);
            BtnIngresar.TabIndex = 0;
            BtnIngresar.Text = "Ingresar Cuenta";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(148, 262);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(144, 23);
            BtnCrear.TabIndex = 1;
            BtnCrear.Text = "Crear Cuenta";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 148);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(121, 53);
            label1.Name = "label1";
            label1.Size = new Size(203, 46);
            label1.TabIndex = 0;
            label1.Text = "CINES UTN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(148, 320);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "¿Olvido su contraseña?";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(349, 387);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 15);
            lblTiempo.TabIndex = 4;
            lblTiempo.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(439, 425);
            Controls.Add(lblTiempo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(BtnCrear);
            Controls.Add(BtnIngresar);
            Name = "frmInicio";
            Text = "Inicio";
            Load += frmInicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIngresar;
        private Button BtnCrear;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}