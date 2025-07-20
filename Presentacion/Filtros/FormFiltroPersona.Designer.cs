namespace Sistema_Academia.Presentacion.Filtros
{
    partial class FormFiltroPersona
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
            cmbtipopersona = new ComboBox();
            labelsec = new Label();
            labelmateria = new Label();
            aceptar = new Button();
            labeltipopersona = new Label();
            title = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(13, 13, 13);
            panel.Controls.Add(cmbseccion);
            panel.Controls.Add(cmbmateria);
            panel.Controls.Add(cmbtipopersona);
            panel.Controls.Add(labelsec);
            panel.Controls.Add(labelmateria);
            panel.Controls.Add(aceptar);
            panel.Controls.Add(labeltipopersona);
            panel.Controls.Add(title);
            panel.Location = new Point(0, -2);
            panel.Name = "panel";
            panel.Size = new Size(482, 558);
            panel.TabIndex = 16;
            // 
            // cmbseccion
            // 
            cmbseccion.BackColor = Color.FromArgb(13, 13, 13);
            cmbseccion.Cursor = Cursors.Hand;
            cmbseccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbseccion.ForeColor = SystemColors.Menu;
            cmbseccion.FormattingEnabled = true;
            cmbseccion.Location = new Point(81, 241);
            cmbseccion.Name = "cmbseccion";
            cmbseccion.Size = new Size(314, 38);
            cmbseccion.TabIndex = 21;
            // 
            // cmbmateria
            // 
            cmbmateria.BackColor = Color.FromArgb(13, 13, 13);
            cmbmateria.Cursor = Cursors.Hand;
            cmbmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmateria.ForeColor = SystemColors.Menu;
            cmbmateria.FormattingEnabled = true;
            cmbmateria.Location = new Point(81, 150);
            cmbmateria.Name = "cmbmateria";
            cmbmateria.Size = new Size(314, 38);
            cmbmateria.TabIndex = 20;
            // 
            // cmbtipopersona
            // 
            cmbtipopersona.BackColor = Color.FromArgb(13, 13, 13);
            cmbtipopersona.Cursor = Cursors.Hand;
            cmbtipopersona.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbtipopersona.ForeColor = SystemColors.Menu;
            cmbtipopersona.FormattingEnabled = true;
            cmbtipopersona.Location = new Point(81, 344);
            cmbtipopersona.Name = "cmbtipopersona";
            cmbtipopersona.Size = new Size(314, 38);
            cmbtipopersona.TabIndex = 19;
            // 
            // labelsec
            // 
            labelsec.AutoSize = true;
            labelsec.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsec.ForeColor = Color.White;
            labelsec.Location = new Point(91, 208);
            labelsec.Name = "labelsec";
            labelsec.Size = new Size(92, 30);
            labelsec.TabIndex = 16;
            labelsec.Text = "Sección:";
            // 
            // labelmateria
            // 
            labelmateria.AutoSize = true;
            labelmateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelmateria.ForeColor = Color.White;
            labelmateria.Location = new Point(91, 117);
            labelmateria.Name = "labelmateria";
            labelmateria.Size = new Size(92, 30);
            labelmateria.TabIndex = 15;
            labelmateria.Text = "Materia:";
            // 
            // aceptar
            // 
            aceptar.Cursor = Cursors.Hand;
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(148, 434);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(190, 48);
            aceptar.TabIndex = 4;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            // 
            // labeltipopersona
            // 
            labeltipopersona.AutoSize = true;
            labeltipopersona.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltipopersona.ForeColor = Color.White;
            labeltipopersona.Location = new Point(91, 311);
            labeltipopersona.Name = "labeltipopersona";
            labeltipopersona.Size = new Size(143, 30);
            labeltipopersona.TabIndex = 10;
            labeltipopersona.Text = "Tipo Persona:";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(179, 51);
            title.Name = "title";
            title.Size = new Size(115, 36);
            title.TabIndex = 3;
            title.Text = "FILTROS";
            // 
            // FormFiltroPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 555);
            Controls.Add(panel);
            ForeColor = SystemColors.ControlLight;
            Name = "FormFiltroPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro Persona";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button aceptar;
        private Label labeltipopersona;
        private Label title;
        private Label labelsec;
        private Label labelmateria;
        private ComboBox cmbtipopersona;
        private ComboBox cmbseccion;
        private ComboBox cmbmateria;
    }
}