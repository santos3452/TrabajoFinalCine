using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Data;

namespace CineFront.Formularios
{
    public partial class frmIngresarFechasFunciones : Form
    {
        public frmIngresarFechasFunciones()
        {
            InitializeComponent();
        }

        private void frmIngresarFechasFunciones_Load(object sender, EventArgs e)
        {
            rvIngresarFechasFunciones.LocalReport.ReportEmbeddedResource = "CineFront.Formularios.Reportes.rptSeleccionarFechasFunciones.rdlc";
            rvIngresarFechasFunciones.RefreshReport();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            SqlConnection conexion = new SqlConnection(@"Data Source=BRANDON;Initial Catalog=CineDB24689123;Integrated Security=True");
            conexion.Open();
            SqlCommand command = new SqlCommand("SP_Seleccionar_Fechas_Funciones", conexion);
            command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@fechaHasta", fechaHasta);

            command.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(command.ExecuteReader());

            rvIngresarFechasFunciones.LocalReport.DataSources.Clear();
            rvIngresarFechasFunciones.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            rvIngresarFechasFunciones.RefreshReport();

            conexion.Close();
        }
    }
}
