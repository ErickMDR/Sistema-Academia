namespace Sistema_Academia.Presentacion
{
    partial class FormMantenimientoPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimientoPersona));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            agregar = new Button();
            panelInfo = new Panel();
            pictureBox2 = new PictureBox();
            picfiltro = new PictureBox();
            editar = new Button();
            buscar = new PictureBox();
            pictureBox1 = new PictureBox();
            piceliminar = new PictureBox();
            picinscribir = new PictureBox();
            txtcedula = new TextBox();
            filtros = new Button();
            eliminar = new Button();
            panelNotas = new Panel();
            dataGridViewTabla = new DataGridView();
            title = new Label();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picfiltro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piceliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picinscribir).BeginInit();
            panelNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).BeginInit();
            SuspendLayout();
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
            agregar.Location = new Point(442, 17);
            agregar.Name = "agregar";
            agregar.Size = new Size(136, 40);
            agregar.TabIndex = 0;
            agregar.Text = "Agregar";
            agregar.TextAlign = ContentAlignment.MiddleRight;
            agregar.UseVisualStyleBackColor = false;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(22, 18, 30);
            panelInfo.Controls.Add(pictureBox2);
            panelInfo.Controls.Add(picfiltro);
            panelInfo.Controls.Add(editar);
            panelInfo.Controls.Add(buscar);
            panelInfo.Controls.Add(pictureBox1);
            panelInfo.Controls.Add(piceliminar);
            panelInfo.Controls.Add(picinscribir);
            panelInfo.Controls.Add(txtcedula);
            panelInfo.Controls.Add(filtros);
            panelInfo.Controls.Add(eliminar);
            panelInfo.Controls.Add(agregar);
            panelInfo.Controls.Add(panelNotas);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(0, -5);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1902, 850);
            panelInfo.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(736, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 23);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // picfiltro
            // 
            picfiltro.BackgroundImage = (Image)resources.GetObject("picfiltro.BackgroundImage");
            picfiltro.Image = Properties.Resources.Filter;
            picfiltro.Location = new Point(330, 26);
            picfiltro.Name = "picfiltro";
            picfiltro.Size = new Size(23, 24);
            picfiltro.TabIndex = 4;
            picfiltro.TabStop = false;
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
            editar.Location = new Point(761, 19);
            editar.Name = "editar";
            editar.Size = new Size(79, 40);
            editar.TabIndex = 10;
            editar.Text = "Editar";
            editar.TextAlign = ContentAlignment.MiddleRight;
            editar.UseVisualStyleBackColor = false;
            editar.Click += editar_Click_1;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(314, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 41);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // piceliminar
            // 
            piceliminar.Image = (Image)resources.GetObject("piceliminar.Image");
            piceliminar.Location = new Point(593, 19);
            piceliminar.Name = "piceliminar";
            piceliminar.Size = new Size(31, 40);
            piceliminar.TabIndex = 6;
            piceliminar.TabStop = false;
            // 
            // picinscribir
            // 
            picinscribir.BackgroundImage = Properties.Resources.Plus;
            picinscribir.Image = Properties.Resources.Plus;
            picinscribir.Location = new Point(437, 17);
            picinscribir.Name = "picinscribir";
            picinscribir.Size = new Size(41, 41);
            picinscribir.TabIndex = 5;
            picinscribir.TabStop = false;
            // 
            // txtcedula
            // 
            txtcedula.BackColor = Color.FromArgb(22, 18, 30);
            txtcedula.CharacterCasing = CharacterCasing.Lower;
            txtcedula.Cursor = Cursors.IBeam;
            txtcedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcedula.ForeColor = Color.White;
            txtcedula.Location = new Point(69, 19);
            txtcedula.Margin = new Padding(20);
            txtcedula.MaxLength = 20;
            txtcedula.Name = "txtcedula";
            txtcedula.PlaceholderText = "Cédula";
            txtcedula.ShortcutsEnabled = false;
            txtcedula.Size = new Size(184, 37);
            txtcedula.TabIndex = 3;
            // 
            // filtros
            // 
            filtros.BackColor = Color.FromArgb(22, 18, 30);
            filtros.Cursor = Cursors.Hand;
            filtros.FlatAppearance.BorderColor = Color.FromArgb(22, 18, 30);
            filtros.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            filtros.FlatStyle = FlatStyle.Flat;
            filtros.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filtros.ForeColor = Color.Snow;
            filtros.Location = new Point(326, 18);
            filtros.Name = "filtros";
            filtros.Size = new Size(105, 40);
            filtros.TabIndex = 2;
            filtros.Text = "Filtros";
            filtros.TextAlign = ContentAlignment.MiddleRight;
            filtros.UseMnemonic = false;
            filtros.UseVisualStyleBackColor = false;
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
            eliminar.Location = new Point(593, 19);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(127, 40);
            eliminar.TabIndex = 1;
            eliminar.Text = "Eliminar";
            eliminar.TextAlign = ContentAlignment.MiddleRight;
            eliminar.UseVisualStyleBackColor = false;
            // 
            // panelNotas
            // 
            panelNotas.BorderStyle = BorderStyle.Fixed3D;
            panelNotas.Controls.Add(dataGridViewTabla);
            panelNotas.Controls.Add(title);
            panelNotas.Location = new Point(33, 65);
            panelNotas.Name = "panelNotas";
            panelNotas.Size = new Size(1850, 770);
            panelNotas.TabIndex = 0;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(30, 5, 5, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTabla.ColumnHeadersHeight = 50;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewTabla.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTabla.EnableHeadersVisualStyles = false;
            dataGridViewTabla.GridColor = Color.LightGray;
            dataGridViewTabla.Location = new Point(-2, 65);
            dataGridViewTabla.Name = "dataGridViewTabla";
            dataGridViewTabla.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            title.Location = new Point(751, 13);
            title.Name = "title";
            title.Size = new Size(406, 40);
            title.TabIndex = 2;
            title.Text = "MANTENIMIENTO PERSONA";
            // 
            // FormMantenimientoPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 845);
            Controls.Add(panelInfo);
            Name = "FormMantenimientoPersona";
            Text = "Mantenimiento Persona";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picfiltro).EndInit();
            ((System.ComponentModel.ISupportInitialize)buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)piceliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picinscribir).EndInit();
            panelNotas.ResumeLayout(false);
            panelNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button agregar;
        private Panel panelInfo;
        private Panel panelNotas;
        public DataGridView dataGridViewTabla;
        private Label title;
        private Button eliminar;
        private Button filtros;
        private TextBox txtcedula;
        private PictureBox picfiltro;
        private PictureBox piceliminar;
        private PictureBox picinscribir;
        private PictureBox buscar;
        private PictureBox pictureBox1;
        private Button editar;
        private PictureBox pictureBox2;
    }
}