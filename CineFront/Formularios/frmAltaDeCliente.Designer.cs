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
            grillaclientes = new DataGridView();
            ELIMINAR = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)grillaclientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grillaclientes
            // 
            grillaclientes.BackgroundColor = SystemColors.ButtonFace;
            grillaclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaclientes.Columns.AddRange(new DataGridViewColumn[] { ELIMINAR });
            grillaclientes.Location = new Point(12, 240);
            grillaclientes.Name = "grillaclientes";
            grillaclientes.RowTemplate.Height = 25;
            grillaclientes.Size = new Size(776, 220);
            grillaclientes.TabIndex = 0;
            grillaclientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ELIMINAR
            // 
            ELIMINAR.FlatStyle = FlatStyle.Flat;
            ELIMINAR.HeaderText = "ELIMINAR";
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            button1.Location = new Point(479, 200);
            button1.Name = "button1";
            button1.Size = new Size(108, 32);
            button1.TabIndex = 1;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(643, 202);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 4;
            button2.Text = "GRABAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(643, 466);
            button3.Name = "button3";
            button3.Size = new Size(108, 39);
            button3.TabIndex = 5;
            button3.Text = "ACEPTAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(23, 81);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 6;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(246, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 7;
            label2.Text = "APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(23, 147);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 8;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(259, 147);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 9;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(457, 83);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 10;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(221, 19);
            label6.Name = "label6";
            label6.Size = new Size(322, 35);
            label6.TabIndex = 11;
            label6.Text = "INGRESE LOS DATOS DEL CLIENTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(341, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 14;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(341, 145);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(563, 83);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 17;
            // 
            // servicioBindingSource
            // 
            servicioBindingSource.DataSource = typeof(CineBack.services.implementaciones.Servicio);
            // 
            // frmAltaDeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(800, 517);
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
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grillaclientes);
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
        private Button button2;
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
    }
}