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
        private TicketFactura Ticket;
        private string datoformA;
        private readonly int idClienteSeleccionado;
        private int codigo_pelicula_seleccionado;
        private int codigo_funcion_seleccionado;
        public frmAltaTicket(int datoSeleccionado)
        {
            InitializeComponent();
            Ticket = new TicketFactura();
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
            txtVALOR.Enabled = false;


        }
        private bool validar()
        {

            if (String.IsNullOrEmpty(txtVALOR.Text))
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR. Seleccione una funcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbPeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR. Seleccione una pelicula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //foreach (DataGridViewRow row in dgvTICKET.Rows)
            //{
            //    if (row.Cells["id_butaca"].Value.ToString().Equals(cboButaca.Text) & row.Cells["id_funcion"].Value.ToString().Equals(cboFuncion.Text))
            //    {
            //        MessageBox.Show("ERROR. Butaca ya reservada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //}

            return true;
        }

        private async Task BuscarFuncionPorID(int id)
        {
            var url = "https://localhost:7180/FuncionesPorID?id=" + id;
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<Funciones>>(data);

            cboFuncion.DataSource = forma;
            cboFuncion.DisplayMember = "CodigoFuncionFechaNombre";
            cboFuncion.ValueMember = "codigo_funcion";


        }
        private async Task MostrarButacasPorIDfuncion(int id)
        {
            var url = "https://localhost:7180/ButacasPorFuncion?id=" + id;
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<Butaca>>(data);

            cboButaca.DataSource = forma;
            cboButaca.DisplayMember = "numero";
            cboButaca.ValueMember = "id_butaca";


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

                    cboFuncion.SelectedIndexChanged += async (sender, args) =>
                    {
                        if (cboFuncion.SelectedItem is Funciones FuncionSeleccionada)
                        {
                            txtVALOR.Text = FuncionSeleccionada.precio.ToString();
                            codigo_funcion_seleccionado = FuncionSeleccionada.codigo_funcion; // Actualizar el ID de la Funciion seleccionada
                            await MostrarButacasPorIDfuncion(codigo_funcion_seleccionado);

                        }

                    };


                }
            };



        }

        //private async Task<bool> InsertarTicket()
        //{
        //    Ticket.Pago = cboTipoPagos.SelectedIndex + 1;
        //    oTicket.Cliente = cboClientes.SelectedIndex + 1;

        //    var bodyContent = JsonConvert.SerializeObject(oTicket);
        //    string url = "https://localhost:7066/Ticket22";
        //    var result = await ClientSingleton.GetInstancia().PostAsync(url, bodyContent);
        //    if (result.Equals("true"))
        //    {
        //        MessageBox.Show("INSERTADO CORRECTAMENTE");
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("ERROR INTERNO, CONTACTE UN ADMINISTRADOR");
        //        return false;
        //    }
        //}

        private async Task CargarLasFormasDePago()
        {
            string url = "https://localhost:7180/FormasDePago";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<FormaDePago>>(data);

            cmbFormaPago.DataSource = forma;
            cmbFormaPago.DisplayMember = "descripcion";
            cmbFormaPago.ValueMember = "forma";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Clientes clientes = (Clientes)cmbClientSelec.SelectedItem;
                clientes.id_cliente = (int)cmbClientSelec.SelectedValue;
                FormaDePago tp = (FormaDePago)cmbFormaPago.SelectedItem;
                string nombrepeli = cmbPeliculas.SelectedItem.ToString();
                int Funcion = Convert.ToInt32(cboFuncion.SelectedValue);
                decimal precio = decimal.Parse(txtVALOR.Text);
                int Butaca = (int)cboButaca.SelectedIndex + 1;
                int precioEntero = Convert.ToInt32(precio);


                DetalleTicketFactura dt = new DetalleTicketFactura(Funcion, Butaca, precioEntero, Funcion);
                Ticket.AgregarDetalle(dt);
                dgvTICKET.Rows.Add(new object[] { clientes.NOMBRE, clientes.APELLIDO, tp.descripcion, dt.id_funcion, nombrepeli, dt.id_butaca, dt.precio });
            }
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

        private void txtVALOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
