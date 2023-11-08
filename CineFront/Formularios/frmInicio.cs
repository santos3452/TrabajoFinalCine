using System;
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
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            frmCrear frm = new frmCrear();
            frm.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
