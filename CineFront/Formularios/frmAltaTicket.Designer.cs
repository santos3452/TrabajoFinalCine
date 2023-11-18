namespace Front.Formularios
{
    partial class frmAltaTicket
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
            lblNOMBRE = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            cmbPeliculas = new ComboBox();
            label2 = new Label();
            cmbFormaPago = new ComboBox();
            cmbClientSelec = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(lblNOMBRE);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 67);
            panel1.TabIndex = 18;
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Location = new Point(12, 18);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(38, 15);
            lblNOMBRE.TabIndex = 20;
            lblNOMBRE.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(450, 18);
            label6.Name = "label6";
            label6.Size = new Size(217, 35);
            label6.TabIndex = 11;
            label6.Text = "GENERAR TICKET NRO:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbPeliculas);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbFormaPago);
            panel2.Controls.Add(cmbClientSelec);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1151, 409);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(27, 73);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "PELICULA:";
            // 
            // cmbPeliculas
            // 
            cmbPeliculas.FormattingEnabled = true;
            cmbPeliculas.Location = new Point(95, 70);
            cmbPeliculas.Name = "cmbPeliculas";
            cmbPeliculas.Size = new Size(317, 23);
            cmbPeliculas.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(877, 12);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "FORMA DE PAGO:";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(994, 9);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(121, 23);
            cmbFormaPago.TabIndex = 3;
            // 
            // cmbClientSelec
            // 
            cmbClientSelec.FormattingEnabled = true;
            cmbClientSelec.Location = new Point(95, 12);
            cmbClientSelec.Name = "cmbClientSelec";
            cmbClientSelec.Size = new Size(121, 23);
            cmbClientSelec.TabIndex = 2;
            cmbClientSelec.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI CLIENTE:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1151, 216);
            dataGridView1.TabIndex = 0;
            // 
            // frmAltaTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 476);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAltaTicket";
            Text = "frmAltaTicket";
            Load += frmAltaTicket_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox cmbClientSelec;
        private Label lblNOMBRE;
        private Label label2;
        private ComboBox cmbFormaPago;
        private Label label3;
        private ComboBox cmbPeliculas;
    }
}