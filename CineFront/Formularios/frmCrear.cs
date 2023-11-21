using CineBack.Entidades;
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

namespace CineFront
{
    public partial class frmCrear : Form
    {
        public frmCrear()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();

            txtMail.Clear();

        }
        private bool validar()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (!Regex.IsMatch(txtMail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                string mail = txtMail.Text;

                Usuarios creacion = new Usuarios
                {
                    Usuario = usuario,
                    Contraseña = contraseña,
                    mail = mail
                };
                await Verificar(creacion);
            }
        }


        private async Task Verificar(Usuarios usuario)
        {
            string url = "https://localhost:7180/api/Usuario/creation";
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(usuario);

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var result = await client.PostAsync(url, content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario creado Correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Colocar otro Usuario");
                }
            }
        }

        private void frmCrear_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}
