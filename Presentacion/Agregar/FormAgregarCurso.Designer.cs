namespace Sistema_Academia.Presentacion.Agregar
{
    partial class FormAgregarCurso
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
            panel1 = new Panel();
            cmbSeccion = new ComboBox();
            cmbMateria = new ComboBox();
            title = new Label();
            aceptar = new Button();
            txtcedula = new TextBox();
            labelci = new Label();
            labelsec = new Label();
            labelmateria = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 13, 13);
            panel1.Controls.Add(cmbSeccion);
            panel1.Controls.Add(cmbMateria);
            panel1.Controls.Add(title);
            panel1.Controls.Add(aceptar);
            panel1.Controls.Add(txtcedula);
            panel1.Controls.Add(labelci);
            panel1.Controls.Add(labelsec);
            panel1.Controls.Add(labelmateria);
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 513);
            panel1.TabIndex = 31;
            // 
            // cmbSeccion
            // 
            cmbSeccion.BackColor = Color.FromArgb(13, 13, 13);
            cmbSeccion.Cursor = Cursors.Hand;
            cmbSeccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSeccion.ForeColor = Color.White;
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Location = new Point(81, 324);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(314, 38);
            cmbSeccion.TabIndex = 43;
            // 
            // cmbMateria
            // 
            cmbMateria.BackColor = Color.FromArgb(13, 13, 13);
            cmbMateria.Cursor = Cursors.Hand;
            cmbMateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMateria.ForeColor = Color.White;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(81, 242);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(314, 38);
            cmbMateria.TabIndex = 42;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(125, 51);
            title.Name = "title";
            title.Size = new Size(236, 36);
            title.TabIndex = 41;
            title.Text = "AGREGAR/EDITAR";
            // 
            // aceptar
            // 
            aceptar.BackColor = Color.FromArgb(13, 13, 13);
            aceptar.Cursor = Cursors.Hand;
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(154, 406);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(162, 56);
            aceptar.TabIndex = 40;
            aceptar.Text = "Aceptar";
            aceptar.UseMnemonic = false;
            aceptar.UseVisualStyleBackColor = false;
            // 
            // txtcedula
            // 
            txtcedula.BackColor = Color.FromArgb(13, 13, 13);
            txtcedula.CharacterCasing = CharacterCasing.Lower;
            txtcedula.Cursor = Cursors.IBeam;
            txtcedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcedula.ForeColor = Color.White;
            txtcedula.Location = new Point(81, 152);
            txtcedula.Margin = new Padding(20);
            txtcedula.MaxLength = 20;
            txtcedula.Name = "txtcedula";
            txtcedula.PlaceholderText = "Ingrese cédula";
            txtcedula.ShortcutsEnabled = false;
            txtcedula.Size = new Size(314, 37);
            txtcedula.TabIndex = 34;
            // 
            // labelci
            // 
            labelci.AutoSize = true;
            labelci.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelci.ForeColor = Color.White;
            labelci.Location = new Point(91, 119);
            labelci.Name = "labelci";
            labelci.Size = new Size(173, 30);
            labelci.TabIndex = 35;
            labelci.Text = "Cédula Profesor:";
            // 
            // labelsec
            // 
            labelsec.AutoSize = true;
            labelsec.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsec.ForeColor = Color.White;
            labelsec.Location = new Point(91, 291);
            labelsec.Name = "labelsec";
            labelsec.Size = new Size(92, 30);
            labelsec.TabIndex = 32;
            labelsec.Text = "Sección:";
            // 
            // labelmateria
            // 
            labelmateria.AutoSize = true;
            labelmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmateria.ForeColor = Color.White;
            labelmateria.Location = new Point(91, 209);
            labelmateria.Name = "labelmateria";
            labelmateria.Size = new Size(92, 30);
            labelmateria.TabIndex = 31;
            labelmateria.Text = "Materia:";
            // 
            // FormAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 505);
            Controls.Add(panel1);
            Name = "FormAgregarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Curso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label title;
        private Button aceptar;
        private TextBox txtcedula;
        private Label labelci;
        private TextBox txtapellido;
        private Label labelna;
        private Label labelap;
        private TextBox txtnombre;
        private Label labelsec;
        private Label labelmateria;
        private ComboBox cmbSeccion;
        private ComboBox cmbMateria;
    }
}