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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 133);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(304, 49);
            label1.Name = "label1";
            label1.Size = new Size(280, 45);
            label1.TabIndex = 0;
            label1.Text = "DAR DE BAJA FUNCION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(dgvBajaFuncion);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 133);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 467);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvBajaFuncion
            // 
            dgvBajaFuncion.BackgroundColor = Color.FromArgb(51, 51, 76);
            dgvBajaFuncion.BorderStyle = BorderStyle.None;
            dgvBajaFuncion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBajaFuncion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBajaFuncion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBajaFuncion.Columns.AddRange(new DataGridViewColumn[] { BORRAR });
            dgvBajaFuncion.EnableHeadersVisualStyles = false;
            dgvBajaFuncion.GridColor = Color.FromArgb(0, 150, 136);
            dgvBajaFuncion.Location = new Point(14, 41);
            dgvBajaFuncion.Margin = new Padding(3, 4, 3, 4);
            dgvBajaFuncion.Name = "dgvBajaFuncion";
            dgvBajaFuncion.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBajaFuncion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBajaFuncion.RowHeadersVisible = false;
            dgvBajaFuncion.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvBajaFuncion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvBajaFuncion.RowTemplate.Height = 25;
            dgvBajaFuncion.Size = new Size(997, 388);
            dgvBajaFuncion.TabIndex = 1;
            dgvBajaFuncion.CellContentClick += dgvBajaFuncion_CellContentClick;
            // 
            // BORRAR
            // 
            BORRAR.HeaderText = "BORRAR";
            BORRAR.MinimumWidth = 6;
            BORRAR.Name = "BORRAR";
            BORRAR.ReadOnly = true;
            BORRAR.Text = "BORRAR";
            BORRAR.UseColumnTextForButtonValue = true;
            BORRAR.Width = 125;
            // 
            // frmBajaFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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