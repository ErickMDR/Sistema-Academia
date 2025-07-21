namespace Sistema_Academia.Presentacion.Agregar
{
    partial class FormAgregarMateria
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
            txtmateria = new TextBox();
            aceptar = new Button();
            title = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(13, 13, 13);
            panel.Controls.Add(labelna);
            panel.Controls.Add(txtmateria);
            panel.Controls.Add(aceptar);
            panel.Controls.Add(title);
            panel.Location = new Point(1, 0);
            panel.Name = "panel";
            panel.Size = new Size(482, 356);
            panel.TabIndex = 15;
            // 
            // labelna
            // 
            labelna.AutoSize = true;
            labelna.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelna.ForeColor = Color.White;
            labelna.Location = new Point(94, 126);
            labelna.Name = "labelna";
            labelna.Size = new Size(210, 30);
            labelna.TabIndex = 14;
            labelna.Text = "Nombre de Materia:";
            // 
            // txtmateria
            // 
            txtmateria.BackColor = Color.FromArgb(13, 13, 13);
            txtmateria.Cursor = Cursors.IBeam;
            txtmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmateria.ForeColor = Color.White;
            txtmateria.Location = new Point(84, 162);
            txtmateria.Margin = new Padding(20);
            txtmateria.MaxLength = 50;
            txtmateria.Name = "txtmateria";
            txtmateria.PlaceholderText = "Ingrese materia";
            txtmateria.ShortcutsEnabled = false;
            txtmateria.Size = new Size(314, 37);
            txtmateria.TabIndex = 13;
            // 
            // aceptar
            // 
            aceptar.Cursor = Cursors.Hand;
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.77391F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(157, 256);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(162, 56);
            aceptar.TabIndex = 12;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.27826F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(125, 51);
            title.Name = "title";
            title.Size = new Size(236, 36);
            title.TabIndex = 11;
            title.Text = "AGREGAR/EDITAR";
            // 
            // FormAgregarMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 355);
            Controls.Add(panel);
            Name = "FormAgregarMateria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materia";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Label labelna;
        private TextBox txtmateria;
        private Button aceptar;
        private Label title;
    }
}