using CineFront;
using CineFront.Formularios;
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
            costumizar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void costumizar()
        {
            panelsubmenu.Visible = false;
        }
        private void esconderMenu()
        {

            if (panelsubmenu.Visible == true)
            {
                panelsubmenu.Visible = false;
            }
        }
        public void mostrarsubmenu(Panel subMenu)

        {
            if (subMenu.Visible == false)
            {
                esconderMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void lstNostros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            lstNostros.Items.Clear();
            SeleccionarELCliente frm = new SeleccionarELCliente();
            frm.Show();
            esconderMenu();
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            string nosotros = "INTEGRANTES:  -[405306] Lozano Placido Brandon Agustin -[405003] López Forcellini Lautaro Daniel -[113970] Perren M Valentina -[113448] Virga, Santos Jose";

            string[] integrantes = nosotros.Split(new string[] { " -[" }, StringSplitOptions.RemoveEmptyEntries);


            lstNostros.Items.Clear();


            foreach (string integrante in integrantes)
            {
                lstNostros.Items.Add("-[" + integrante);
            }
            esconderMenu();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            lstNostros.Items.Clear();
            frmAltaDeCliente frm = new frmAltaDeCliente();
            frm.Show();
            esconderMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu);
        }
    }
}
