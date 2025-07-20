using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion.Agregar
{

    public partial class FormAgregarSeccion : Form
    {
        private readonly FormMode _modo;
        private readonly Seccion _seccionExistente;

        public bool SeccionAgregada { get; private set; } = false;

        public FormAgregarSeccion()
        {
            InitializeComponent();
            _modo = FormMode.Agregar;
            title.Text = "AGREGAR SECCIÓN";
            aceptar.Text = "Agregar";
            aceptar.Click += aceptar_Click;
            this.AcceptButton = aceptar;
        }

        public FormAgregarSeccion(Seccion seccion) : this()
        {
            if (seccion == null) throw new ArgumentNullException(nameof(seccion));
            _modo = FormMode.Editar;
            _seccionExistente = seccion;
            title.Text = "EDITAR SECCIÓN";
            aceptar.Text = "Actualizar";
            txtseccion.Text = seccion.Descripcion;
            this.AcceptButton = aceptar;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            string descripcion = txtseccion.Text.Trim();
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show(
                    "Ingrese la descripción de la sección.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var tabla = new TablaSeccion();
                if (_modo == FormMode.Agregar)
                {
                    tabla.Insertar(new Seccion { Descripcion = descripcion });
                }
                else
                {
                    _seccionExistente.Descripcion = descripcion;
                    tabla.Actualizar(_seccionExistente);
                }

                SeccionAgregada = true;
                MessageBox.Show(
                    _modo == FormMode.Agregar
                        ? "Sección agregada correctamente."
                        : "Sección actualizada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al procesar la sección: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}