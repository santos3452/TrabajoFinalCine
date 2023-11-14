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

namespace CineFront
{
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y la contraseña desde los campos de texto en el formulario
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            PaginaPrincipal frm = new PaginaPrincipal();
            frm.Show();


            //// Crear una instancia de HttpClient, que se utiliza para realizar solicitudes HTTP
            //using (HttpClient client = new HttpClient())
            //{



            //    // Crear una instancia de la clase Usuarios y asignarle el usuario y la contraseña
            //    //Usuarios credenciales = new Usuarios
            //    //{
            //    //    Usuario = usuario,
            //    //    Contraseña = contraseña
            //    //};

            //    //// Realizar una solicitud HTTP POST al endpoint "https://tuapiruta/api/usuarios/verificar"
            //    //// y enviar las credenciales en el cuerpo de la solicitud en formato JSON
            //    //HttpResponseMessage response = await client.PostAsJsonAsync("https://tuapiruta/api/usuarios/verificar", credenciales);

            //    //// Verificar si la solicitud fue exitosa (código de estado HTTP 2xx)
            //    //if (response.IsSuccessStatusCode)
            //    //{
            //    //    // Ingresa a la pagina de inicio
            //    //    PaginaPrincipal frm = new PaginaPrincipal();
            //    //    frm.Show();
            //    //    this.Close();
            //    //}
            //    //else
            //    //{
            //    //    // Mostrar un mensaje de error si las credenciales no son válidas
            //    //    MessageBox.Show("Usuario no encontrado");

            //    //}
            //}
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {

        }
    }
}
