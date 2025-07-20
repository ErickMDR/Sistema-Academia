namespace Sistema_Academia
{
    partial class FormMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            inscripcionToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            planillaDeNotasToolStripMenuItem1 = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            planillaDeNotasToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            seccionesToolStripMenuItem = new ToolStripMenuItem();
            panelBarra = new Panel();
            PlataformaVirtual = new Label();
            Academia = new Label();
            Imagen = new PictureBox();
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1.SuspendLayout();
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Imagen).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.BackColor = Color.FromArgb(64, 52, 116);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 15.7652178F);
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inscripcionToolStripMenuItem, notasToolStripMenuItem, reportesToolStripMenuItem, mantenimientoToolStripMenuItem });
            menuStrip1.Location = new Point(1229, 54);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(648, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inscripcionToolStripMenuItem
            // 
            inscripcionToolStripMenuItem.Font = new Font("Segoe UI", 18.0173912F);
            inscripcionToolStripMenuItem.ForeColor = SystemColors.Control;
            inscripcionToolStripMenuItem.Name = "inscripcionToolStripMenuItem";
            inscripcionToolStripMenuItem.Size = new Size(167, 44);
            inscripcionToolStripMenuItem.Text = "Inscripción";
            inscripcionToolStripMenuItem.Click += inscripcionToolStripMenuItem_Click;
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.Font = new Font("Segoe UI", 18.0173912F);
            notasToolStripMenuItem.ForeColor = SystemColors.Control;
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(107, 44);
            notasToolStripMenuItem.Text = "Notas";
            notasToolStripMenuItem.Click += notasToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planillaDeNotasToolStripMenuItem1 });
            reportesToolStripMenuItem.Font = new Font("Segoe UI", 18.0173912F);
            reportesToolStripMenuItem.ForeColor = SystemColors.Control;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(143, 44);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // planillaDeNotasToolStripMenuItem1
            // 
            planillaDeNotasToolStripMenuItem1.BackColor = Color.FromArgb(64, 52, 116);
            planillaDeNotasToolStripMenuItem1.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planillaDeNotasToolStripMenuItem1.ForeColor = SystemColors.Control;
            planillaDeNotasToolStripMenuItem1.Name = "planillaDeNotasToolStripMenuItem1";
            planillaDeNotasToolStripMenuItem1.Size = new Size(321, 44);
            planillaDeNotasToolStripMenuItem1.Text = "Planilla de Notas";
            planillaDeNotasToolStripMenuItem1.Click += planillaDeNotasToolStripMenuItem1_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planillaDeNotasToolStripMenuItem, cursosToolStripMenuItem, materiasToolStripMenuItem, seccionesToolStripMenuItem });
            mantenimientoToolStripMenuItem.Font = new Font("Segoe UI", 18.0173912F);
            mantenimientoToolStripMenuItem.ForeColor = Color.White;
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(226, 44);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // planillaDeNotasToolStripMenuItem
            // 
            planillaDeNotasToolStripMenuItem.BackColor = Color.FromArgb(64, 52, 116);
            planillaDeNotasToolStripMenuItem.ForeColor = SystemColors.Control;
            planillaDeNotasToolStripMenuItem.Name = "planillaDeNotasToolStripMenuItem";
            planillaDeNotasToolStripMenuItem.Size = new Size(230, 44);
            planillaDeNotasToolStripMenuItem.Text = "Personas";
            planillaDeNotasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.BackColor = Color.FromArgb(64, 52, 116);
            cursosToolStripMenuItem.ForeColor = SystemColors.Control;
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(230, 44);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.BackColor = Color.FromArgb(64, 52, 116);
            materiasToolStripMenuItem.ForeColor = SystemColors.Control;
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(230, 44);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // seccionesToolStripMenuItem
            // 
            seccionesToolStripMenuItem.BackColor = Color.FromArgb(64, 52, 116);
            seccionesToolStripMenuItem.ForeColor = SystemColors.Control;
            seccionesToolStripMenuItem.Name = "seccionesToolStripMenuItem";
            seccionesToolStripMenuItem.Size = new Size(230, 44);
            seccionesToolStripMenuItem.Text = "Secciones";
            seccionesToolStripMenuItem.Click += seccionesToolStripMenuItem_Click;
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(64, 52, 116);
            panelBarra.Controls.Add(PlataformaVirtual);
            panelBarra.Controls.Add(menuStrip1);
            panelBarra.Controls.Add(Academia);
            panelBarra.Controls.Add(Imagen);
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(0, 0);
            panelBarra.Margin = new Padding(2);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(1902, 140);
            panelBarra.TabIndex = 1;
            // 
            // PlataformaVirtual
            // 
            PlataformaVirtual.AutoSize = true;
            PlataformaVirtual.Font = new Font("Segoe UI", 15F);
            PlataformaVirtual.ForeColor = SystemColors.ButtonFace;
            PlataformaVirtual.Location = new Point(169, 77);
            PlataformaVirtual.Name = "PlataformaVirtual";
            PlataformaVirtual.Size = new Size(204, 32);
            PlataformaVirtual.TabIndex = 4;
            PlataformaVirtual.Text = "Plataforma Virtual";
            // 
            // Academia
            // 
            Academia.AutoSize = true;
            Academia.Font = new Font("Cooper Black", 24F);
            Academia.ForeColor = SystemColors.ButtonFace;
            Academia.Location = new Point(147, 32);
            Academia.Name = "Academia";
            Academia.Size = new Size(215, 45);
            Academia.TabIndex = 3;
            Academia.Text = "Academia";
            // 
            // Imagen
            // 
            Imagen.Image = Properties.Resources.Book;
            Imagen.Location = new Point(9, 0);
            Imagen.Margin = new Padding(0);
            Imagen.Name = "Imagen";
            Imagen.Size = new Size(122, 142);
            Imagen.TabIndex = 1;
            Imagen.TabStop = false;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 44);
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1035);
            Controls.Add(panelBarra);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem inscripcionToolStripMenuItem;
        private Panel panelBarra;
        private PictureBox Imagen;
        private Label Academia;
        private Label PlataformaVirtual;
        private ToolStripMenuItem planillaDeNotasToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem seccionesToolStripMenuItem;
        private ToolStripMenuItem planillaDeNotasToolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox1;
    }
}
