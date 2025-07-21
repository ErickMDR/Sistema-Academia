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
            labelsec = new Label();
            labelmateria = new Label();
            filtrar = new Button();
            title = new Label();
            txtseccion = new TextBox();
            txtmateria = new TextBox();
            SuspendLayout();
            // 
            // labelsec
            // 
            labelsec.AutoSize = true;
            labelsec.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsec.ForeColor = Color.White;
            labelsec.Location = new Point(94, 194);
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
            labelmateria.Location = new Point(94, 103);
            labelmateria.Name = "labelmateria";
            labelmateria.Size = new Size(92, 30);
            labelmateria.TabIndex = 24;
            labelmateria.Text = "Materia:";
            // 
            // filtrar
            // 
            filtrar.Cursor = Cursors.Hand;
            filtrar.FlatAppearance.BorderColor = Color.White;
            filtrar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            filtrar.FlatStyle = FlatStyle.Flat;
            filtrar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filtrar.ForeColor = Color.Snow;
            filtrar.Location = new Point(157, 309);
            filtrar.Name = "filtrar";
            filtrar.Size = new Size(162, 56);
            filtrar.TabIndex = 23;
            filtrar.Text = "Filtrar";
            filtrar.UseVisualStyleBackColor = true;
            filtrar.Click += aceptar_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(181, 39);
            title.Name = "title";
            title.Size = new Size(115, 36);
            title.TabIndex = 22;
            title.Text = "FILTROS";
            // 
            // txtseccion
            // 
            txtseccion.BackColor = Color.FromArgb(13, 13, 13);
            txtseccion.CharacterCasing = CharacterCasing.Upper;
            txtseccion.Cursor = Cursors.IBeam;
            txtseccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtseccion.ForeColor = Color.White;
            txtseccion.Location = new Point(81, 229);
            txtseccion.Margin = new Padding(20);
            txtseccion.MaxLength = 1;
            txtseccion.Name = "txtseccion";
            txtseccion.PlaceholderText = "Ingrese sección";
            txtseccion.ShortcutsEnabled = false;
            txtseccion.Size = new Size(314, 37);
            txtseccion.TabIndex = 27;
            // 
            // txtmateria
            // 
            txtmateria.BackColor = Color.FromArgb(13, 13, 13);
            txtmateria.Cursor = Cursors.IBeam;
            txtmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmateria.ForeColor = Color.White;
            txtmateria.Location = new Point(81, 137);
            txtmateria.Margin = new Padding(20);
            txtmateria.MaxLength = 50;
            txtmateria.Name = "txtmateria";
            txtmateria.PlaceholderText = "Ingrese materia";
            txtmateria.ShortcutsEnabled = false;
            txtmateria.Size = new Size(314, 37);
            txtmateria.TabIndex = 26;
            // 
            // FormFiltroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 405);
            Controls.Add(txtseccion);
            Controls.Add(txtmateria);
            Controls.Add(labelsec);
            Controls.Add(labelmateria);
            Controls.Add(filtrar);
            Controls.Add(title);
            Name = "FormFiltroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelsec;
        private Label labelmateria;
        private Button filtrar;
        private Label title;
        private TextBox txtseccion;
        private TextBox txtmateria;
    }
}