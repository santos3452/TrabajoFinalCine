namespace Front.Formularios
{
    partial class frmAltaDeCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grillaclientes = new DataGridView();
            ELIMINAR = new DataGridViewButtonColumn();
            EDITAR = new DataGridViewButtonColumn();
            button1 = new Button();
            btnGrabar = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            panel1 = new Panel();
            servicioBindingSource = new BindingSource(components);
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaclientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grillaclientes
            // 
            grillaclientes.BackgroundColor = Color.FromArgb(51, 51, 76);
            grillaclientes.BorderStyle = BorderStyle.None;
            grillaclientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grillaclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grillaclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaclientes.Columns.AddRange(new DataGridViewColumn[] { ELIMINAR, EDITAR });
            grillaclientes.EnableHeadersVisualStyles = false;
            grillaclientes.GridColor = Color.FromArgb(0, 150, 136);
            grillaclientes.Location = new Point(14, 320);
            grillaclientes.Margin = new Padding(3, 4, 3, 4);
            grillaclientes.Name = "grillaclientes";
            grillaclientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grillaclientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grillaclientes.RowHeadersVisible = false;
            grillaclientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            grillaclientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            grillaclientes.RowTemplate.Height = 25;
            grillaclientes.Size = new Size(989, 293);
            grillaclientes.TabIndex = 9;
            grillaclientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ELIMINAR
            // 
            ELIMINAR.FlatStyle = FlatStyle.Flat;
            ELIMINAR.HeaderText = "ELIMINAR";
            ELIMINAR.MinimumWidth = 6;
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseColumnTextForButtonValue = true;
            ELIMINAR.Width = 125;
            // 
            // EDITAR
            // 
            EDITAR.FlatStyle = FlatStyle.Flat;
            EDITAR.HeaderText = "EDITAR";
            EDITAR.MinimumWidth = 6;
            EDITAR.Name = "EDITAR";
            EDITAR.Text = "EDITAR";
            EDITAR.UseColumnTextForButtonValue = true;
            EDITAR.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(707, 269);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 5;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(849, 269);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(123, 43);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(849, 621);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(123, 52);
            button3.TabIndex = 8;
            button3.Text = "ACEPTAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(26, 108);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 6;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(281, 108);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 7;
            label2.Text = "APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(26, 196);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 8;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(390, 193);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 9;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(522, 111);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 10;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(336, 25);
            label6.Name = "label6";
            label6.Size = new Size(409, 45);
            label6.TabIndex = 11;
            label6.Text = "INGRESE LOS DATOS DEL CLIENTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 111);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 193);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(390, 111);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(470, 193);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(114, 27);
            txtDni.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(643, 111);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 27);
            txtTelefono.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 89);
            panel1.TabIndex = 17;
            // 
            // servicioBindingSource
            // 
            servicioBindingSource.DataSource = typeof(CineBack.services.implementaciones.Servicio);
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(565, 269);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(123, 43);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            btnActualizar.MouseClick += btnActualizar_MouseClick;
            // 
            // frmAltaDeCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1016, 689);
            Controls.Add(btnActualizar);
            Controls.Add(panel1);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnGrabar);
            Controls.Add(button1);
            Controls.Add(grillaclientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAltaDeCliente";
            Text = "frmAltaDeCliente";
            Load += frmAltaDeCliente_Load;
            ((System.ComponentModel.ISupportInitialize)grillaclientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaclientes;
        private Button button1;
        private Button btnGrabar;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private Panel panel1;
        private BindingSource servicioBindingSource;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewButtonColumn EDITAR;
        private Button btnActualizar;
    }
}