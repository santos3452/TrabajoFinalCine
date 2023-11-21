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
            panelsubmenu1.Visible = false;
        }
        private void esconderMenu()
        {

            if (panelsubmenu.Visible == true)
            {
                panelsubmenu.Visible = false;
            }
        }
        private void esconderMenu2()
        {

            if (panelsubmenu1.Visible == true)
            {
                panelsubmenu1.Visible = false;
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
            frmHistorialdeTicketsdelCliente frm = new frmHistorialdeTicketsdelCliente();
            frm.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

            frmAltaDeCliente frm = new frmAltaDeCliente();
            frm.Show();
            esconderMenu();
            esconderMenu2();
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu1);

            esconderMenu();



        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            SeleccionarELCliente frm = new SeleccionarELCliente();
            frm.Show();
            esconderMenu();
            esconderMenu2();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu);
            esconderMenu2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nosotros = "INTEGRANTES:  -[405306] Lozano Placido Brandon Agustin -[405003] López Forcellini Lautaro Daniel -[113970] Perren M Valentina -[113448] Virga, Santos Jose";

            string[] integrantes = nosotros.Split(new string[] { " -[" }, StringSplitOptions.RemoveEmptyEntries);



        }

        private void panelsubmenu1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFunciones frm = new frmFunciones();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmBajaFuncion frm = new frmBajaFuncion();
            frm.Show();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            frmGastoTotalFuncion frm = new frmGastoTotalFuncion();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmIngresarFechasFunciones frm = new frmIngresarFechasFunciones();
            frm.Show();
        }
    }
}
