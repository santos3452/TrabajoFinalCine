namespace CineFront.Formularios
{
    partial class frmBajaFuncion
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dgvBajaFuncion = new DataGridView();
            BORRAR = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBajaFuncion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(266, 37);
            label1.Name = "label1";
            label1.Size = new Size(221, 35);
            label1.TabIndex = 0;
            label1.Text = "DAR DE BAJA FUNCION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(dgvBajaFuncion);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 350);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvBajaFuncion
            // 
            dgvBajaFuncion.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBajaFuncion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBajaFuncion.Columns.AddRange(new DataGridViewColumn[] { BORRAR });
            dgvBajaFuncion.Location = new Point(12, 31);
            dgvBajaFuncion.Name = "dgvBajaFuncion";
            dgvBajaFuncion.RowTemplate.Height = 25;
            dgvBajaFuncion.Size = new Size(872, 291);
            dgvBajaFuncion.TabIndex = 1;
            dgvBajaFuncion.CellContentClick += dgvBajaFuncion_CellContentClick;
            // 
            // BORRAR
            // 
            BORRAR.HeaderText = "BORRAR";
            BORRAR.Name = "BORRAR";
            BORRAR.ReadOnly = true;
            BORRAR.Text = "BORRAR";
            BORRAR.UseColumnTextForButtonValue = true;
            // 
            // frmBajaFuncion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmBajaFuncion";
            Text = "frmBajaFuncion";
            Load += frmBajaFuncion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBajaFuncion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvBajaFuncion;
        private DataGridViewButtonColumn BORRAR;
    }
}