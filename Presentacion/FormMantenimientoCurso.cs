using System;
using System.Data;
using System.Windows.Forms;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using Sistema_Academia.Presentacion.Agregar;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMantenimientoCurso : Form
    {
        public FormMantenimientoCurso()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            // Suscripción de eventos
            agregar.Click += agregar_Click;
            editar.Click += editar_Click;
            eliminar.Click += eliminar_Click;
            buscar.Click += buscar_Click;

            CargarDatosCursos();
            //ConfigurarEncabezados();
        }

        private void CargarDatosCursos()
        {
            try
            {
                dataGridViewTabla.DataSource = new TablaCurso().Listado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar cursos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarEncabezados()
        {
            var cols = dataGridViewTabla.Columns;

            if (cols["curso_id"] != null) cols["curso_id"].Visible = false;
            if (cols["persona_id"] != null) cols["persona_id"].Visible = false;
            if (cols["materia_id"] != null) cols["materia_id"].Visible = false;
            if (cols["seccion_id"] != null) cols["seccion_id"].Visible = false;

            if (cols["persona_ci"] != null) cols["persona_ci"].HeaderText = "Cédula";
            if (cols["persona_no"] != null) cols["persona_no"].HeaderText = "Nombre Profesor";
            if (cols["persona_ap"] != null) cols["persona_ap"].HeaderText = "Apellido Profesor";
            if (cols["materia_de"] != null) cols["materia_de"].HeaderText = "Materia";
            if (cols["seccion_de"] != null) cols["seccion_de"].HeaderText = "Sección";
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using var form = new FormAgregarCurso();
            if (form.ShowDialog(this) == DialogResult.OK && form.CursoAgregado)
                CargarDatosCursos();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count != 1)
            {
                MessageBox.Show(
                    "Selecciona un solo curso para editar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewTabla.SelectedRows[0];
            var curso = new Curso
            {
                Id = Convert.ToInt32(row.Cells["curso_id"].Value),
                ProfesorId = Convert.ToInt32(row.Cells["persona_id"].Value),
                MateriaId = Convert.ToInt32(row.Cells["materia_id"].Value),
                SeccionId = Convert.ToInt32(row.Cells["seccion_id"].Value)
            };

            using var form = new FormAgregarCurso(curso);
            if (form.ShowDialog(this) == DialogResult.OK && form.CursoAgregado)
                CargarDatosCursos();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos un curso para eliminar.",
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
                var tabla = new TablaCurso();
                foreach (DataGridViewRow row in dataGridViewTabla.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["curso_id"].Value);
                    tabla.Eliminar(id);
                }
                CargarDatosCursos();
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
            var filtro = txtcedula.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                CargarDatosCursos();
                return;
            }

            if (!int.TryParse(filtro, out int cedula))
            {
                MessageBox.Show(
                    "Ingresa una cédula válida.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtcedula.Focus();
                return;
            }

            try
            {
                dataGridViewTabla.DataSource = new TablaCurso().BuscarCursosPorCedulaProfesor(cedula);
                ConfigurarEncabezados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error en la búsqueda: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}