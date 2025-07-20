using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion.Agregar
{
    public partial class FormAsignarNota : Form
    {
        public bool Calificado { get; private set; }
        private readonly Nota _nota;

        public FormAsignarNota(Nota nota)
        {
            InitializeComponent();
            _nota = nota;
            Calificado = false;

            txtcedula.Text = nota.Cedula;
            txtnombre.Text = nota.Nombre;
            txtapellido.Text = nota.Apellido;
            txtmateria.Text = nota.Materia;

            txtnota.KeyPress += TxtNota_KeyPress;
            this.AcceptButton = asignarNota;
        }

        private void TxtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void asignarNota_Click_1(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            try
            {
                _nota.Calificacion = Convert.ToInt32(txtnota.Text);

                using (var tabla = new TablaNotas())
                {
                    tabla.Insertar(_nota);
                }

                Calificado = true;
                MessageBox.Show("Nota asignada con éxito", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar nota: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtnota.Text))
            {
                MessageBox.Show("La nota es requerida", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtnota.Text, out int nota) || nota < 1 || nota > 20)
            {
                MessageBox.Show("La nota debe ser un número entre 1 y 20", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
