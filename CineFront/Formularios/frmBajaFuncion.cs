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

namespace CineFront.Formularios
{
    public partial class frmBajaFuncion : Form
    {
        public frmBajaFuncion()
        {
            InitializeComponent();
            cargarLasFunciones();
            dgvBajaFuncion.AllowUserToAddRows = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task EliminarFuncion(int id)
        {
            var url = "https://localhost:7180/EliminarFuncion?id=" + id;
            var result = await ClientSingleton.GetInstancia().DeleteAsync(url);


        }

        private void frmBajaFuncion_Load(object sender, EventArgs e)
        {
            dgvBajaFuncion.AllowUserToAddRows = false;
        }
        private async Task cargarLasFunciones()
        {

            string url = "https://localhost:7180/ConsultarFunciones";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Funciones>>(data);
            dgvBajaFuncion.DataSource = lst;
            if (lst == null)
            {
                MessageBox.Show("Sin datos de Funciones para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dgvBajaFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID;
            if (dgvBajaFuncion.CurrentCell.ColumnIndex == 0)
            {
                ID = Convert.ToInt32(dgvBajaFuncion.CurrentRow.Cells[1].Value);
                await EliminarFuncion(ID);
                cargarLasFunciones();


            }


        }
    }
}
