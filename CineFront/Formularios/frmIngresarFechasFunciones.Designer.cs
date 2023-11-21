namespace CineFront.Formularios
{
    partial class frmIngresarFechasFunciones
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
            rvIngresarFechasFunciones = new Microsoft.Reporting.WinForms.ReportViewer();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnConsultar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // rvIngresarFechasFunciones
            // 
            rvIngresarFechasFunciones.Location = new Point(25, 120);
            rvIngresarFechasFunciones.Name = "ReportViewer";
            rvIngresarFechasFunciones.ServerReport.BearerToken = null;
            rvIngresarFechasFunciones.Size = new Size(750, 300);
            rvIngresarFechasFunciones.TabIndex = 0;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(41, 44);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(346, 44);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(662, 44);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 58);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 99);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 351);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 150, 136);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 7;
            label1.Text = "Ingrese las fechas:";
            // 
            // frmIngresarFechasFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 150, 136);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(rvIngresarFechasFunciones);
            Controls.Add(panel3);
            Name = "frmIngresarFechasFunciones";
            Text = "frmIngresarFechasFunciones";
            Load += frmIngresarFechasFunciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvIngresarFechasFunciones;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnConsultar;
        private Panel panel3;
        private Label label1;
    }
}