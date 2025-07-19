namespace Sistema_Academia.Presentacion.Agregar
{
    partial class FormAgregarSeccion
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
            labelna = new Label();
            txtseccion = new TextBox();
            aceptar = new Button();
            title = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(13, 13, 13);
            panel.Controls.Add(labelna);
            panel.Controls.Add(txtseccion);
            panel.Controls.Add(aceptar);
            panel.Controls.Add(title);
            panel.Location = new Point(1, 0);
            panel.Name = "panel";
            panel.Size = new Size(482, 359);
            panel.TabIndex = 15;
            // 
            // labelna
            // 
            labelna.AutoSize = true;
            labelna.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelna.ForeColor = Color.White;
            labelna.Location = new Point(94, 130);
            labelna.Name = "labelna";
            labelna.Size = new Size(92, 30);
            labelna.TabIndex = 17;
            labelna.Text = "Sección:";
            // 
            // txtseccion
            // 
            txtseccion.BackColor = Color.FromArgb(13, 13, 13);
            txtseccion.CharacterCasing = CharacterCasing.Upper;
            txtseccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtseccion.ForeColor = Color.White;
            txtseccion.Location = new Point(84, 163);
            txtseccion.Margin = new Padding(20);
            txtseccion.MaxLength = 1;
            txtseccion.Name = "txtseccion";
            txtseccion.PlaceholderText = "Ingrese sección";
            txtseccion.ShortcutsEnabled = false;
            txtseccion.Size = new Size(314, 37);
            txtseccion.TabIndex = 16;
            // 
            // aceptar
            // 
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.77391F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(150, 248);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(190, 48);
            aceptar.TabIndex = 15;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.27826F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(123, 62);
            title.Name = "title";
            title.Size = new Size(236, 36);
            title.TabIndex = 14;
            title.Text = "AGREGAR/EDITAR";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAgregarSeccion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 355);
            Controls.Add(panel);
            Name = "FormAgregarSeccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sección";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Label labelna;
        private TextBox txtseccion;
        private Button aceptar;
        private Label title;
    }
}