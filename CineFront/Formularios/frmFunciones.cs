﻿using BackEnd.Dominio;
using CineBack.Entidades;
using CineBack.Http;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CineFront.Formularios
{
    public partial class frmFunciones : Form
    {
        DateTime hoy = DateTime.Now;
        List<Funciones> listaDeFunciones = new List<Funciones>();
        public frmFunciones()
        {
            InitializeComponent();
        }

        private void frmFunciones_Load(object sender, EventArgs e)
        {

            CargarLasPeliculas();
            CargarLasSalas();
            dtvFunciones.AllowUserToAddRows = false;
            txtHORA.Text = hoy.ToString("hh:mm:ss");
            int anchoDeseado = 200; // Ancho que deseas establecer
            dtvFunciones.Columns["NOMBRE"].Width = anchoDeseado;
            int anchoDeseado1 = 75; // Ancho que deseas establecer
            dtvFunciones.Columns["FECHA"].Width = anchoDeseado1;
            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dtPICKER.Value.Date;

            // Establecer la hora en 00:00:00 (medianoche)
            dtPICKER.Value = fechaSeleccionada;
        }

        private async Task CargarLasPeliculas()
        {
            string url = "https://localhost:7180/Peliculas1";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<Peliculas>>(data);

            cboPeliculas.DataSource = forma;
            cboPeliculas.DisplayMember = "nombre_pelicula";
            cboPeliculas.ValueMember = "codigo_pelicula";


        }

        private async Task CargarLasSalas()
        {
            string url = "https://localhost:7180/ObtenerSalas";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var forma = JsonConvert.DeserializeObject<List<Salas>>(data);

            cboSalas.DataSource = forma;
            cboSalas.DisplayMember = "id_sala";
            cboSalas.ValueMember = "id_sala";


        }
        private async Task<bool> InsertarFunciones(List<Funciones> ListaDeFunciones)
        { if (dtvFunciones.RowCount > 0)
            {



                var bodyContent = JsonConvert.SerializeObject(ListaDeFunciones);
                string url = "https://localhost:7180/InsertarFunciones";
                var result = await ClientSingleton.GetInstancia().PostAsync(url, bodyContent);

                if (result.Equals("true"))
                {
                    MessageBox.Show("INSERTADO CORRECTAMENTE");
                    return true;
                }
                else
                {
                    MessageBox.Show("HUBO UN ERROR AL INSERTAR");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("La grilla está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }




        private bool validar()
        {
            if (dtPICKER.Value.Date < DateTime.Today)
            {
                MessageBox.Show("No se puede seleccionar una fecha que ya ha pasado. Por favor, seleccione una fecha a partir de mañana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("ERROR. Tiene que insertar el precio a la funcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidarFormatoHora(txtHORA.Text))
            {
                MessageBox.Show("Hora inválida. Ingrese la hora en formato hh:mm:ss.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtPrecio.Text, @"^\d+$"))
            {
                MessageBox.Show("Ingrese solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            foreach (DataGridViewRow row in dtvFunciones.Rows)
            {


                string fechaCelda = row.Cells["FECHA"].Value?.ToString(); // Obtener valor de la celda FECHA como string
                string horaCelda = row.Cells["HORA"].Value?.ToString(); // Obtener valor de la celda HORA como string
                int salaCelda = Convert.ToInt32(row.Cells["ID_SALA"].Value); // Obtener valor de la celda SALA como entero
                object idSeleccionado = cboSalas.SelectedValue;
                int id = (int)idSeleccionado;


                DateTime fechaPicker = dtPICKER.Value.Date; // Obtener fecha del DateTimePicker
                string horaTxt = txtHORA.Text; // Obtener hora del TextBox (asumiendo que txtHORA.Text es un string)

                // Comparar los valores después de convertirlos a los tipos de datos apropiados
                if (fechaCelda == fechaPicker.ToString("yyyy-MM-dd") && horaCelda == horaTxt && salaCelda == id)
                {
                    MessageBox.Show("ERROR. No puede poner dos veces la misma función con el mismo horario/fecha/sala", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }



            return true;



        }


        private bool ValidarFormatoHora(string hora)
        {
            return DateTime.TryParseExact(hora, "hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {



                string nombrePeliculaSeleccionada;
                Peliculas peliculaSeleccionada = (Peliculas)cboPeliculas.SelectedItem;
                nombrePeliculaSeleccionada = peliculaSeleccionada.nombre_pelicula;
                object idSeleccionado = cboPeliculas.SelectedValue;
                int id = (int)idSeleccionado;
                int codigo_pelicula = id;
                DateTime? fecha = dtPICKER.Value;
                string HoraPeli = txtHORA.Text;
                int precio = Convert.ToInt32(txtPrecio.Text);
                object idSeleccionado1 = cboSalas.SelectedValue;
                int id1 = (int)idSeleccionado1;
                int id_sala = id1;


                Funciones f = new Funciones(codigo_pelicula, fecha, HoraPeli, precio, id_sala);
                listaDeFunciones.Add(f);


                dtvFunciones.Rows.Add(new object[] { "", nombrePeliculaSeleccionada, f.fecha, f.HoraPeli, f.precio, f.id_sala });


            }



        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarFunciones(listaDeFunciones);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvFunciones.CurrentCell.ColumnIndex == 0)
            {
                dtvFunciones.Rows.RemoveAt(e.RowIndex);
                listaDeFunciones.RemoveAt(e.RowIndex);

            }
        }
    }
}
