namespace CineFront.Formularios
{
    partial class frmHistorialdeTicketsdelCliente
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
            cboCliente = new ComboBox();
            rvHistorialTicketsClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            btnConsultar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(50, 50);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(170, 28);
            cboCliente.TabIndex = 0;
            cboCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // rvHistorialTicketsClientes
            // 
            rvHistorialTicketsClientes.AutoSize = true;
            rvHistorialTicketsClientes.Location = new Point(25, 120);
            rvHistorialTicketsClientes.Name = "ReportViewer";
            rvHistorialTicketsClientes.ServerReport.BearerToken = null;
            rvHistorialTicketsClientes.Size = new Size(750, 300);
            rvHistorialTicketsClientes.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(674, 50);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(109, 29);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(250, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(466, 50);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(172, 27);
            txtApellido.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 58);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 99);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 351);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 23);
            label2.Name = "label2";
            label2.Size = new Size(90, 45);
            label2.TabIndex = 5;
            label2.Text = "INICIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 150, 136);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 31);
            label1.TabIndex = 5;
            label1.Text = "Seleccione el documento del Cliente:";
            // 
            // frmHistorialdeTicketsdelCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 150, 136);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnConsultar);
            Controls.Add(rvHistorialTicketsClientes);
            Controls.Add(cboCliente);
            Controls.Add(panel3);
            Name = "frmHistorialdeTicketsdelCliente";
            Text = "frmHistorialdeTicketsdelCliente";
            Load += frmHistorialdeTicketsdelCliente_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCliente;
        private Microsoft.Reporting.WinForms.ReportViewer rvHistorialTicketsClientes;
        private Button btnConsultar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Panel panel3;
        private Label label2;
        private Label label1;
    }
}