namespace Sistema_Academia.Presentacion.Agregar
{
    partial class FormInscribir
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
            cmbseccion = new ComboBox();
            cmbmateria = new ComboBox();
            aceptar = new Button();
            labelnota = new Label();
            txtcedula = new TextBox();
            labelci = new Label();
            labelmateria = new Label();
            asignar = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(cmbseccion);
            panel.Controls.Add(cmbmateria);
            panel.Controls.Add(aceptar);
            panel.Controls.Add(labelnota);
            panel.Controls.Add(txtcedula);
            panel.Controls.Add(labelci);
            panel.Controls.Add(labelmateria);
            panel.Controls.Add(asignar);
            panel.Location = new Point(2, 2);
            panel.Name = "panel";
            panel.Size = new Size(482, 511);
            panel.TabIndex = 15;
            // 
            // cmbseccion
            // 
            cmbseccion.BackColor = Color.FromArgb(13, 13, 13);
            cmbseccion.Cursor = Cursors.Hand;
            cmbseccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbseccion.ForeColor = SystemColors.Menu;
            cmbseccion.FormattingEnabled = true;
            cmbseccion.Location = new Point(83, 319);
            cmbseccion.Name = "cmbseccion";
            cmbseccion.Size = new Size(314, 38);
            cmbseccion.TabIndex = 29;
            // 
            // cmbmateria
            // 
            cmbmateria.BackColor = Color.FromArgb(13, 13, 13);
            cmbmateria.Cursor = Cursors.Hand;
            cmbmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmateria.ForeColor = SystemColors.Menu;
            cmbmateria.FormattingEnabled = true;
            cmbmateria.Location = new Point(83, 237);
            cmbmateria.Name = "cmbmateria";
            cmbmateria.Size = new Size(314, 38);
            cmbmateria.TabIndex = 28;
            // 
            // aceptar
            // 
            aceptar.Cursor = Cursors.Hand;
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(158, 406);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(162, 56);
            aceptar.TabIndex = 4;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            // 
            // labelnota
            // 
            labelnota.AutoSize = true;
            labelnota.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnota.ForeColor = Color.White;
            labelnota.Location = new Point(93, 286);
            labelnota.Name = "labelnota";
            labelnota.Size = new Size(92, 30);
            labelnota.TabIndex = 12;
            labelnota.Text = "Sección:";
            // 
            // txtcedula
            // 
            txtcedula.BackColor = Color.FromArgb(13, 13, 13);
            txtcedula.CharacterCasing = CharacterCasing.Lower;
            txtcedula.Cursor = Cursors.IBeam;
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
            labelmateria.Location = new Point(93, 204);
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
            asignar.Location = new Point(173, 31);
            asignar.Name = "asignar";
            asignar.Size = new Size(142, 36);
            asignar.TabIndex = 3;
            asignar.Text = "INSCRIBIR";
            // 
            // FormInscribir
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 505);
            Controls.Add(panel);
            Name = "FormInscribir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscribir";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button aceptar;
        private Label labelnota;
        private TextBox txtcedula;
        private Label labelci;
        private Label labelmateria;
        private Label asignar;
        private ComboBox cmbseccion;
        private ComboBox cmbmateria;
    }
}