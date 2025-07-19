using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Academia.Presentacion;
using Sistema_Academia.Presentacion.Filtros;
using Sistema_Academia.Datos;

namespace Sistema_Academia.Presentacion
{
    public partial class FormMenuNotas : Form
    {
        public FormMenuNotas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CargarDatosNotas();
        }

        private void asignar_Click(object sender, EventArgs e)
        {
            FormAsignar form = new FormAsignar();
            form.ShowDialog(this);
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
                dataGridViewTabla.Columns["persona_ci"].HeaderText = "Cédula";
                dataGridViewTabla.Columns["persona_no"].HeaderText = "Nombre";
                dataGridViewTabla.Columns["persona_ap"].HeaderText = "Apellido";
                dataGridViewTabla.Columns["materia_de"].HeaderText = "Materia";
                dataGridViewTabla.Columns["calificacion_nu"].HeaderText = "Nota";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
