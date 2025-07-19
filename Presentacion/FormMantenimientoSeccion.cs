using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using Sistema_Academia.Presentacion.Agregar;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMantenimientoSeccion : Form
    {
        public FormMantenimientoSeccion()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            agregar.Click += agregar_Click;
            editar.Click += editar_Click;
            eliminar.Click += eliminar_Click;
            buscar.Click += buscar_Click;
            txtseccion.KeyDown += txtseccion_KeyDown;

            CargarDatosSecciones();
        }

        private void CargarDatosSecciones()
        {
            try
            {
                using var tabla = new TablaSeccion();
                dataGridViewTabla.DataSource = tabla.Listado();
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
                dataGridViewTabla.Columns["seccion_id"].HeaderText = "ID";
                dataGridViewTabla.Columns["seccion_de"].HeaderText = "Sección";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using var form = new FormAgregarSeccion();
            if (form.ShowDialog() == DialogResult.OK && form.SeccionAgregada)
                CargarDatosSecciones();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count != 1)
            {
                MessageBox.Show(
                    "Selecciona una sola sección para editar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewTabla.SelectedRows[0];
            var seccion = new Seccion
            {
                Id = Convert.ToInt32(row.Cells["seccion_id"].Value),
                Descripcion = row.Cells["seccion_de"].Value.ToString()
            };

            using var form = new FormAgregarSeccion(seccion);
            if (form.ShowDialog() == DialogResult.OK && form.SeccionAgregada)
                CargarDatosSecciones();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos una fila para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using var confirm = new ConfirmarEliminacion();
            if (confirm.ShowDialog() != DialogResult.OK || !confirm.Confirmado)
                return;

            try
            {
                using var tabla = new TablaSeccion();
                foreach (DataGridViewRow row in dataGridViewTabla.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["seccion_id"].Value);
                    tabla.Eliminar(id);
                }
                CargarDatosSecciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al eliminar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtseccion.Text))
            {
                MessageBox.Show(
                    "Por favor ingrese una descripción de sección para buscar",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtseccion.Focus();
                return;
            }

            try
            {
                using var tabla = new TablaSeccion();
                var resultados = tabla.BuscarPorDescripcion(txtseccion.Text.Trim());

                if (resultados.Any())
                    dataGridViewTabla.DataSource = resultados;
                else
                    MessageBox.Show(
                        "No se encontraron secciones con esa descripción",
                        "Búsqueda sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al buscar secciones: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtseccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;

                    buscar.Focus();
                    buscar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar búsqueda: {ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
    }
}