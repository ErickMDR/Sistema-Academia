namespace Sistema_Academia.Presentacion.Agregar
{
    partial class FormAgregarPersona
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
            comboBox = new ComboBox();
            aceptar = new Button();
            txtcedula = new TextBox();
            labelci = new Label();
            labeltipopersona = new Label();
            title = new Label();
            txtapellido = new TextBox();
            labelna = new Label();
            labelap = new Label();
            txtnombre = new TextBox();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(13, 13, 13);
            panel.Controls.Add(comboBox);
            panel.Controls.Add(aceptar);
            panel.Controls.Add(txtcedula);
            panel.Controls.Add(labelci);
            panel.Controls.Add(labeltipopersona);
            panel.Controls.Add(title);
            panel.Controls.Add(txtapellido);
            panel.Controls.Add(labelna);
            panel.Controls.Add(labelap);
            panel.Controls.Add(txtnombre);
            panel.Location = new Point(1, 0);
            panel.Name = "panel";
            panel.Size = new Size(482, 558);
            panel.TabIndex = 15;
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.FromArgb(13, 13, 13);
            comboBox.Cursor = Cursors.Hand;
            comboBox.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox.ForeColor = SystemColors.Menu;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(83, 382);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(314, 38);
            comboBox.TabIndex = 20;
            // 
            // aceptar
            // 
            aceptar.Cursor = Cursors.Hand;
            aceptar.FlatAppearance.BorderColor = Color.White;
            aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.ForeColor = Color.Snow;
            aceptar.Location = new Point(149, 463);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(190, 48);
            aceptar.TabIndex = 4;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click_1;
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
            // labeltipopersona
            // 
            labeltipopersona.AutoSize = true;
            labeltipopersona.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltipopersona.ForeColor = Color.White;
            labeltipopersona.Location = new Point(93, 349);
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
            title.Location = new Point(119, 31);
            title.Name = "title";
            title.Size = new Size(236, 36);
            title.TabIndex = 3;
            title.Text = "AGREGAR/EDITAR";
            // 
            // txtapellido
            // 
            txtapellido.BackColor = Color.FromArgb(13, 13, 13);
            txtapellido.Cursor = Cursors.IBeam;
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
            txtnombre.Cursor = Cursors.IBeam;
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
            // FormAgregarPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 555);
            Controls.Add(panel);
            Name = "FormAgregarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persona";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button aceptar;
        private TextBox txtcedula;
        private Label labelci;
        private Label labeltipopersona;
        private Label title;
        private TextBox txtapellido;
        private Label labelna;
        private Label labelap;
        private TextBox txtnombre;
        private ComboBox comboBox;
    }
}