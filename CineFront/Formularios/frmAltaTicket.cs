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
using System.Numerics;
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
        decimal totalPrecios = 0;
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


        private async void frmAltaTicket_Load(object sender, EventArgs e)
        {
            await cargarlosclientes();
            await CargarLasFormasDePago();
            await CargarLasPeliculas();
            ProximoIDticket();
            txtTotal.Enabled = false;
            dgvTICKET.AllowUserToAddRows = false;
            cmbPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboButaca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientSelec.Enabled = false;
            txtVALOR.Enabled = false;
            int anchoDeseado = 200; // Ancho que deseas establecer
            dgvTICKET.Columns["PELICULA"].Width = anchoDeseado;
            int anchoDeseado1 = 80; // Ancho que deseas establecer
            dgvTICKET.Columns["FECHA"].Width = anchoDeseado1;
            int anchoDeseado2 = 100; // Ancho que deseas establecer
            dgvTICKET.Columns["FUNCION"].Width = anchoDeseado2;



            txtTotal.Text = totalPrecios.ToString();


        }
        private async void ProximoIDticket()
        {
            int num = await ProximoID();
            lblTICKET.Text = "GENERAR TICKET NRO: " + num;
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
            object idSeleccionado = cboFuncion.SelectedValue;
            int id = (int)idSeleccionado;

            foreach (DataGridViewRow row in dgvTICKET.Rows)
            {
                if (row.Cells["BUTACA"].Value.ToString().Equals(cboButaca.Text) && row.Cells["FUNCION"].Value.Equals(id))
                {
                    MessageBox.Show("ERROR. Butaca ya reservada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

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
        private async Task<int> ProximoID()
        {
            string url = "https://localhost:7180/ProximoID";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<int>(data);
            return forma;

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

        private async Task<bool> InsertarTicket()
        {



            Ticket.id_forma = cmbFormaPago.SelectedIndex + 1;
            Ticket.id_cliente = cmbClientSelec.SelectedIndex + 1;
            Ticket.totalfinal = decimal.Parse(txtTotal.Text);


            var bodyContent = JsonConvert.SerializeObject(Ticket);
            string url = "https://localhost:7180/InsertarTicket";
            var result = await ClientSingleton.GetInstancia().PostAsync(url, bodyContent);
            if (result.Equals("true"))
            {
                MessageBox.Show("INSERTADO CORRECTAMENTE");
                return true;
            }
            else
            {
                MessageBox.Show("HAY UN ERROR EN EL INGRESO DE TICKET. INTENTE NUEVAMENTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }





        }

        private async Task CargarLasFormasDePago()
        {
            string url = "https://localhost:7180/FormasDePago";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<FormaDePago>>(data);

            cmbFormaPago.DataSource = forma;
            cmbFormaPago.DisplayMember = "descripcion";
            cmbFormaPago.ValueMember = "id_formapago";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {



                Peliculas PeliculaSeleccionada = (Peliculas)cmbPeliculas.SelectedItem;
                Clientes clientes = (Clientes)cmbClientSelec.SelectedItem;
                clientes.id_cliente = (int)cmbClientSelec.SelectedValue;
                FormaDePago tp = (FormaDePago)cmbFormaPago.SelectedItem;
                Funciones f = (Funciones)cboFuncion.SelectedItem;

                string hora = f.HoraPeli;
                DateTime? fecha = f.fecha;
                string nombrepeli = PeliculaSeleccionada.nombre_pelicula.ToString();
                int Funcion = Convert.ToInt32(cboFuncion.SelectedValue);
                decimal precio = decimal.Parse(txtVALOR.Text);
                int Butaca = (int)cboButaca.SelectedIndex + 1;
                int precioTotal = Convert.ToInt32(precio);


                DetalleTicketFactura dt = new DetalleTicketFactura(Butaca, precioTotal, 1, Funcion);
                Ticket.AgregarDetalle(dt);
                dgvTICKET.Rows.Add(new object[] { "", clientes.NOMBRE, clientes.APELLIDO, tp.descripcion, dt.id_funcion, nombrepeli, hora, fecha, dt.id_butaca, dt.precio });

                totalPrecios += Convert.ToInt32(txtVALOR.Text);
                txtTotal.Text = totalPrecios.ToString();


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

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dgvTICKET.Rows.Count >= 1)
            {
                await InsertarTicket();



                Ticket.Detalle.Clear();
                ProximoIDticket();


                dgvTICKET.Rows.Clear();


            }
            else
            {

                MessageBox.Show("NO AGREGO NINGUN TICKET. INTENTE NUEVAMENTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void dgvTICKET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTICKET.CurrentCell.ColumnIndex == 0)
            {
                Ticket.QuitarDetalle(dgvTICKET.CurrentRow.Index);

                if (e.ColumnIndex == 0 && e.RowIndex != -1)
                {


                    if (dgvTICKET.Rows[e.RowIndex].Cells["VALOR"].Value != null && decimal.TryParse(dgvTICKET.Rows[e.RowIndex].Cells["VALOR"].Value.ToString(), out decimal valor))
                    {


                        decimal totalActual = decimal.Parse(txtTotal.Text);
                        totalActual = totalActual - valor;
                        totalPrecios = totalPrecios - valor;


                        txtTotal.Text = totalActual.ToString();


                        dgvTICKET.Rows.RemoveAt(e.RowIndex);



                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            dgvTICKET.Rows.Clear();
            cboButaca.SelectedIndex = -1;
            cboFuncion.SelectedIndex = -1;
            txtVALOR.Text = string.Empty;
            Ticket.Detalle.Clear();
        }
    }
}
