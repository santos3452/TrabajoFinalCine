using CineBack.Entidades;
using CineBack.Http;
using Front.Formularios;
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

namespace CineFront.Formularios
{
    public partial class SeleccionarELCliente : Form
    {
        Clientes clientes;
        public SeleccionarELCliente()
        {
            InitializeComponent();
        }
        public bool validar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("EL CLIENTE NO SE ENCUENTRA REGISTRADO..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbDNI.DropDownStyle = ComboBoxStyle.DropDown;
            cmbDNI.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDNI.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDNI.SelectedIndex = -1;


        }

        private async Task<List<Clientes>> cargarlosclientes()
        {
            string url = "https://localhost:7180/ConsultarClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clientes>>(data);
            return lst;
        }

        private async void SeleccionarELCliente_Load(object sender, EventArgs e)
        {

            txtApellido.Enabled = false;
            txtNombre.Enabled = false;

            cmbDNI.DropDownStyle = ComboBoxStyle.DropDown;
            cmbDNI.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDNI.AutoCompleteSource = AutoCompleteSource.ListItems;

            await ActualizarClientesEnComboBox();

            // Suscribir al evento SelectedIndexChanged del ComboBox
            cmbDNI.SelectedIndexChanged += CmbDNI_SelectedIndexChanged;
        }

        private async Task ActualizarClientesEnComboBox()
        {
            var clientes = await cargarlosclientes();
            cmbDNI.DataSource = clientes;
            cmbDNI.DisplayMember = "DNI";
            cmbDNI.ValueMember = "id_Cliente";
        }

        private void CmbDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDNI.SelectedItem != null && cmbDNI.SelectedItem is Clientes clienteSeleccionado)
            {
                // Establecer los valores en los TextBox
                txtNombre.Text = clienteSeleccionado.NOMBRE;
                txtApellido.Text = clienteSeleccionado.APELLIDO;

                // Hacer los TextBox no editables y cambiar su apariencia visual
                txtNombre.ReadOnly = true;
                txtNombre.BackColor = SystemColors.Control;
                txtNombre.ForeColor = SystemColors.GrayText;

                txtApellido.ReadOnly = true;
                txtApellido.BackColor = SystemColors.Control;
                txtApellido.ForeColor = SystemColors.GrayText;

                // Hacer que el ComboBox no sea editable
                cmbDNI.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }

        private async void btnIrAticket_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                if (cmbDNI.SelectedItem is Clientes clienteSeleccionado)
                {
                    int idClienteSeleccionado = clienteSeleccionado.id_cliente; // Obtener el ID del cliente seleccionado

                    frmAltaTicket frm = new frmAltaTicket(idClienteSeleccionado);
                    frm.ShowDialog();


                    await ActualizarClientesEnComboBox();
                }

            }


        }

        private void btnIrAFormCliente_Click(object sender, EventArgs e)
        {
            frmAltaDeCliente frm = new frmAltaDeCliente();
            frm.Show();

        }

        private void cmbDNI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpear_Click(object sender, EventArgs e)
        {
            limpiar();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
