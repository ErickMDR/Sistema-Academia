using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion.Agregar
{


    public partial class FormAgregarMateria : Form
    {
        private readonly FormMode _modo;
        private readonly Materia _materiaExistente;

        public bool MateriaAgregada { get; private set; } = false;

        // Constructor para Agregar
        public FormAgregarMateria()
        {
            InitializeComponent();
            _modo = FormMode.Agregar;
            Text = "Agregar Materia";
            aceptar.Text = "Agregar";
            aceptar.Click += aceptar_Click;
        }

        // Constructor para Editar
        public FormAgregarMateria(Materia materia) : this()
        {
            if (materia == null) throw new ArgumentNullException(nameof(materia));

            _modo = FormMode.Editar;
            _materiaExistente = materia;
            Text = "Editar Materia";
            aceptar.Text = "Actualizar";
            txtmateria.Text = materia.Nombre;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            // Leemos siempre del TextBox, nunca del botón
            string nombre = txtmateria.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la materia.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var tabla = new TablaMateria();

                if (_modo == FormMode.Agregar)
                {
                    tabla.Insertar(new Materia { Nombre = nombre });
                }
                else
                {
                    _materiaExistente.Nombre = nombre;
                    tabla.Actualizar(_materiaExistente);
                }

                MateriaAgregada = true;
                MessageBox.Show(
                    _modo == FormMode.Agregar
                        ? "Materia agregada correctamente."
                        : "Materia actualizada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al procesar la materia: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}