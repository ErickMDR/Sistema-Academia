using Sistema_Academia.Datos;
using Sistema_Academia.Presentacion;
using Sistema_Academia.Presentacion.Agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMenuNotas : Form
    {
        public FormMenuNotas()
        {
            InitializeComponent();
            asignar.Click -= asignar_Click;
            asignar.Click += asignar_Click;

            WindowState = FormWindowState.Maximized;
            CargarDatosNotas();
        }

        private void asignar_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Evento click llamado desde: {new System.Diagnostics.StackTrace()}");
            using var form = new FormInscribir();
            if (form.ShowDialog(this) == DialogResult.OK && form.InscripcionExitosa)
            {
                CargarDatosNotas();
            }
        }

        private void CargarDatosNotas()
        {
            try
            {
                using (var tablaNotas = new TablaNotas())
                {
                    dataGridViewTabla.DataSource = tablaNotas.Listado();
                }
                AgregarHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarHeaders()
        {
            try
            {
                dataGridViewTabla.Columns[0].HeaderText = "Cédula";
                dataGridViewTabla.Columns[1].HeaderText = "Nombre";
                dataGridViewTabla.Columns[2].HeaderText = "Apellido";
                dataGridViewTabla.Columns[3].HeaderText = "Materia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
