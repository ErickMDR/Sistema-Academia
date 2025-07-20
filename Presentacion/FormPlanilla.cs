using Sistema_Academia.Datos;
using Sistema_Academia.Presentacion.Filtros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class FormPlanilla : Form
    {
        public FormPlanilla()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CargarDatosPlanilla();
        }

        private void CargarDatosPlanilla(DataTable datosFiltrados = null)
        {
            try
            {
                using (var tablaPlanilla = new TablaPlanilla())
                {
                    dataGridViewTabla.DataSource = datosFiltrados ?? tablaPlanilla.Listado();
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
                if (dataGridViewTabla.Columns.Count >= 6)
                {
                    dataGridViewTabla.Columns[0].HeaderText = "Cédula";
                    dataGridViewTabla.Columns[1].HeaderText = "Nombre";
                    dataGridViewTabla.Columns[2].HeaderText = "Apellido";
                    dataGridViewTabla.Columns[3].HeaderText = "Materia";
                    dataGridViewTabla.Columns[4].HeaderText = "Sección";
                    dataGridViewTabla.Columns[5].HeaderText = "Nota";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filtro_Click(object sender, EventArgs e)
        {
            using (var formFiltro = new FormFiltroPlanilla())
            {
                if (formFiltro.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewTabla.DataSource = formFiltro.ResultadosFiltrados;
                    AgregarHeaders();
                }
            }
        }
    }
}
