﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            frmIngresar frm = new frmIngresar();
            frm.Show();
            this.Close();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            frmCrear frm = new frmCrear();
            frm.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Interval = 1000; // Configura el intervalo del timer a 1 segundo
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

    }
}
