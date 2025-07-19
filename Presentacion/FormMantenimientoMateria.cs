using Sistema_Academia.Presentacion.Agregar;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMantenimientoMateria : Form
    {
        public FormMantenimientoMateria()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            agregar.Click += agregar_Click;
            editar.Click += editar_Click;
            eliminar.Click += eliminar_Click;
            buscar.Click += buscar_Click_1;
            txtmateria.KeyDown += txtmateria_KeyDown;

            CargarDatosMaterias();
        }

        private void CargarDatosMaterias()
        {
            try
            {
                using var tabla = new TablaMateria();
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
                dataGridViewTabla.Columns["materia_id"].HeaderText = "ID";
                dataGridViewTabla.Columns["materia_de"].HeaderText = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al configurar encabezados: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using var form = new FormAgregarMateria();
            if (form.ShowDialog() == DialogResult.OK && form.MateriaAgregada)
                CargarDatosMaterias();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count != 1)
            {
                MessageBox.Show(
                    "Selecciona una sola materia para editar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewTabla.SelectedRows[0];
            var materia = new Materia
            {
                Id = Convert.ToInt32(row.Cells["materia_id"].Value),
                Nombre = row.Cells["materia_de"].Value.ToString()
            };

            using var form = new FormAgregarMateria(materia);
            if (form.ShowDialog() == DialogResult.OK && form.MateriaAgregada)
                CargarDatosMaterias();
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
                using var tabla = new TablaMateria();
                foreach (DataGridViewRow row in dataGridViewTabla.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["materia_id"].Value);
                    tabla.Eliminar(id);
                }
                CargarDatosMaterias();
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

        private void buscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmateria.Text))
            {
                MessageBox.Show(
                    "Por favor ingrese un nombre de materia para buscar",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtmateria.Focus();
                return;
            }

            try
            {
                using var tabla = new TablaMateria();
                var resultados = tabla.BuscarPorNombre(txtmateria.Text.Trim());

                if (resultados.Any())
                    dataGridViewTabla.DataSource = resultados;
                else
                    MessageBox.Show(
                        "No se encontraron materias con ese nombre",
                        "Búsqueda sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al buscar materias: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtmateria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;

                    buscar.Focus();
                    buscar_Click_1(sender, e);
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