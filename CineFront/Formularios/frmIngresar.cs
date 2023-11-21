using Front.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBack.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineFront
{
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio.GetInstancia().Show();  
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        { 
            
            if (validar())
            
            {

                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                Usuarios credenciales = new Usuarios
                {
                    Usuario = usuario,
                    Contraseña = contraseña,
                    mail = ""
                };
                await Verificar(credenciales);
            }
           
           
        }
        private async Task Verificar(Usuarios usuario)
        {


            string url = "https://localhost:7180/api/Usuario/Auth";
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(usuario);

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var result = await client.PostAsync(url, content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Bienvenido " + usuario.Usuario);
                    PaginaPrincipal frm = new PaginaPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos de usuario o contraseña incorrecto");
                }
            }
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;

        }
    }
}
