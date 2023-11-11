using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBack.Entidades;
using CineBack.services;
using CineBack.services.implementaciones;

namespace Front.Formularios
{
    public partial class frmAltaDeCliente : Form
    {
        private Clientes cliente;
        private Servicio gestor;
        public frmAltaDeCliente()
        {
            InitializeComponent();

            cliente = new Clientes();
        }


        private async Task cargarlosclientes()
        {
            string url = "https://localhost:7066/consultaClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clientes>>(data);
            dataGridView1.DataSource = lst;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAltaDeCliente_Load(object sender, EventArgs e)
        {
            cargarlosclientes();
        }
    }
}
