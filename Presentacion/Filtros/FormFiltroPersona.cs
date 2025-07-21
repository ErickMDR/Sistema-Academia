using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System.Data;

namespace Sistema_Academia.Presentacion.Filtros
{
    public partial class FormFiltroPersona : Form
    {
        public DataTable PersonasFiltradas { get; private set; }
        public FormFiltroPersona()
        {
            InitializeComponent();
            this.AcceptButton = aceptar;
            CargarTiposPersona();
        }
        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tablaPersona = new TablaPersona())
                {
                    PersonasFiltradas = tablaPersona.Filtrar(
                        materia: txtmateria.Text.Trim(),
                        seccion: txtseccion.Text.Trim(),
                        tipoPersona: cmbtipopersona.Text.Trim()
                    );

                    if (PersonasFiltradas.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con los criterios de búsqueda",
                                         "Información",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarTiposPersona()
        {
            try
            {
                using (var tablaPersona = new TablaPersona())
                {
                    DataTable tiposPersona = tablaPersona.ObtenerTiposPersona();
                    cmbtipopersona.DataSource = tiposPersona;
                    cmbtipopersona.DisplayMember = "tipo_persona_de"; 
                    cmbtipopersona.ValueMember = "tipo_persona_id"; 
                    cmbtipopersona.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}