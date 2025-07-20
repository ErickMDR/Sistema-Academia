using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System.Data;

namespace Sistema_Academia.Presentacion.Filtros
{
    public partial class FormFiltroPersona : Form
    {
        private readonly TablaPersona _tablaPersona;
        public DataTable PersonasFiltradas { get; private set; }

        public FormFiltroPersona()
        {
            InitializeComponent();
            _tablaPersona = new TablaPersona();
            PersonasFiltradas = new DataTable();
            CargarCombos();
            this.AcceptButton = aceptar;
        }

        private void CargarCombos()
        {
            try
            {
                cmbmateria.DataSource = _tablaPersona.ObtenerMaterias();
                cmbmateria.DisplayMember = "materia_de";
                cmbmateria.SelectedIndex = -1;

                cmbseccion.DataSource = _tablaPersona.ObtenerSecciones();
                cmbseccion.DisplayMember = "seccion_de";
                cmbseccion.SelectedIndex = -1;

                cmbtipopersona.DataSource = _tablaPersona.ObtenerTiposPersona();
                cmbtipopersona.DisplayMember = "tipo_persona_de";
                cmbtipopersona.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string materia = cmbmateria.SelectedIndex >= 0 ? cmbmateria.Text : null;
                string seccion = cmbseccion.SelectedIndex >= 0 ? cmbseccion.Text : null;
                string tipoPersona = cmbtipopersona.SelectedIndex >= 0 ? cmbtipopersona.Text : null;

                PersonasFiltradas = _tablaPersona.Filtrar(materia, seccion, tipoPersona);

                if (PersonasFiltradas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con los filtros aplicados", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}