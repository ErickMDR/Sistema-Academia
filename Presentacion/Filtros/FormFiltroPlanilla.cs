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

namespace Sistema_Academia.Presentacion.Filtros
{
    public partial class FormFiltroPlanilla : Form
    {
        public DataTable ResultadosFiltrados { get; private set; }

        public FormFiltroPlanilla()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int? cedula = null;
                if (!string.IsNullOrEmpty(txtcedula.Text) && int.TryParse(txtcedula.Text, out int tempCedula))
                {
                    cedula = tempCedula;
                }

                using (var tablaPlanilla = new TablaPlanilla())
                {
                    ResultadosFiltrados = tablaPlanilla.Filtrar(
                        materia: txtmateria.Text.Trim(),
                        seccion: txtseccion.Text.Trim(),
                        nombre: txtnombre.Text.Trim(),
                        apellido: txtapellido.Text.Trim(),
                        cedula: cedula
                    );

                    if (ResultadosFiltrados.Rows.Count == 0)
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
    }
}
