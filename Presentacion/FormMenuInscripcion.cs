using Sistema_Academia.Datos;
using Sistema_Academia.Presentacion.Agregar;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMenuInscripcion : Form
    {
        public FormMenuInscripcion()
        {
            InitializeComponent();

            inscribir.Click -= inscribir_Click_1;
            inscribir.Click += inscribir_Click_1;

            WindowState = FormWindowState.Maximized;
            CargarDatosInscritos();
        }
  
        private void CargarDatosInscritos()
        {
            try
            {
                using var tablaInscripcion = new TablaInscripcion();
                dataGridViewTabla.DataSource = tablaInscripcion.Listado();
                AgregarHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AgregarHeaders()
        {
            try
            {
                dataGridViewTabla.Columns["persona_ci"].HeaderText = "Cédula";
                dataGridViewTabla.Columns["persona_no"].HeaderText = "Nombre";
                dataGridViewTabla.Columns["persona_ap"].HeaderText = "Apellido";
                dataGridViewTabla.Columns["materia_de"].HeaderText = "Materia";
                dataGridViewTabla.Columns["seccion_de"].HeaderText = "Sección";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inscribir_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine($"Evento click llamado desde: {new System.Diagnostics.StackTrace()}");
            using var form = new FormInscribir();
            if (form.ShowDialog(this) == DialogResult.OK && form.InscripcionExitosa)
            {
                CargarDatosInscritos();
            }
        }
    }
}

