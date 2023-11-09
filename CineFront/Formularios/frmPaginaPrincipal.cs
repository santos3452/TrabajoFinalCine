using CineFront;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Formularios
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstNostros.Items.Clear();
            frmAltaDeCliente frm = new frmAltaDeCliente();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNostros.Items.Clear();
            frmAltaTicket frm = new frmAltaTicket();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nosotros = "INTEGRANTES:  -[405306] Lozano Placido Brandon Agustin -[405003] López Forcellini Lautaro Daniel -[113970] Perren M Valentina -[113448] Virga, Santos Jose";

            string[] integrantes = nosotros.Split(new string[] { " -[" }, StringSplitOptions.RemoveEmptyEntries);


            lstNostros.Items.Clear();


            foreach (string integrante in integrantes)
            {
                lstNostros.Items.Add("-[" + integrante);
            }
        }

        private void lstNostros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            frm
        }
    }
}
