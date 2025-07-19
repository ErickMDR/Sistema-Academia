namespace Sistema_Academia.Presentacion.Filtros
{
    partial class FormAsignar
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
            panel = new Panel();
            txtnota = new TextBox();
            aceptar = new Button();
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
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(txtnota);
            panel.Controls.Add(aceptar);
            panel.Controls.Add(labelnota);
            panel.Controls.Add(txtcedula);
            panel.Controls.Add(labelci);
            panel.Controls.Add(labelmateria);
            panel.Controls.Add(asignar);
            panel.Controls.Add(txtmateria);
            panel.Controls.Add(txtapellido);
            panel.Controls.Add(labelna);
            panel.Controls.Add(labelap);
            panel.Controls.Add(txtnombre);
            panel.Location = new Point(1, 2);
            panel.Name = "panel";
            panel.Size = new Size(482, 655);
            panel.TabIndex = 14;
            // 
            // txtnota
            // 
            txtnota.BackColor = Color.FromArgb(13, 13, 13);
            txtnota.CharacterCasing = CharacterCasing.Lower;
            txtnota.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnota.ForeColor = Color.White;
            txtnota.Location = new Point(83, 485);
            txtnota.Margin = new Padding(20);
            txtnota.MaxLength = 2;
            txtnota.Name = "txtnota";
            txtnota.PlaceholderText = "Ingrese nota";
            txtnota.ShortcutsEnabled = false;
            txtnota.Size = new Size(314, 37);
            txtnota.TabIndex = 13;
            // 
            // aceptar
            // 
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(149, 564);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(190, 48);
            aceptar.TabIndex = 4;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            // 
            // labelnota
            // 
            labelnota.AutoSize = true;
            labelnota.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnota.ForeColor = Color.White;
            labelnota.Location = new Point(93, 453);
            labelnota.Name = "labelnota";
            labelnota.Size = new Size(65, 30);
            labelnota.TabIndex = 12;
            labelnota.Text = "Nota:";
            // 
            // txtcedula
            // 
            txtcedula.BackColor = Color.FromArgb(13, 13, 13);
            txtcedula.CharacterCasing = CharacterCasing.Lower;
            txtcedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcedula.ForeColor = Color.White;
            txtcedula.Location = new Point(83, 125);
            txtcedula.Margin = new Padding(20);
            txtcedula.MaxLength = 20;
            txtcedula.Name = "txtcedula";
            txtcedula.PlaceholderText = "Ingrese cédula";
            txtcedula.ShortcutsEnabled = false;
            txtcedula.Size = new Size(314, 37);
            txtcedula.TabIndex = 1;
            // 
            // labelci
            // 
            labelci.AutoSize = true;
            labelci.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelci.ForeColor = Color.White;
            labelci.Location = new Point(93, 92);
            labelci.Name = "labelci";
            labelci.Size = new Size(85, 30);
            labelci.TabIndex = 2;
            labelci.Text = "Cédula:";
            // 
            // labelmateria
            // 
            labelmateria.AutoSize = true;
            labelmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmateria.ForeColor = Color.White;
            labelmateria.Location = new Point(93, 371);
            labelmateria.Name = "labelmateria";
            labelmateria.Size = new Size(92, 30);
            labelmateria.TabIndex = 10;
            labelmateria.Text = "Materia:";
            // 
            // asignar
            // 
            asignar.AutoSize = true;
            asignar.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asignar.ForeColor = Color.White;
            asignar.Location = new Point(131, 31);
            asignar.Name = "asignar";
            asignar.Size = new Size(208, 36);
            asignar.TabIndex = 3;
            asignar.Text = "ASIGNAR NOTA";
            // 
            // txtmateria
            // 
            txtmateria.BackColor = Color.FromArgb(13, 13, 13);
            txtmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmateria.ForeColor = Color.White;
            txtmateria.Location = new Point(83, 404);
            txtmateria.Margin = new Padding(20);
            txtmateria.MaxLength = 50;
            txtmateria.Name = "txtmateria";
            txtmateria.PlaceholderText = "Ingrese materia";
            txtmateria.ShortcutsEnabled = false;
            txtmateria.Size = new Size(314, 37);
            txtmateria.TabIndex = 9;
            // 
            // txtapellido
            // 
            txtapellido.BackColor = Color.FromArgb(13, 13, 13);
            txtapellido.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtapellido.ForeColor = Color.White;
            txtapellido.Location = new Point(83, 293);
            txtapellido.Margin = new Padding(20);
            txtapellido.MaxLength = 30;
            txtapellido.Name = "txtapellido";
            txtapellido.PlaceholderText = "Ingrese apellido";
            txtapellido.ShortcutsEnabled = false;
            txtapellido.Size = new Size(314, 37);
            txtapellido.TabIndex = 5;
            // 
            // labelna
            // 
            labelna.AutoSize = true;
            labelna.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelna.ForeColor = Color.White;
            labelna.Location = new Point(93, 176);
            labelna.Name = "labelna";
            labelna.Size = new Size(99, 30);
            labelna.TabIndex = 8;
            labelna.Text = "Nombre:";
            // 
            // labelap
            // 
            labelap.AutoSize = true;
            labelap.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelap.ForeColor = Color.White;
            labelap.Location = new Point(93, 260);
            labelap.Name = "labelap";
            labelap.Size = new Size(98, 30);
            labelap.TabIndex = 6;
            labelap.Text = "Apellido:";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.FromArgb(13, 13, 13);
            txtnombre.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(83, 209);
            txtnombre.Margin = new Padding(20);
            txtnombre.MaxLength = 30;
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Ingrese nombre";
            txtnombre.ShortcutsEnabled = false;
            txtnombre.Size = new Size(314, 37);
            txtnombre.TabIndex = 7;
            // 
            // FormAsignar
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 655);
            Controls.Add(panel);
            Name = "FormAsignar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Nota";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TextBox txtnota;
        private Button aceptar;
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