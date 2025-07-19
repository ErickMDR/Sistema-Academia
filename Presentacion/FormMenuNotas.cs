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
            dataGridViewTabla.Columns[0].HeaderText = "ID";
            dataGridViewTabla.Columns[1].HeaderText = "Materia";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
