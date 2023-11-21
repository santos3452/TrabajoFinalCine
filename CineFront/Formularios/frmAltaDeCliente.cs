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
            if (txtDni.Text.Length > 9)
            {
                MessageBox.Show("ERROR. El N° de DNI  puede tener hasta 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Int32.TryParse(txtDni.Text, out int a) == false)
            {
                MessageBox.Show("ERROR. Ingrese solo numeros en el N° de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (DataGridViewRow row in grillaclientes.Rows)
            {
                if (row.Cells["Dni"].Value.ToString().Equals(txtDni.Text))
                {
                    string valorCelda = row.Cells["id_cliente"].Value.ToString();
                    MessageBox.Show("Este cliente ya ha sido registrado" + "Es el ID: " + valorCelda, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (!Regex.IsMatch(txtNombre.Text, @"^[^\d]+$"))
            {
                MessageBox.Show("Ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtApellido.Text, @"^[^\d]+$"))
            {
                MessageBox.Show("Ingrese un apellido válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regex.IsMatch(txtTelefono.Text, @"^[^\d]+$"))
            {
                MessageBox.Show("Ingrese un apellido válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }


        private bool validarbtnActualizar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDni.Text.Length > 9)
            {
                MessageBox.Show("ERROR. El N° de DNI  puede tener hasta 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Int32.TryParse(txtDni.Text, out int a) == false)
            {
                MessageBox.Show("ERROR. Ingrese solo numeros en el N° de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (!Regex.IsMatch(txtNombre.Text, @"^[^\d]+$"))
            {
                MessageBox.Show("Ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtApellido.Text, @"^[^\d]+$"))
            {
                MessageBox.Show("Ingrese un apellido válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regex.IsMatch(txtTelefono.Text, @"^[^\d]+$"))
            {
                MessageBox.Show("Ingrese un apellido válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }



        private async Task insertarClientesAsync()
        {


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
                MessageBox.Show("Cliente Registrado exitosamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ID = Convert.ToInt32(grillaclientes.CurrentRow.Cells[2].Value);
                await eliminarCliente(ID);
                cargarlosclientes();

                //grillaclientes.Rows.Remove(grillaclientes.CurrentRow);
            }

            if (grillaclientes.CurrentCell.ColumnIndex == 1)
            {
                txtDni.Enabled = false;
                btnGrabar.Visible = false;
                btnActualizar.Visible = true;
                txtNombre.Text = grillaclientes.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = grillaclientes.CurrentRow.Cells["APELLIDO"].Value.ToString();
                txtTelefono.Text = grillaclientes.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txtEmail.Text = grillaclientes.CurrentRow.Cells["EMAIL"].Value.ToString();
                txtDni.Text = grillaclientes.CurrentRow.Cells["DNI"].Value.ToString();


            }





        }

        private void frmAltaDeCliente_Load(object sender, EventArgs e)
        {
            grillaclientes.AllowUserToAddRows = false;
            cargarlosclientes();
            btnActualizar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiar();
                if (btnActualizar.Visible = true)
                {
                    btnActualizar.Visible = false;
                    btnGrabar.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                insertarClientesAsync();
                limpiar();
                btnGrabar.Visible = true;
                btnActualizar.Visible = false;
                cargarlosclientes();
            }

        }



        private async Task ActualizarClientesAsync()
        {


            cliente.id_cliente = Convert.ToInt32(grillaclientes.CurrentRow.Cells[2].Value);
            cliente.NOMBRE = txtNombre.Text;
            cliente.APELLIDO = txtApellido.Text;
            cliente.DNI = long.Parse(txtDni.Text);
            cliente.EMAIL = txtEmail.Text;
            cliente.TELEFONO = long.Parse(txtTelefono.Text);


            string bodyContent = JsonConvert.SerializeObject(cliente);
            string url = "https://localhost:7180/ActualizarCliente";
            var result = await ClientSingleton.GetInstancia().PutAsync(url, bodyContent);


            if (result.Equals("true"))
            {
                MessageBox.Show("Cliente actualizado exitosamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarlosclientes();

            }
            else
            {
                MessageBox.Show("HUBO UN ERROR AL ACTUALIZAR EL CLIENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnActualizar_MouseClick(object sender, MouseEventArgs e)
        {
            txtDni.Enabled = true;

            if (validarbtnActualizar())
            {
                ActualizarClientesAsync();
                limpiar();
                btnGrabar.Visible = true;
                btnActualizar.Visible = false;
            }





        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {


            this.Close();

        }
    }
}
