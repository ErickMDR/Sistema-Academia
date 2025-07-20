using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using Sistema_Academia.Presentacion.Agregar;
using Sistema_Academia.Presentacion.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMantenimientoPersona : Form
    {
        public FormMantenimientoPersona()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            agregar.Click -= agregar_Click;
            agregar.Click += agregar_Click;
            editar.Click -= editar_Click_1;
            editar.Click += editar_Click_1;
            eliminar.Click -= eliminar_Click;
            eliminar.Click += eliminar_Click;
            buscar.Click -= buscar_Click_1;
            buscar.Click += buscar_Click_1;
            txtcedula.KeyDown -= txtcedula_KeyDown;
            txtcedula.KeyDown += txtcedula_KeyDown;

            CargarDatosPersonas();
        }

        private void CargarDatosPersonas()
        {
            try
            {
                var dt = new TablaPersona().Listado();
                dataGridViewTabla.DataSource = dt;
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
                dataGridViewTabla.Columns["persona_id"].Visible = false;
                dataGridViewTabla.Columns[1].HeaderText = "Cédula";
                dataGridViewTabla.Columns[2].HeaderText = "Nombre";
                dataGridViewTabla.Columns[3].HeaderText = "Apellido";
                dataGridViewTabla.Columns[4].HeaderText = "Tipo de Persona";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using var form = new FormAgregarPersona();
            if (form.ShowDialog() == DialogResult.OK && form.PersonaGuardada)
                CargarDatosPersonas();
        }

        private void editar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecciona una sola persona para editar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewTabla.SelectedRows[0];
            var persona = new Persona
            {
                Id = Convert.ToInt32(row.Cells["persona_id"].Value),
                Nombre = row.Cells["persona_no"].Value.ToString(),
                Apellido = row.Cells["persona_ap"].Value.ToString(),
                Cedula = Convert.ToInt32(row.Cells["persona_ci"].Value),
                TipoPersona = row.Cells["tipo_persona_de"].Value.ToString()
            };

            using var form = new FormAgregarPersona(persona);
            if (form.ShowDialog() == DialogResult.OK && form.PersonaGuardada)
                CargarDatosPersonas();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabla.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una fila para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var confirm = new ConfirmarEliminacion();
            if (confirm.ShowDialog() != DialogResult.OK || !confirm.Confirmado)
                return;

            try
            {
                using var tabla = new TablaPersona();
                foreach (DataGridViewRow row in dataGridViewTabla.SelectedRows)
                {
                    string nom = row.Cells["persona_no"].Value.ToString();
                    string ap = row.Cells["persona_ap"].Value.ToString();
                    tabla.Eliminar(nom, ap);
                }
                CargarDatosPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcedula.Text.Trim(), out int ci))
            {
                MessageBox.Show("Ingresa una cédula válida.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var p = new TablaPersona().BuscarPorCedula(ci);
                if (p != null)
                    dataGridViewTabla.DataSource = new List<Persona> { p };
                else
                {
                    MessageBox.Show("No se encontró la persona.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosPersonas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcedula_KeyDown(object sender, KeyEventArgs e)
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
        private void filtro_Click_1(object sender, EventArgs e)
        {
            using (var formFiltro = new FormFiltroPersona())
            {
                if (formFiltro.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewTabla.DataSource = formFiltro.PersonasFiltradas;
                    AgregarHeaders();
                }
            }
        }
    }
}