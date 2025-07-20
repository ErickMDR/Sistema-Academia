namespace Sistema_Academia.Presentacion
{
    partial class FormMantenimientoMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimientoMateria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelInfo = new Panel();
            pictureBox1 = new PictureBox();
            buscar = new PictureBox();
            editar = new Button();
            piceliminar = new PictureBox();
            picinscribir = new PictureBox();
            txtmateria = new TextBox();
            eliminar = new Button();
            agregar = new Button();
            panel = new Panel();
            dataGridViewTabla = new DataGridView();
            title = new Label();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piceliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picinscribir).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(22, 18, 30);
            panelInfo.Controls.Add(pictureBox1);
            panelInfo.Controls.Add(buscar);
            panelInfo.Controls.Add(editar);
            panelInfo.Controls.Add(piceliminar);
            panelInfo.Controls.Add(picinscribir);
            panelInfo.Controls.Add(txtmateria);
            panelInfo.Controls.Add(eliminar);
            panelInfo.Controls.Add(agregar);
            panelInfo.Controls.Add(panel);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(0, -5);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1902, 850);
            panelInfo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(648, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 23);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // buscar
            // 
            buscar.Cursor = Cursors.Hand;
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(258, 18);
            buscar.Name = "buscar";
            buscar.Size = new Size(39, 41);
            buscar.TabIndex = 7;
            buscar.TabStop = false;
            buscar.Click += buscar_Click_1;
            // 
            // editar
            // 
            editar.BackColor = Color.FromArgb(22, 18, 30);
            editar.Cursor = Cursors.Hand;
            editar.FlatAppearance.BorderColor = Color.FromArgb(22, 18, 30);
            editar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            editar.FlatStyle = FlatStyle.Flat;
            editar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editar.ForeColor = Color.Snow;
            editar.Location = new Point(672, 19);
            editar.Name = "editar";
            editar.Size = new Size(79, 40);
            editar.TabIndex = 10;
            editar.Text = "Editar";
            editar.TextAlign = ContentAlignment.MiddleRight;
            editar.UseVisualStyleBackColor = false;
            // 
            // piceliminar
            // 
            piceliminar.Image = (Image)resources.GetObject("piceliminar.Image");
            piceliminar.Location = new Point(505, 19);
            piceliminar.Name = "piceliminar";
            piceliminar.Size = new Size(31, 40);
            piceliminar.TabIndex = 6;
            piceliminar.TabStop = false;
            // 
            // picinscribir
            // 
            picinscribir.BackgroundImage = Properties.Resources.Plus;
            picinscribir.Image = Properties.Resources.Plus;
            picinscribir.Location = new Point(349, 17);
            picinscribir.Name = "picinscribir";
            picinscribir.Size = new Size(41, 41);
            picinscribir.TabIndex = 5;
            picinscribir.TabStop = false;
            // 
            // txtmateria
            // 
            txtmateria.BackColor = Color.FromArgb(22, 18, 30);
            txtmateria.Cursor = Cursors.IBeam;
            txtmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmateria.ForeColor = Color.White;
            txtmateria.Location = new Point(69, 19);
            txtmateria.Margin = new Padding(20);
            txtmateria.MaxLength = 20;
            txtmateria.Name = "txtmateria";
            txtmateria.PlaceholderText = "Materia";
            txtmateria.ShortcutsEnabled = false;
            txtmateria.Size = new Size(184, 37);
            txtmateria.TabIndex = 3;
            // 
            // eliminar
            // 
            eliminar.BackColor = Color.FromArgb(22, 18, 30);
            eliminar.Cursor = Cursors.Hand;
            eliminar.FlatAppearance.BorderColor = Color.FromArgb(22, 18, 30);
            eliminar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eliminar.ForeColor = Color.Snow;
            eliminar.Location = new Point(506, 19);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(127, 40);
            eliminar.TabIndex = 1;
            eliminar.Text = "Eliminar";
            eliminar.TextAlign = ContentAlignment.MiddleRight;
            eliminar.UseVisualStyleBackColor = false;
            // 
            // agregar
            // 
            agregar.BackColor = Color.FromArgb(22, 18, 30);
            agregar.Cursor = Cursors.Hand;
            agregar.FlatAppearance.BorderColor = Color.FromArgb(22, 18, 30);
            agregar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            agregar.FlatStyle = FlatStyle.Flat;
            agregar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agregar.ForeColor = Color.Snow;
            agregar.Location = new Point(354, 17);
            agregar.Name = "agregar";
            agregar.Size = new Size(136, 40);
            agregar.TabIndex = 0;
            agregar.Text = "Agregar";
            agregar.TextAlign = ContentAlignment.MiddleRight;
            agregar.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Controls.Add(dataGridViewTabla);
            panel.Controls.Add(title);
            panel.Location = new Point(33, 65);
            panel.Name = "panel";
            panel.Size = new Size(1850, 770);
            panel.TabIndex = 0;
            // 
            // dataGridViewTabla
            // 
            dataGridViewTabla.AllowUserToAddRows = false;
            dataGridViewTabla.AllowUserToDeleteRows = false;
            dataGridViewTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTabla.BackgroundColor = Color.FromArgb(22, 18, 30);
            dataGridViewTabla.BorderStyle = BorderStyle.None;
            dataGridViewTabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(30, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTabla.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTabla.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTabla.EnableHeadersVisualStyles = false;
            dataGridViewTabla.GridColor = Color.LightGray;
            dataGridViewTabla.Location = new Point(-3, 65);
            dataGridViewTabla.Name = "dataGridViewTabla";
            dataGridViewTabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTabla.RowHeadersWidth = 49;
            dataGridViewTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTabla.Size = new Size(1850, 706);
            dataGridViewTabla.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.Control;
            title.Location = new Point(719, 13);
            title.Name = "title";
            title.Size = new Size(399, 40);
            title.TabIndex = 2;
            title.Text = "MANTENIMIENTO MATERIA";
            // 
            // FormMantenimientoMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 845);
            Controls.Add(panelInfo);
            Name = "FormMantenimientoMateria";
            Text = "Mantenimiento Materia";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)piceliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picinscribir).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private PictureBox buscar;
        private PictureBox piceliminar;
        private PictureBox picinscribir;
        private TextBox txtmateria;
        private Button eliminar;
        private Button agregar;
        private Panel panel;
        public DataGridView dataGridViewTabla;
        private Label title;
        private PictureBox pictureBox1;
        private Button editar;
    }
}