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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblNOMBRE = new Label();
            lblTICKET = new Label();
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
            panel1.Controls.Add(lblTICKET);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 89);
            panel1.TabIndex = 1;
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Location = new Point(14, 24);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(0, 20);
            lblNOMBRE.TabIndex = 20;
            // 
            // lblTICKET
            // 
            lblTICKET.AutoSize = true;
            lblTICKET.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTICKET.ForeColor = SystemColors.ControlLight;
            lblTICKET.Location = new Point(510, 24);
            lblTICKET.Name = "lblTICKET";
            lblTICKET.Size = new Size(279, 45);
            lblTICKET.TabIndex = 11;
            lblTICKET.Text = "GENERAR TICKET NRO:";
            lblTICKET.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
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
            panel2.Location = new Point(0, 89);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1282, 524);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(14, 477);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 31);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1032, 477);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 31);
            button3.TabIndex = 8;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1165, 477);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 7;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1098, 437);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 24;
            label8.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1165, 427);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(114, 27);
            txtTotal.TabIndex = 6;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(719, 107);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 10;
            label7.Text = "VALOR:";
            // 
            // txtVALOR
            // 
            txtVALOR.Location = new Point(778, 96);
            txtVALOR.Margin = new Padding(3, 4, 3, 4);
            txtVALOR.Name = "txtVALOR";
            txtVALOR.Size = new Size(100, 27);
            txtVALOR.TabIndex = 4;
            txtVALOR.TextChanged += txtVALOR_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1170, 123);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 31);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboButaca
            // 
            cboButaca.FormattingEnabled = true;
            cboButaca.Location = new Point(655, 96);
            cboButaca.Margin = new Padding(3, 4, 3, 4);
            cboButaca.Name = "cboButaca";
            cboButaca.Size = new Size(44, 28);
            cboButaca.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(510, 107);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 6;
            label5.Text = "BUTACA DISPONIBLE:";
            label5.Click += label5_Click;
            // 
            // cboFuncion
            // 
            cboFuncion.FormattingEnabled = true;
            cboFuncion.Location = new Point(510, 48);
            cboFuncion.Margin = new Padding(3, 4, 3, 4);
            cboFuncion.Name = "cboFuncion";
            cboFuncion.Size = new Size(369, 28);
            cboFuncion.TabIndex = 1;
            cboFuncion.SelectedIndexChanged += cboFuncion_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(414, 59);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "FUNCION:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(414, 20);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "PELICULA:";
            // 
            // cmbPeliculas
            // 
            cmbPeliculas.FormattingEnabled = true;
            cmbPeliculas.Location = new Point(510, 9);
            cmbPeliculas.Margin = new Padding(3, 4, 3, 4);
            cmbPeliculas.Name = "cmbPeliculas";
            cmbPeliculas.Size = new Size(369, 28);
            cmbPeliculas.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(997, 20);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 12;
            label2.Text = "FORMA DE PAGO:";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(1130, 20);
            cmbFormaPago.Margin = new Padding(3, 4, 3, 4);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(138, 28);
            cmbFormaPago.TabIndex = 2;
            // 
            // cmbClientSelec
            // 
            cmbClientSelec.FormattingEnabled = true;
            cmbClientSelec.Location = new Point(109, 16);
            cmbClientSelec.Margin = new Padding(3, 4, 3, 4);
            cmbClientSelec.Name = "cmbClientSelec";
            cmbClientSelec.Size = new Size(138, 28);
            cmbClientSelec.TabIndex = 2;
            cmbClientSelec.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "DNI CLIENTE:";
            // 
            // dgvTICKET
            // 
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dgvTICKET.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTICKET.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvTICKET.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTICKET.BackgroundColor = Color.FromArgb(51, 51, 76);
            dgvTICKET.BorderStyle = BorderStyle.None;
            dgvTICKET.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTICKET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTICKET.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTICKET.Columns.AddRange(new DataGridViewColumn[] { QUITAR, NOMBRE, APELLIDO, FORMADEPAGO, FUNCION, PELICULA, HORARIO, FECHA, BUTACA, VALOR });
            dgvTICKET.EnableHeadersVisualStyles = false;
            dgvTICKET.GridColor = Color.FromArgb(0, 150, 136);
            dgvTICKET.Location = new Point(0, 161);
            dgvTICKET.Margin = new Padding(3, 4, 3, 4);
            dgvTICKET.Name = "dgvTICKET";
            dgvTICKET.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTICKET.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTICKET.RowHeadersVisible = false;
            dgvTICKET.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvTICKET.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTICKET.RowTemplate.Height = 25;
            dgvTICKET.Size = new Size(1282, 257);
            dgvTICKET.TabIndex = 0;
            dgvTICKET.CellContentClick += dgvTICKET_CellContentClick;
            // 
            // QUITAR
            // 
            QUITAR.HeaderText = "QUITAR";
            QUITAR.MinimumWidth = 6;
            QUITAR.Name = "QUITAR";
            QUITAR.Text = "QUITAR";
            QUITAR.UseColumnTextForButtonValue = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.MinimumWidth = 6;
            APELLIDO.Name = "APELLIDO";
            // 
            // FORMADEPAGO
            // 
            FORMADEPAGO.HeaderText = "FORMA DE PAGO";
            FORMADEPAGO.MinimumWidth = 6;
            FORMADEPAGO.Name = "FORMADEPAGO";
            // 
            // FUNCION
            // 
            FUNCION.FillWeight = 500F;
            FUNCION.HeaderText = "FUNCION";
            FUNCION.MinimumWidth = 6;
            FUNCION.Name = "FUNCION";
            // 
            // PELICULA
            // 
            PELICULA.HeaderText = "PELICULA";
            PELICULA.MinimumWidth = 6;
            PELICULA.Name = "PELICULA";
            // 
            // HORARIO
            // 
            HORARIO.HeaderText = "HORARIO";
            HORARIO.MinimumWidth = 6;
            HORARIO.Name = "HORARIO";
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            // 
            // BUTACA
            // 
            BUTACA.HeaderText = "BUTACA";
            BUTACA.MinimumWidth = 6;
            BUTACA.Name = "BUTACA";
            // 
            // VALOR
            // 
            VALOR.HeaderText = "VALOR";
            VALOR.MinimumWidth = 6;
            VALOR.Name = "VALOR";
            // 
            // frmAltaTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
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
        private Label lblTICKET;
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