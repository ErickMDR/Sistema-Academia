namespace Sistema_Academia.Presentacion.Agregar
{
    partial class FormAsignarNota
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
            txtnota = new TextBox();
            asignarNota = new Button();
            labelnota = new Label();
            txtcedula = new TextBox();
            labelci = new Label();
            labelmateria = new Label();
            asignar = new Label();
            txtmateria = new TextBox();
            txtapellido = new TextBox();
            labelna = new Label();
            labelap = new Label();
            txtnombre = new TextBox();
            SuspendLayout();
            // 
            // txtnota
            // 
            txtnota.BackColor = Color.FromArgb(13, 13, 13);
            txtnota.CharacterCasing = CharacterCasing.Lower;
            txtnota.Cursor = Cursors.IBeam;
            txtnota.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnota.ForeColor = Color.White;
            txtnota.Location = new Point(84, 474);
            txtnota.Margin = new Padding(20);
            txtnota.MaxLength = 2;
            txtnota.Name = "txtnota";
            txtnota.PlaceholderText = "Ingrese nota";
            txtnota.ShortcutsEnabled = false;
            txtnota.Size = new Size(314, 37);
            txtnota.TabIndex = 25;
            // 
            // asignarNota
            // 
            asignarNota.Cursor = Cursors.Hand;
            asignarNota.FlatAppearance.BorderColor = Color.White;
            asignarNota.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            asignarNota.FlatStyle = FlatStyle.Flat;
            asignarNota.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asignarNota.ForeColor = Color.Snow;
            asignarNota.Location = new Point(156, 557);
            asignarNota.Name = "asignarNota";
            asignarNota.Size = new Size(162, 56);
            asignarNota.TabIndex = 17;
            asignarNota.Text = "Asignar";
            asignarNota.UseVisualStyleBackColor = true;
            asignarNota.Click += asignarNota_Click_1;
            // 
            // labelnota
            // 
            labelnota.AutoSize = true;
            labelnota.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnota.ForeColor = Color.White;
            labelnota.Location = new Point(94, 442);
            labelnota.Name = "labelnota";
            labelnota.Size = new Size(65, 30);
            labelnota.TabIndex = 24;
            labelnota.Text = "Nota:";
            // 
            // txtcedula
            // 
            txtcedula.BackColor = Color.FromArgb(13, 13, 13);
            txtcedula.CharacterCasing = CharacterCasing.Lower;
            txtcedula.Enabled = false;
            txtcedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcedula.ForeColor = Color.White;
            txtcedula.Location = new Point(84, 131);
            txtcedula.Margin = new Padding(20);
            txtcedula.MaxLength = 20;
            txtcedula.Name = "txtcedula";
            txtcedula.ReadOnly = true;
            txtcedula.ShortcutsEnabled = false;
            txtcedula.Size = new Size(314, 37);
            txtcedula.TabIndex = 14;
            // 
            // labelci
            // 
            labelci.AutoSize = true;
            labelci.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelci.ForeColor = Color.White;
            labelci.Location = new Point(94, 98);
            labelci.Name = "labelci";
            labelci.Size = new Size(85, 30);
            labelci.TabIndex = 15;
            labelci.Text = "Cédula:";
            // 
            // labelmateria
            // 
            labelmateria.AutoSize = true;
            labelmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmateria.ForeColor = Color.White;
            labelmateria.Location = new Point(94, 352);
            labelmateria.Name = "labelmateria";
            labelmateria.Size = new Size(92, 30);
            labelmateria.TabIndex = 23;
            labelmateria.Text = "Materia:";
            // 
            // asignar
            // 
            asignar.AutoSize = true;
            asignar.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asignar.ForeColor = Color.White;
            asignar.Location = new Point(132, 37);
            asignar.Name = "asignar";
            asignar.Size = new Size(208, 36);
            asignar.TabIndex = 16;
            asignar.Text = "ASIGNAR NOTA";
            // 
            // txtmateria
            // 
            txtmateria.BackColor = Color.FromArgb(13, 13, 13);
            txtmateria.Enabled = false;
            txtmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmateria.ForeColor = Color.White;
            txtmateria.Location = new Point(84, 385);
            txtmateria.Margin = new Padding(20);
            txtmateria.MaxLength = 50;
            txtmateria.Name = "txtmateria";
            txtmateria.ReadOnly = true;
            txtmateria.ShortcutsEnabled = false;
            txtmateria.Size = new Size(314, 37);
            txtmateria.TabIndex = 22;
            // 
            // txtapellido
            // 
            txtapellido.BackColor = Color.FromArgb(13, 13, 13);
            txtapellido.Enabled = false;
            txtapellido.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtapellido.ForeColor = Color.White;
            txtapellido.Location = new Point(84, 299);
            txtapellido.Margin = new Padding(20);
            txtapellido.MaxLength = 30;
            txtapellido.Name = "txtapellido";
            txtapellido.ReadOnly = true;
            txtapellido.ShortcutsEnabled = false;
            txtapellido.Size = new Size(314, 37);
            txtapellido.TabIndex = 18;
            // 
            // labelna
            // 
            labelna.AutoSize = true;
            labelna.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelna.ForeColor = Color.White;
            labelna.Location = new Point(94, 182);
            labelna.Name = "labelna";
            labelna.Size = new Size(99, 30);
            labelna.TabIndex = 21;
            labelna.Text = "Nombre:";
            // 
            // labelap
            // 
            labelap.AutoSize = true;
            labelap.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelap.ForeColor = Color.White;
            labelap.Location = new Point(94, 266);
            labelap.Name = "labelap";
            labelap.Size = new Size(98, 30);
            labelap.TabIndex = 19;
            labelap.Text = "Apellido:";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.FromArgb(13, 13, 13);
            txtnombre.Enabled = false;
            txtnombre.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(84, 215);
            txtnombre.Margin = new Padding(20);
            txtnombre.MaxLength = 30;
            txtnombre.Name = "txtnombre";
            txtnombre.ReadOnly = true;
            txtnombre.ShortcutsEnabled = false;
            txtnombre.Size = new Size(314, 37);
            txtnombre.TabIndex = 20;
            // 
            // FormAsignarNota
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 655);
            Controls.Add(txtnota);
            Controls.Add(asignarNota);
            Controls.Add(labelnota);
            Controls.Add(txtcedula);
            Controls.Add(labelci);
            Controls.Add(labelmateria);
            Controls.Add(asignar);
            Controls.Add(txtmateria);
            Controls.Add(txtapellido);
            Controls.Add(labelna);
            Controls.Add(labelap);
            Controls.Add(txtnombre);
            Name = "FormAsignarNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnota;
        private Button asignarNota;
        private Label labelnota;
        private TextBox txtcedula;
        private Label labelci;
        private Label labelmateria;
        private Label asignar;
        private TextBox txtmateria;
        private TextBox txtapellido;
        private Label labelna;
        private Label labelap;
        private TextBox txtnombre;
    }
}