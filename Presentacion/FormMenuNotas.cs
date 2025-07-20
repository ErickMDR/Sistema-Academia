using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
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
            if (dataGridViewTabla.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un estudiante para asignar nota",
                              "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewTabla.SelectedRows[0];
            var nota = new Nota
            {
                Cedula = selectedRow.Cells["persona_ci"].Value.ToString(),
                Nombre = selectedRow.Cells["persona_no"].Value.ToString(),
                Apellido = selectedRow.Cells["persona_ap"].Value.ToString(),
                Materia = selectedRow.Cells["materia_de"].Value.ToString(),
                InscripcionId = Convert.ToInt32(selectedRow.Cells["inscripcion_id"].Value)
            };

            using var form = new FormAsignarNota(nota);
            if (form.ShowDialog(this) == DialogResult.OK && form.Calificado)
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
                dataGridViewTabla.Columns["inscripcion_id"].Visible = false;
                dataGridViewTabla.Columns[1].HeaderText = "Cédula";
                dataGridViewTabla.Columns[2].HeaderText = "Nombre";
                dataGridViewTabla.Columns[3].HeaderText = "Apellido";
                dataGridViewTabla.Columns[4].HeaderText = "Materia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
