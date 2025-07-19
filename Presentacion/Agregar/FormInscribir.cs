using Microsoft.Extensions.Configuration;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Sistema_Academia.Presentacion.Agregar
{
    public partial class FormInscribir : Form
    {
        private readonly IConfigurationRoot _config;

        public bool InscripcionExitosa { get; private set; }

        public FormInscribir()
        {
            InitializeComponent();

            _config = new ConfigurationBuilder()
                .SetBasePath(Application.StartupPath)
                .AddJsonFile("queries.json")
                .Build();

            this.Load += (s, e) => CargarCombos();
            aceptar.Click += aceptar_Click;
            this.FormClosing += FormInscribir_FormClosing;
            CargarCombos();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            if (!int.TryParse(txtcedula.Text.Trim(), out _))
            {
                MessageBox.Show("La cédula debe contener solo números", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var materia = (cmbmateria.SelectedItem as DataRowView)?["materia_de"]?.ToString();
                var seccion = (cmbseccion.SelectedItem as DataRowView)?["seccion_de"]?.ToString();

                if (string.IsNullOrEmpty(materia) || string.IsNullOrEmpty(seccion))
                {
                    MessageBox.Show("Debe seleccionar materia y sección válidas");
                    return;
                }

                var inscripcion = new Inscripcion
                {
                    Cedula = txtcedula.Text.Trim(),
                    Nombre = txtnombre.Text.Trim(),
                    Apellido = txtapellido.Text.Trim(),
                    Materia = materia,
                    Seccion = seccion
                };

                using var tabla = new TablaInscripcion();
                tabla.InsertarCompleto(inscripcion);

                InscripcionExitosa = true;
                MessageBox.Show("Inscripción realizada con éxito", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;

                if (ex.Message.Contains("foreign key constraint"))
                {
                    mensaje = "No se pudo completar la inscripción. Verifique que:\n" +
                             "1. La materia y sección seleccionadas existen\n" +
                             "2. El curso está correctamente configurado";
                }
                MessageBox.Show($"Error al inscribir: {mensaje}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInscribir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtcedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtapellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cmbmateria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una materia");
                return false;
            }

            if (cmbseccion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sección");
                return false;
            }
            return true;
        }
        private void CargarCombos()
        {
            var materias = new TablaMateria().Listado();
            cmbmateria.DataSource = materias;
            cmbmateria.DisplayMember = "materia_de";
            cmbmateria.ValueMember = "materia_id";

            var secciones = new TablaSeccion().Listado();
            cmbseccion.DataSource = secciones;
            cmbseccion.DisplayMember = "seccion_de";
            cmbseccion.ValueMember = "seccion_id";
        }
    }
}