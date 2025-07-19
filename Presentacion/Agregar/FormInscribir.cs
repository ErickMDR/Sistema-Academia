using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using Sistema_Academia.Entidades;
using Sistema_Academia.Datos;

namespace Sistema_Academia.Presentacion.Agregar
{
    public partial class FormInscribir : Form
    {
        private readonly IConfigurationRoot _config;

        public bool InscripcionExitosa { get; private set; }

        public FormInscribir()
        {
            InitializeComponent();

            // Cargar queries.json
            _config = new ConfigurationBuilder()
                .SetBasePath(Application.StartupPath)
                .AddJsonFile("queries.json")
                .Build();

            // Suscribir el botón Aceptar
            aceptar.Click += aceptar_Click;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            try
            {
                // Construcción de la inscripción temporal
                var inscripcion = new Inscripcion
                {
                    Cedula = txtcedula.Text.Trim(),
                    Nombre = txtnombre.Text.Trim(),
                    Apellido = txtapellido.Text.Trim(),
                    Materia = txtmateria.Text.Trim(),
                    Seccion = txtseccion.Text.Trim()
                };

                // Inserta todo (persona + curso + inscripcion)
                using var tabla = new TablaInscripcion();
                tabla.InsertarCompleto(inscripcion);

                InscripcionExitosa = true;
                MessageBox.Show("Inscripción realizada con éxito", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clave: setear DialogResult a OK para que el ShowDialog devuelva OK
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inscribir: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(txtmateria.Text))
            {
                MessageBox.Show("La materia es obligatoria", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtseccion.Text))
            {
                MessageBox.Show("La sección es obligatoria", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}