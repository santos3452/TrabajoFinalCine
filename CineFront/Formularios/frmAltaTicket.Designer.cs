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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblNOMBRE = new Label();
            label6 = new Label();
            panel2 = new Panel();
            btnSalir = new Button();
            button3 = new Button();
            button2 = new Button();
            label8 = new Label();
            txtTotal = new TextBox();
            label7 = new Label();
            txtVALOR = new TextBox();
            button1 = new Button();
            cboButaca = new ComboBox();
            label5 = new Label();
            cboFuncion = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cmbPeliculas = new ComboBox();
            label2 = new Label();
            cmbFormaPago = new ComboBox();
            cmbClientSelec = new ComboBox();
            label1 = new Label();
            dgvTICKET = new DataGridView();
            QUITAR = new DataGridViewButtonColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            FORMADEPAGO = new DataGridViewTextBoxColumn();
            FUNCION = new DataGridViewTextBoxColumn();
            PELICULA = new DataGridViewTextBoxColumn();
            HORARIO = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            BUTACA = new DataGridViewTextBoxColumn();
            VALOR = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTICKET).BeginInit();
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
            panel1.Size = new Size(1122, 67);
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
            label6.Location = new Point(500, 9);
            label6.Name = "label6";
            label6.Size = new Size(217, 35);
            label6.TabIndex = 11;
            label6.Text = "GENERAR TICKET NRO:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtVALOR);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cboButaca);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cboFuncion);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbPeliculas);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbFormaPago);
            panel2.Controls.Add(cmbClientSelec);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvTICKET);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 393);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 358);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 23);
            btnSalir.TabIndex = 27;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button3
            // 
            button3.Location = new Point(903, 358);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 26;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1019, 358);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 25;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(961, 328);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 24;
            label8.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1019, 320);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 23;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(629, 80);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 22;
            label7.Text = "VALOR:";
            // 
            // txtVALOR
            // 
            txtVALOR.Location = new Point(681, 72);
            txtVALOR.Name = "txtVALOR";
            txtVALOR.Size = new Size(88, 23);
            txtVALOR.TabIndex = 21;
            txtVALOR.TextChanged += txtVALOR_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1024, 92);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 20;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboButaca
            // 
            cboButaca.FormattingEnabled = true;
            cboButaca.Location = new Point(573, 72);
            cboButaca.Name = "cboButaca";
            cboButaca.Size = new Size(39, 23);
            cboButaca.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(446, 80);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 9;
            label5.Text = "BUTACA DISPONIBLE:";
            label5.Click += label5_Click;
            // 
            // cboFuncion
            // 
            cboFuncion.FormattingEnabled = true;
            cboFuncion.Location = new Point(446, 36);
            cboFuncion.Name = "cboFuncion";
            cboFuncion.Size = new Size(323, 23);
            cboFuncion.TabIndex = 8;
            cboFuncion.SelectedIndexChanged += cboFuncion_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(362, 44);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "FUNCION:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(362, 15);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "PELICULA:";
            // 
            // cmbPeliculas
            // 
            cmbPeliculas.FormattingEnabled = true;
            cmbPeliculas.Location = new Point(446, 7);
            cmbPeliculas.Name = "cmbPeliculas";
            cmbPeliculas.Size = new Size(323, 23);
            cmbPeliculas.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(881, 15);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "FORMA DE PAGO:";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(989, 15);
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
            // dgvTICKET
            // 
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dgvTICKET.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTICKET.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvTICKET.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTICKET.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTICKET.Columns.AddRange(new DataGridViewColumn[] { QUITAR, NOMBRE, APELLIDO, FORMADEPAGO, FUNCION, PELICULA, HORARIO, FECHA, BUTACA, VALOR });
            dgvTICKET.Location = new Point(0, 121);
            dgvTICKET.Name = "dgvTICKET";
            dgvTICKET.RowTemplate.Height = 25;
            dgvTICKET.Size = new Size(1122, 193);
            dgvTICKET.TabIndex = 0;
            dgvTICKET.CellContentClick += dgvTICKET_CellContentClick;
            // 
            // QUITAR
            // 
            QUITAR.HeaderText = "QUITAR";
            QUITAR.Name = "QUITAR";
            QUITAR.Text = "QUITAR";
            QUITAR.UseColumnTextForButtonValue = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.Name = "APELLIDO";
            // 
            // FORMADEPAGO
            // 
            FORMADEPAGO.HeaderText = "FORMA DE PAGO";
            FORMADEPAGO.Name = "FORMADEPAGO";
            // 
            // FUNCION
            // 
            FUNCION.FillWeight = 500F;
            FUNCION.HeaderText = "FUNCION";
            FUNCION.Name = "FUNCION";
            // 
            // PELICULA
            // 
            PELICULA.HeaderText = "PELICULA";
            PELICULA.Name = "PELICULA";
            // 
            // HORARIO
            // 
            HORARIO.HeaderText = "HORARIO";
            HORARIO.Name = "HORARIO";
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.Name = "FECHA";
            // 
            // BUTACA
            // 
            BUTACA.HeaderText = "BUTACA";
            BUTACA.Name = "BUTACA";
            // 
            // VALOR
            // 
            VALOR.HeaderText = "VALOR";
            VALOR.Name = "VALOR";
            // 
            // frmAltaTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 460);
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
            ((System.ComponentModel.ISupportInitialize)dgvTICKET).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvTICKET;
        private ComboBox cmbClientSelec;
        private Label lblNOMBRE;
        private Label label2;
        private ComboBox cmbFormaPago;
        private Label label3;
        private ComboBox cmbPeliculas;
        private ComboBox cboFuncion;
        private Label label4;
        private ComboBox cboButaca;
        private Label label5;
        private Button button1;
        private Label label7;
        private TextBox txtVALOR;
        private TextBox txtTotal;
        private Label label8;
        private Button btnSalir;
        private Button button3;
        private Button button2;
        private DataGridViewButtonColumn QUITAR;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn FORMADEPAGO;
        private DataGridViewTextBoxColumn FUNCION;
        private DataGridViewTextBoxColumn PELICULA;
        private DataGridViewTextBoxColumn HORARIO;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn BUTACA;
        private DataGridViewTextBoxColumn VALOR;
    }
}