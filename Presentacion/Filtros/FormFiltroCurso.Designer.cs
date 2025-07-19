namespace Sistema_Academia.Presentacion.Filtros
{
    partial class FormFiltroCurso
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
            cmbseccion = new ComboBox();
            cmbmateria = new ComboBox();
            labelsec = new Label();
            labelmateria = new Label();
            aceptar = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // cmbseccion
            // 
            cmbseccion.BackColor = Color.FromArgb(13, 13, 13);
            cmbseccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbseccion.ForeColor = SystemColors.Menu;
            cmbseccion.FormattingEnabled = true;
            cmbseccion.Location = new Point(84, 254);
            cmbseccion.Name = "cmbseccion";
            cmbseccion.Size = new Size(314, 38);
            cmbseccion.TabIndex = 27;
            // 
            // cmbmateria
            // 
            cmbmateria.BackColor = Color.FromArgb(13, 13, 13);
            cmbmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmateria.ForeColor = SystemColors.Menu;
            cmbmateria.FormattingEnabled = true;
            cmbmateria.Location = new Point(84, 163);
            cmbmateria.Name = "cmbmateria";
            cmbmateria.Size = new Size(314, 38);
            cmbmateria.TabIndex = 26;
            // 
            // labelsec
            // 
            labelsec.AutoSize = true;
            labelsec.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsec.ForeColor = Color.White;
            labelsec.Location = new Point(94, 221);
            labelsec.Name = "labelsec";
            labelsec.Size = new Size(92, 30);
            labelsec.TabIndex = 25;
            labelsec.Text = "Sección:";
            // 
            // labelmateria
            // 
            labelmateria.AutoSize = true;
            labelmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmateria.ForeColor = Color.White;
            labelmateria.Location = new Point(94, 130);
            labelmateria.Name = "labelmateria";
            labelmateria.Size = new Size(92, 30);
            labelmateria.TabIndex = 24;
            labelmateria.Text = "Materia:";
            // 
            // aceptar
            // 
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(143, 361);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(190, 48);
            aceptar.TabIndex = 23;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(182, 64);
            title.Name = "title";
            title.Size = new Size(115, 36);
            title.TabIndex = 22;
            title.Text = "FILTROS";
            // 
            // FormFiltroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 505);
            Controls.Add(cmbseccion);
            Controls.Add(cmbmateria);
            Controls.Add(labelsec);
            Controls.Add(labelmateria);
            Controls.Add(aceptar);
            Controls.Add(title);
            Name = "FormFiltroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbseccion;
        private ComboBox cmbmateria;
        private Label labelsec;
        private Label labelmateria;
        private Button aceptar;
        private Label title;
    }
}