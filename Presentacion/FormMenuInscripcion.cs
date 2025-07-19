using System;
using System.Windows.Forms;
using Sistema_Academia.Presentacion.Agregar;
using Sistema_Academia.Datos;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMenuInscripcion : Form
    {
        public FormMenuInscripcion()
        {
            InitializeComponent();

            inscribir.Click += inscribir_Click_1;

            WindowState = FormWindowState.Maximized;
            CargarDatosInscritos();
            //AgregarHeaders();
        }
  
        private void CargarDatosInscritos()
        {
            try
            {
                using var tablaInscripcion = new TablaInscripcion();
                dataGridViewTabla.DataSource = tablaInscripcion.Listado();
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
                dataGridViewTabla.Columns[0].HeaderText = "Cédula";
                dataGridViewTabla.Columns[1].HeaderText = "Nombre";
                dataGridViewTabla.Columns[2].HeaderText = "Apellido";
                dataGridViewTabla.Columns[3].HeaderText = "Materia";
                dataGridViewTabla.Columns[4].HeaderText = "Sección";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar nombres de columna: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void inscribir_Click_1(object sender, EventArgs e)
        {
            using var form = new FormInscribir();
            if (form.ShowDialog(this) == DialogResult.OK && form.InscripcionExitosa)
            {
                CargarDatosInscritos();
            }
        }
    }
}

