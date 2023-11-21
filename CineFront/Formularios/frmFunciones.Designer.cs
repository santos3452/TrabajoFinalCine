namespace CineFront.Formularios
{
    partial class frmFunciones
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtHORA = new TextBox();
            label6 = new Label();
            btnGrabar = new Button();
            cboSalas = new ComboBox();
            txtPrecio = new TextBox();
            cboPeliculas = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            dtPICKER = new DateTimePicker();
            dtvFunciones = new DataGridView();
            BORRAR = new DataGridViewButtonColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            HORA = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            ID_SALA = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvFunciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 140);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(477, 43);
            label1.Name = "label1";
            label1.Size = new Size(368, 45);
            label1.TabIndex = 0;
            label1.Text = "AGREGUE  NUEVAS FUNCIONES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(txtHORA);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnGrabar);
            panel2.Controls.Add(cboSalas);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(cboPeliculas);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dtPICKER);
            panel2.Controls.Add(dtvFunciones);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 140);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 460);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtHORA
            // 
            txtHORA.Location = new Point(94, 77);
            txtHORA.Margin = new Padding(3, 4, 3, 4);
            txtHORA.Name = "txtHORA";
            txtHORA.Size = new Size(138, 27);
            txtHORA.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(3, 81);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 14;
            label6.Text = "HORARIO:";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(272, 269);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 31);
            btnGrabar.TabIndex = 12;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // cboSalas
            // 
            cboSalas.FormattingEnabled = true;
            cboSalas.Location = new Point(94, 269);
            cboSalas.Margin = new Padding(3, 4, 3, 4);
            cboSalas.Name = "cboSalas";
            cboSalas.Size = new Size(54, 28);
            cboSalas.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(94, 191);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(138, 27);
            txtPrecio.TabIndex = 10;
            // 
            // cboPeliculas
            // 
            cboPeliculas.FormattingEnabled = true;
            cboPeliculas.Location = new Point(91, 135);
            cboPeliculas.Margin = new Padding(3, 4, 3, 4);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(253, 28);
            cboPeliculas.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(14, 385);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 8;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(272, 385);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 7;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtPICKER
            // 
            dtPICKER.Format = DateTimePickerFormat.Short;
            dtPICKER.Location = new Point(94, 13);
            dtPICKER.Margin = new Padding(3, 4, 3, 4);
            dtPICKER.Name = "dtPICKER";
            dtPICKER.Size = new Size(253, 27);
            dtPICKER.TabIndex = 6;
            // 
            // dtvFunciones
            // 
            dtvFunciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvFunciones.BackgroundColor = Color.FromArgb(51, 51, 76);
            dtvFunciones.BorderStyle = BorderStyle.None;
            dtvFunciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtvFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtvFunciones.ColumnHeadersHeight = 29;
            dtvFunciones.Columns.AddRange(new DataGridViewColumn[] { BORRAR, NOMBRE, FECHA, HORA, PRECIO, ID_SALA });
            dtvFunciones.EnableHeadersVisualStyles = false;
            dtvFunciones.GridColor = Color.FromArgb(0, 150, 136);
            dtvFunciones.Location = new Point(365, 0);
            dtvFunciones.Margin = new Padding(3, 4, 3, 4);
            dtvFunciones.Name = "dtvFunciones";
            dtvFunciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtvFunciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtvFunciones.RowHeadersVisible = false;
            dtvFunciones.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtvFunciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtvFunciones.RowTemplate.Height = 25;
            dtvFunciones.Size = new Size(862, 460);
            dtvFunciones.TabIndex = 5;
            dtvFunciones.CellContentClick += dtvFunciones_CellContentClick;
            // 
            // BORRAR
            // 
            BORRAR.HeaderText = "BORRAR";
            BORRAR.MinimumWidth = 6;
            BORRAR.Name = "BORRAR";
            BORRAR.ReadOnly = true;
            BORRAR.Resizable = DataGridViewTriState.True;
            BORRAR.SortMode = DataGridViewColumnSortMode.Automatic;
            BORRAR.Text = "BORRAR";
            BORRAR.UseColumnTextForButtonValue = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE PELICULA";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            // 
            // HORA
            // 
            HORA.HeaderText = "HORA";
            HORA.MinimumWidth = 6;
            HORA.Name = "HORA";
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            // 
            // ID_SALA
            // 
            ID_SALA.HeaderText = "ID_SALA";
            ID_SALA.MinimumWidth = 6;
            ID_SALA.Name = "ID_SALA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(17, 201);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "PRECIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(31, 280);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "SALA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 145);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "PELICULA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 21);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "FECHA:";
            // 
            // frmFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFunciones";
            Text = "frmFunciones";
            Load += frmFunciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvFunciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtPICKER;
        private DataGridView dtvFunciones;
        private Label label5;
        private ComboBox cboSalas;
        private TextBox txtPrecio;
        private ComboBox cboPeliculas;
        private Button button2;
        private Button button1;
        private Button btnGrabar;
        private Label label6;
        private TextBox txtHORA;
        private DataGridViewButtonColumn BORRAR;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn HORA;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn ID_SALA;
    }
}