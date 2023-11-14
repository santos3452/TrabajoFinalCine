using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBack.Entidades;
using CineBack.Http;
using CineBack.services;
using CineBack.services.implementaciones;
using Newtonsoft.Json;

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



        private bool validar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDni.Text.Length > 10)
            {
                MessageBox.Show("ERROR. El N° de DNI solo puede tener 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.TryParse(txtDni.Text, out int a) == false)
            {
                MessageBox.Show("ERROR. Ingrese solo numeros en el N° de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo válido");
                txtEmail.Clear();
                return false;

            }


            return true;
        }


        private async Task insertarClientesAsync()
        {

            validar();
            cliente.NOMBRE = txtNombre.Text;
            cliente.APELLIDO = txtApellido.Text;
            cliente.DNI = Convert.ToInt64(txtDni.Text);
            cliente.EMAIL = txtEmail.Text;
            cliente.TELEFONO = Convert.ToInt64(txtTelefono.Text);

            string bodyContent = JsonConvert.SerializeObject(cliente);
            string url = "https://localhost:7180/PostCliente";
            var result = await ClientSingleton.GetInstancia().PostAsync(url, bodyContent);

            if (result.Equals("1"))
            {
                MessageBox.Show("Cliente Registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarlosclientes();
            }
            else
            {
                MessageBox.Show("HUBO UN ERROR AL REGISTRAR EL CLIENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task cargarlosclientes()
        {
            string url = "https://localhost:7180/ConsultarClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clientes>>(data);
            grillaclientes.DataSource = lst;
            if (lst == null)
            {
                MessageBox.Show("Sin datos de clientes para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private async Task eliminarCliente(int id)
        {
            var url = "https://localhost:7180/EliminarCliente?id=" + id;
            var result = await ClientSingleton.GetInstancia().DeleteAsync(url);


        }



        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";

        }



        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID;
            if (grillaclientes.CurrentCell.ColumnIndex == 0)
            {
                ID = Convert.ToInt32(grillaclientes.CurrentRow.Cells[1].Value);
                await eliminarCliente(ID);

                //grillaclientes.Rows.Remove(grillaclientes.CurrentRow);
            }
            cargarlosclientes();

        }

        private void frmAltaDeCliente_Load(object sender, EventArgs e)
        {
            cargarlosclientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
