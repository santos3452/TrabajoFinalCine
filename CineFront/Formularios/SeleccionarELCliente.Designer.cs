namespace CineFront.Formularios
{
    partial class SeleccionarELCliente
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
            label6 = new Label();
            panel2 = new Panel();
            btnLimpear = new Button();
            btnIrAticket = new Button();
            btnIrAFormCliente = new Button();
            label4 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbDNI = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 89);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(24, 27);
            label6.Name = "label6";
            label6.Size = new Size(398, 45);
            label6.TabIndex = 11;
            label6.Text = "SELECCIONE EL DNI DEL CLIENTE";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(btnLimpear);
            panel2.Controls.Add(btnIrAticket);
            panel2.Controls.Add(btnIrAFormCliente);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbDNI);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 89);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 511);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // btnLimpear
            // 
            btnLimpear.Location = new Point(88, 328);
            btnLimpear.Margin = new Padding(3, 4, 3, 4);
            btnLimpear.Name = "btnLimpear";
            btnLimpear.Size = new Size(90, 31);
            btnLimpear.TabIndex = 9;
            btnLimpear.Text = "CANCELAR";
            btnLimpear.UseVisualStyleBackColor = true;
            btnLimpear.Click += btnLimpear_Click;
            // 
            // btnIrAticket
            // 
            btnIrAticket.Location = new Point(234, 328);
            btnIrAticket.Margin = new Padding(3, 4, 3, 4);
            btnIrAticket.Name = "btnIrAticket";
            btnIrAticket.Size = new Size(90, 31);
            btnIrAticket.TabIndex = 8;
            btnIrAticket.Text = "ACEPTAR";
            btnIrAticket.UseVisualStyleBackColor = true;
            btnIrAticket.Click += btnIrAticket_Click;
            // 
            // btnIrAFormCliente
            // 
            btnIrAFormCliente.Location = new Point(173, 451);
            btnIrAFormCliente.Margin = new Padding(3, 4, 3, 4);
            btnIrAFormCliente.Name = "btnIrAFormCliente";
            btnIrAFormCliente.Size = new Size(86, 31);
            btnIrAFormCliente.TabIndex = 7;
            btnIrAFormCliente.Text = "GENERAR";
            btnIrAFormCliente.UseVisualStyleBackColor = true;
            btnIrAFormCliente.Click += btnIrAFormCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(50, 413);
            label4.Name = "label4";
            label4.Size = new Size(368, 20);
            label4.TabIndex = 6;
            label4.Text = "¿El cliente no se encuentra registrado?. Presione abajo";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(160, 256);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 188);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(62, 260);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(66, 192);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(88, 108);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // cmbDNI
            // 
            cmbDNI.FormattingEnabled = true;
            cmbDNI.Location = new Point(149, 104);
            cmbDNI.Margin = new Padding(3, 4, 3, 4);
            cmbDNI.Name = "cmbDNI";
            cmbDNI.Size = new Size(138, 28);
            cmbDNI.TabIndex = 0;
            cmbDNI.SelectedIndexChanged += cmbDNI_SelectedIndexChanged;
            // 
            // SeleccionarELCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SeleccionarELCliente";
            Text = "SeleccionarELCliente";
            Load += SeleccionarELCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private ComboBox cmbDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnIrAFormCliente;
        private Button btnIrAticket;
        private Button btnLimpear;
    }
}