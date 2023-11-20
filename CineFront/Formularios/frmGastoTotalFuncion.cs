using CineBack.Entidades;
using CineBack.Http;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Formularios
{
    public partial class frmGastoTotalFuncion : Form
    {
        public frmGastoTotalFuncion()
        {
            InitializeComponent();
        }

        private void frmGastoTotalFuncion_Load(object sender, EventArgs e)
        {
            rvGastoTotalFuncion.LocalReport.ReportEmbeddedResource = "CineFront.Formularios.Reportes.rptGastoTotalFuncion.rdlc";
            rvGastoTotalFuncion.RefreshReport();

            cargarLasFunciones();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id_funcion = Convert.ToInt32(cboFuncion.SelectedValue);


            SqlConnection conexion = new SqlConnection(@"Data Source=BRANDON;Initial Catalog=CineDB24689123;Integrated Security=True");
            conexion.Open();
            SqlCommand command = new SqlCommand("SP_Cliente_MasGastado_Funcion", conexion);
            command.Parameters.AddWithValue("@id_funcion", id_funcion);

            command.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(command.ExecuteReader());

            rvGastoTotalFuncion.LocalReport.DataSources.Clear();
            rvGastoTotalFuncion.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            rvGastoTotalFuncion.RefreshReport();

            conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private async Task cargarLasFunciones()
        {

            string url = "https://localhost:7180/ConsultarFuncionesALL";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Funciones>>(data);
            cboFuncion.DataSource = lst;
            cboFuncion.DisplayMember = "codigo_funcion";
            cboFuncion.ValueMember = "codigo_funcion";
        }
    }
}
