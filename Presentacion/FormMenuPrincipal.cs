using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Presentacion;
using Sistema_Academia.Presentacion.Filtros;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Sistema_Academia
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }
        public void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuInscripcion form = new FormMenuInscripcion();
            form.MdiParent = this;
            form.Show();
        }

        private void planillaDeNotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPlanilla form = new FormPlanilla();
            form.MdiParent = this;
            form.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuNotas form = new FormMenuNotas();
            form.MdiParent = this;
            form.Show();

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoCurso form = new FormMantenimientoCurso();
            form.MdiParent = this;
            form.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoMateria form = new FormMantenimientoMateria();
            form.MdiParent = this;
            form.Show();
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoSeccion form = new FormMantenimientoSeccion();
            form.MdiParent = this;
            form.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoPersona form = new FormMantenimientoPersona();
            form.MdiParent = this;
            form.Show();
        }
    }
}
