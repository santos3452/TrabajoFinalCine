namespace Front.Formularios
{
    partial class PaginaPrincipal
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            PanelTitulo = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PanelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 377);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(0, 177);
            button4.Name = "button4";
            button4.Size = new Size(200, 52);
            button4.TabIndex = 7;
            button4.Text = "NOSOTROS";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(-3, 119);
            button3.Name = "button3";
            button3.Size = new Size(200, 52);
            button3.TabIndex = 6;
            button3.Text = "REPORTES";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(-3, 61);
            button2.Name = "button2";
            button2.Size = new Size(200, 52);
            button2.TabIndex = 5;
            button2.Text = "CLIENTES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 52);
            button1.TabIndex = 4;
            button1.Text = "TICKET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(197, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 78);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(236, 24);
            label2.Name = "label2";
            label2.Size = new Size(68, 35);
            label2.TabIndex = 3;
            label2.Text = "INICIO";
            label2.Click += label2_Click;
            // 
            // PanelTitulo
            // 
            PanelTitulo.BackColor = Color.FromArgb(39, 39, 58);
            PanelTitulo.Controls.Add(label1);
            PanelTitulo.Location = new Point(0, -1);
            PanelTitulo.Name = "PanelTitulo";
            PanelTitulo.Size = new Size(200, 78);
            PanelTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 2;
            label1.Text = "CINES UTN";
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelTitulo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PaginaPrincipal";
            Text = "PaginaPrincipal";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelTitulo.ResumeLayout(false);
            PanelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Panel PanelTitulo;
        private Label label1;
    }
}