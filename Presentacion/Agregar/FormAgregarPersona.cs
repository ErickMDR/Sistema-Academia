using System;
using System.Windows.Forms;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;

namespace Sistema_Academia.Presentacion.Agregar
{


    public partial class FormAgregarPersona : Form
    {
        private readonly FormMode _modo;
        private readonly Persona _personaExistente;

        public bool PersonaGuardada { get; private set; }

        public FormAgregarPersona()
        {
            InitializeComponent();
            _modo = FormMode.Agregar;
            title.Text = "AGREGAR PERSONA";
            aceptar.Text = "Agregar";
            CargarTiposPersona();
            aceptar.Click += aceptar_Click_1;
            this.AcceptButton = aceptar;
        }

        public FormAgregarPersona(Persona persona) : this()
        {
            if (persona == null) throw new ArgumentNullException(nameof(persona));

            _modo = FormMode.Editar;
            _personaExistente = persona;
            title.Text = "EDITAR PERSONA";
            aceptar.Text = "Actualizar";

            txtnombre.Text = persona.Nombre;
            txtapellido.Text = persona.Apellido;
            txtcedula.Text = persona.Cedula.ToString();
            comboBox.SelectedItem = persona.TipoPersona;
            this.AcceptButton = aceptar;
        }

        private void CargarTiposPersona()
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new[] { "Profesor", "Estudiante" });
            comboBox.SelectedIndex = 0;
        }

        private void aceptar_Click_1(object sender, EventArgs e)
        {
            string nom = txtnombre.Text.Trim();
            string ap = txtapellido.Text.Trim();
            string ciTx = txtcedula.Text.Trim();
            string tp = comboBox.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(nom)
                || string.IsNullOrWhiteSpace(ap)
                || !int.TryParse(ciTx, out int ci)
                || string.IsNullOrEmpty(tp))
            {
                MessageBox.Show("Verifica todos los campos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var tabla = new TablaPersona();
                if (_modo == FormMode.Agregar)
                {
                    tabla.Insertar(new Persona
                    {
                        Nombre = nom,
                        Apellido = ap,
                        Cedula = ci,
                        TipoPersona = tp
                    });
                }
                else
                {
                    _personaExistente.Nombre = nom;
                    _personaExistente.Apellido = ap;
                    _personaExistente.Cedula = ci;
                    _personaExistente.TipoPersona = tp;
                    tabla.Actualizar(_personaExistente);
                }

                PersonaGuardada = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar persona: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}