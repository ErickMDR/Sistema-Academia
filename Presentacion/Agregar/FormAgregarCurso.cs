using System;
using System.Windows.Forms;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;

namespace Sistema_Academia.Presentacion.Agregar
{
    public enum FormMode { Agregar, Editar }

    public partial class FormAgregarCurso : Form
    {
        private readonly FormMode _modo;
        private readonly Curso _cursoExistente;

        public bool CursoAgregado { get; private set; }

        public FormAgregarCurso()
        {
            InitializeComponent();
            _modo = FormMode.Agregar;
            title.Text = "AGREGAR CURSO";
            aceptar.Text = "Agregar";

            CargarCombos();
            aceptar.Click += Aceptar_Click;
            this.AcceptButton = aceptar;
        }

        public FormAgregarCurso(Curso curso) : this()
        {
            if (curso == null) throw new ArgumentNullException(nameof(curso));

            _modo = FormMode.Editar;
            _cursoExistente = curso;
            title.Text = "EDITAR CURSO";
            aceptar.Text = "Actualizar";

            txtcedula.Enabled = false;

            var prof = new TablaPersona().BuscarPorCedula(curso.ProfesorId);
            if (prof != null)
            {
                txtcedula.Text = prof.Cedula.ToString();
                txtnombre.Text = prof.Nombre;
                txtapellido.Text = prof.Apellido;
            }

            cmbMateria.SelectedValue = curso.MateriaId;
            cmbSeccion.SelectedValue = curso.SeccionId;

            this.AcceptButton = aceptar;
        }

        private void CargarCombos()
        {
            var materias = new TablaMateria().Listado();
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "materia_de";
            cmbMateria.ValueMember = "materia_id";

            var secciones = new TablaSeccion().Listado();
            cmbSeccion.DataSource = secciones;
            cmbSeccion.DisplayMember = "seccion_de";
            cmbSeccion.ValueMember = "seccion_id";
        }

        private void BuscarProfesor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcedula.Text.Trim(), out int cedula))
            {
                MessageBox.Show("La cédula debe ser numérica.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var prof = new TablaPersona().BuscarPorCedula(cedula);
            if (prof == null)
            {
                MessageBox.Show("Profesor no encontrado.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtnombre.Text = prof.Nombre;
            txtapellido.Text = prof.Apellido;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Validar cédula
            if (!int.TryParse(txtcedula.Text.Trim(), out int cedula))
            {
                MessageBox.Show("La cédula debe ser numérica.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección de materia y sección
            if (cmbMateria.SelectedItem == null || cmbSeccion.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar materia y sección.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var tabla = new TablaCurso();

                if (_modo == FormMode.Agregar)
                {
                    // Verificar profesor existe
                    var prof = new TablaPersona().BuscarPorCedula(cedula);
                    if (prof == null)
                    {
                        MessageBox.Show("Profesor no existe.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var nuevo = new Curso
                    {
                        ProfesorId = prof.Id,
                        MateriaId = (int)cmbMateria.SelectedValue,
                        SeccionId = (int)cmbSeccion.SelectedValue
                    };
                    tabla.Insertar(nuevo);
                }
                else
                {
                    // Actualizar materia y sección del curso existente
                    _cursoExistente.MateriaId = (int)cmbMateria.SelectedValue;
                    _cursoExistente.SeccionId = (int)cmbSeccion.SelectedValue;
                    tabla.Actualizar(_cursoExistente);
                }

                CursoAgregado = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar curso: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}