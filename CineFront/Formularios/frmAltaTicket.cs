using CineBack.Entidades;
using CineBack.Http;
using Newtonsoft.Json;
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
    public partial class frmAltaTicket : Form
    {
        Clientes clientes;
        private string datoformA;
        private readonly int idClienteSeleccionado;
        public frmAltaTicket(int datoSeleccionado)
        {
            InitializeComponent();

            this.idClienteSeleccionado = datoSeleccionado; // Guardar el ID del cliente seleccionado

            // Llamar a cargarlosclientes() después de inicializar los componentes

        }
        private async Task<List<Clientes>> cargarlosclientes()
        {
            string url = "https://localhost:7180/ConsultarClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var cliente = JsonConvert.DeserializeObject<List<Clientes>>(data);
            cmbClientSelec.DataSource = cliente;

            cmbClientSelec.DisplayMember = "DNI";
            cmbClientSelec.ValueMember = "id_Cliente";

            cmbClientSelec.SelectedValue = idClienteSeleccionado;
            if (cmbClientSelec.SelectedItem != null && cmbClientSelec.SelectedItem is Clientes clienteSeleccionado)
            {
                lblNOMBRE.Text = clienteSeleccionado.NOMBRE + "," + clienteSeleccionado.APELLIDO;
            }


            return cliente;
        }


        private void frmAltaTicket_Load(object sender, EventArgs e)
        {
            cargarlosclientes();
            cmbClientSelec.Enabled = false;



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
