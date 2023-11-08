namespace CineFront
{
    partial class frmInicio
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
            BtnIngresar = new Button();
            BtnCrear = new Button();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(314, 132);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(144, 23);
            BtnIngresar.TabIndex = 0;
            BtnIngresar.Text = "Ingresar Cuenta";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(314, 237);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(144, 23);
            BtnCrear.TabIndex = 1;
            BtnCrear.Text = "Crear Cuenta";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCrear);
            Controls.Add(BtnIngresar);
            Name = "frmInicio";
            Text = "Inicio";
            Load += frmInicio_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIngresar;
        private Button BtnCrear;
    }
}