namespace CineFront.Formularios
{
    partial class frmGastoTotalFuncion
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
            rvGastoTotalFuncion = new Microsoft.Reporting.WinForms.ReportViewer();
            btnConsultar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            cboFuncion = new ComboBox();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // rvGastoTotalFuncion
            // 
            rvGastoTotalFuncion.Location = new Point(25, 120);
            rvGastoTotalFuncion.Name = "ReportViewer";
            rvGastoTotalFuncion.ServerReport.BearerToken = null;
            rvGastoTotalFuncion.Size = new Size(750, 300);
            rvGastoTotalFuncion.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(674, 35);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 150, 136);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(299, 31);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el num. de Funcion:";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(cboFuncion);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 104);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // cboFuncion
            // 
            cboFuncion.FormattingEnabled = true;
            cboFuncion.Location = new Point(331, 35);
            cboFuncion.Name = "cboFuncion";
            cboFuncion.Size = new Size(151, 28);
            cboFuncion.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 58);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 99);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 351);
            panel3.TabIndex = 5;
            // 
            // frmGastoTotalFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 150, 136);
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultar);
            Controls.Add(rvGastoTotalFuncion);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "frmGastoTotalFuncion";
            Text = "frmGastoTotalFuncion";
            Load += frmGastoTotalFuncion_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGastoTotalFuncion;
        private Button btnConsultar;
        private Label label1;
        private Panel panel2;
        private ComboBox cboFuncion;
        private Panel panel3;
    }
}