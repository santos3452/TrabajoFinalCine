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
            SuspendLayout();
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(27, 24);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(125, 28);
            cboCliente.TabIndex = 0;
            cboCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // rvHistorialTicketsClientes
            // 
            rvHistorialTicketsClientes.AutoSize = true;
            rvHistorialTicketsClientes.Location = new Point(25, 75);
            rvHistorialTicketsClientes.Name = "ReportViewer";
            rvHistorialTicketsClientes.ServerReport.BearerToken = null;
            rvHistorialTicketsClientes.Size = new Size(750, 350);
            rvHistorialTicketsClientes.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(611, 24);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(109, 29);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(399, 24);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(172, 27);
            txtApellido.TabIndex = 3;
            // 
            // frmHistorialdeTicketsdelCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnConsultar);
            Controls.Add(rvHistorialTicketsClientes);
            Controls.Add(cboCliente);
            Name = "frmHistorialdeTicketsdelCliente";
            Text = "frmHistorialdeTicketsdelCliente";
            Load += frmHistorialdeTicketsdelCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCliente;
        private Microsoft.Reporting.WinForms.ReportViewer rvHistorialTicketsClientes;
        private Button btnConsultar;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}