using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using Sistema_Academia.Presentacion.Agregar;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMantenimientoPersona : Form
    {
        public FormMantenimientoPersona()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            agregar.Click += agregar_Click;
            editar.Click += editar_Click_1;
            eliminar.Click += eliminar_Click;
            buscar.Click += buscar_Click_1;

            CargarDatosPersonas();
            AgregarHeaders();
        }

        private void CargarDatosPersonas()
        {
            try
            {
                var dt = new TablaPersona().Listado();
                dataGridViewTabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarHeaders()
        {
            var cols = dataGridViewTabla.Columns;
            if (cols["persona_no"] != null) cols["persona_no"].HeaderText = "Nombre";
            if (cols["persona_ap"] != null) cols["persona_ap"].HeaderText = "Apellido";
            if (cols["persona_ci"] != null) cols["persona_ci"].HeaderText = "Cédula";
            if (cols["tipo_persona_id"] != null) cols["tipo_persona_id"].HeaderText = "Tipo";
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
                Nombre = row.Cells["persona_no"].Value.ToString(),
                Apellido = row.Cells["persona_ap"].Value.ToString(),
                Cedula = Convert.ToInt32(row.Cells["persona_ci"].Value),
                TipoPersona = row.Cells["tipopersonaid"].Value.ToString()
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
    }
}