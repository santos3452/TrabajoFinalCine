using CineBack.Entidades;
using CineBack.Http;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace CineFront.Formularios
{
    public partial class frmHistorialdeTicketsdelCliente : Form
    {
        Clientes clientes;
        public frmHistorialdeTicketsdelCliente()
        {
            InitializeComponent();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem != null && cboCliente.SelectedItem is Clientes clienteSeleccionado)
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
                cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public void CargarCombo()
        {

        }

        private async void frmHistorialdeTicketsdelCliente_Load(object sender, EventArgs e)
        {
            rvHistorialTicketsClientes.LocalReport.ReportEmbeddedResource = "CineFront.Formularios.Reportes.rptSeleccionar_Cliente.rdlc";
            rvHistorialTicketsClientes.RefreshReport();


            txtApellido.Enabled = false;
            txtNombre.Enabled = false;

            cboCliente.DropDownStyle = ComboBoxStyle.DropDown;
            cboCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            await ActualizarClientesEnComboBox();

            // Suscribir al evento SelectedIndexChanged del ComboBox
            cboCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;

        }
        private async Task<List<Clientes>> cargarlosclientes()
        {
            string url = "https://localhost:7180/ConsultarClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clientes>>(data);
            return lst;
        }

        private async Task ActualizarClientesEnComboBox()
        {
            var clientes = await cargarlosclientes();
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "DNI";
            cboCliente.ValueMember = "id_Cliente";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(cboCliente.Text);


            SqlConnection conexion = new SqlConnection(@"Data Source=BRANDON;Initial Catalog=CineDB24689123;Integrated Security=True");
            conexion.Open();
            SqlCommand command = new SqlCommand("SP_Seleccionar_Cliente", conexion);
            command.Parameters.AddWithValue("@DNI", DNI);

            command.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(command.ExecuteReader());

            rvHistorialTicketsClientes.LocalReport.DataSources.Clear();
            rvHistorialTicketsClientes.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));
            rvHistorialTicketsClientes.RefreshReport();

            conexion.Close();
        }
    }
}
