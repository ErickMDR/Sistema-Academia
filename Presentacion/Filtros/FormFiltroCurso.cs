using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;

namespace Sistema_Academia.Presentacion.Filtros
{
    public partial class FormFiltroCurso : Form
    {
        public DataTable CursosFiltrados { get; private set; }
        public FormFiltroCurso()
        {
            InitializeComponent();
            this.AcceptButton = filtrar;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tablaCurso = new TablaCurso())
                {
                    CursosFiltrados = tablaCurso.Filtrar(
                        materia: txtmateria.Text.Trim(),
                        seccion: txtseccion.Text.Trim()
                    );

                    if (CursosFiltrados.Rows.Count == 0)
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
