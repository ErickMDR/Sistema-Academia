using Microsoft.Extensions.Configuration;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Sistema_Academia.Presentacion.Agregar
{
    public partial class FormInscribir : Form
    {
        public bool InscripcionExitosa { get; private set; }

        public FormInscribir()
        {
            InitializeComponent();

            this.Load += (s, e) => CargarCombos();
            aceptar.Click += aceptar_Click;
            this.AcceptButton = aceptar;
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
                    Materia = materia,
                    Seccion = seccion
                };

                using var tabla = new TablaInscripcion();
                tabla.Insertar(inscripcion);

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

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtcedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria", "Validación",
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
            try
            {
                var materias = new TablaMateria().Listado();
                cmbmateria.DataSource = materias;
                cmbmateria.DisplayMember = "materia_de";
                cmbmateria.ValueMember = "materia_id";

                var seccionesVacia = new DataTable();
                seccionesVacia.Columns.Add("seccion_id", typeof(int));
                seccionesVacia.Columns.Add("seccion_de", typeof(string));

                cmbseccion.DataSource = seccionesVacia;
                cmbseccion.DisplayMember = "seccion_de";
                cmbseccion.ValueMember = "seccion_id";

                cmbmateria.SelectedIndexChanged += Cmbmateria_SelectedIndexChanged;
                
                if (cmbmateria.Items.Count > 0)
                {
                    Cmbmateria_SelectedIndexChanged(cmbmateria, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmbmateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmateria.SelectedValue != null && cmbmateria.SelectedValue is int materiaId)
            {
                CargarSeccionesPorMateria(materiaId);
            }
        }

        private void CargarSeccionesPorMateria(int materiaId)
        {
            try
            {
                var secciones = new TablaSeccion().ObtenerSeccionesPorMateria(materiaId);

                if (secciones.Columns.Contains("seccion_id") && secciones.Columns.Contains("seccion_de"))
                {
                    var seccionesCopia = secciones.Clone();
                    foreach (DataRow row in secciones.Rows)
                    {
                        seccionesCopia.ImportRow(row);
                    }

                    cmbseccion.DataSource = seccionesCopia;
                    cmbseccion.DisplayMember = "seccion_de";
                    cmbseccion.ValueMember = "seccion_id";
                }
                else
                {
                    throw new Exception("Las columnas 'seccion_id' o 'seccion_de' no existen en los datos obtenidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar secciones: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}