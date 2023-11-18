using BackEnd.Dominio;
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
        private  int codigo_pelicula_seleccionado;
        public frmAltaTicket(int datoSeleccionado)
        {
            InitializeComponent();

            this.idClienteSeleccionado = datoSeleccionado; // Guarda el ID del cliente seleccionado



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
            CargarLasFormasDePago();
            CargarLasPeliculas();
            cmbPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboButaca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientSelec.Enabled = false;
          
        }

        private async Task BuscarFuncionPorID(int id)
        {
            var url = "https://localhost:7180/FuncionesPorID?id=" + id;
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<Funciones>>(data);

            cboFuncion.DataSource = forma;
            cboFuncion.DisplayMember = "codigo_funcion";
            cboFuncion.ValueMember = "codigo_funcion";


        }



        private async Task CargarLasPeliculas()
        {
            string url = "https://localhost:7180/Peliculas";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<Peliculas>>(data);

            cmbPeliculas.DataSource = forma;
            cmbPeliculas.DisplayMember = "nombre_pelicula";
            cmbPeliculas.ValueMember = "codigo_pelicula";

            cmbPeliculas.SelectedIndexChanged += async (sender, args) =>
            {
                if (cmbPeliculas.SelectedItem is Peliculas PeliculaSeleccionada)
                {
                    codigo_pelicula_seleccionado = PeliculaSeleccionada.codigo_pelicula; // Actualizar el ID de la película seleccionada
                    await BuscarFuncionPorID(codigo_pelicula_seleccionado);
                }
            };

        }


        private async Task CargarLasFormasDePago()
        {
            string url = "https://localhost:7180/FormasDePago";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<FormaDePago>>(data);

            cmbFormaPago.DataSource = forma;
            cmbFormaPago.DisplayMember = "descripcion";
            cmbFormaPago.ValueMember = "forma";
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
