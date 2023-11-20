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
            SuspendLayout();
            // 
            // rvIngresarFechasFunciones
            // 
            rvIngresarFechasFunciones.Location = new Point(25, 75);
            rvIngresarFechasFunciones.Name = "ReportViewer";
            rvIngresarFechasFunciones.ServerReport.BearerToken = null;
            rvIngresarFechasFunciones.Size = new Size(750, 350);
            rvIngresarFechasFunciones.TabIndex = 0;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(47, 25);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(360, 25);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(662, 23);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmIngresarFechasFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(rvIngresarFechasFunciones);
            Name = "frmIngresarFechasFunciones";
            Text = "frmIngresarFechasFunciones";
            Load += frmIngresarFechasFunciones_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvIngresarFechasFunciones;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnConsultar;
    }
}