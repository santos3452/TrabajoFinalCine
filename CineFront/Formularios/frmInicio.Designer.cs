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
            lblTiempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.ForeColor = SystemColors.ButtonFace;
            BtnIngresar.Location = new Point(148, 205);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(144, 23);
            BtnIngresar.TabIndex = 0;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.FlatStyle = FlatStyle.Flat;
            BtnCrear.ForeColor = SystemColors.ButtonHighlight;
            BtnCrear.Location = new Point(148, 266);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(144, 23);
            BtnCrear.TabIndex = 1;
            BtnCrear.Text = "CREAR CUENTA";
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
            label1.Location = new Point(115, 53);
            label1.Name = "label1";
            label1.Size = new Size(203, 46);
            label1.TabIndex = 0;
            label1.Text = "CINES UTN";
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
            // button1
            // 
            button1.AllowDrop = true;
            button1.AutoSize = true;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Location = new Point(129, 349);
            button1.Name = "button1";
            button1.Size = new Size(177, 27);
            button1.TabIndex = 5;
            button1.Text = "Olvido su contraseña?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(439, 425);
            Controls.Add(button1);
            Controls.Add(lblTiempo);
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
        private Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}