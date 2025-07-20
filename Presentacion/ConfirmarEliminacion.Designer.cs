namespace Sistema_Academia.Presentacion
{
    partial class ConfirmarEliminacion
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnNo = new Button();
            btnSi = new Button();
            labelMensaje = new Label();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(13, 13, 13);
            btnNo.Cursor = Cursors.Hand;
            btnNo.FlatAppearance.BorderColor = Color.White;
            btnNo.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold);
            btnNo.ForeColor = Color.Snow;
            btnNo.Location = new Point(271, 146);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(120, 65);
            btnNo.TabIndex = 33;
            btnNo.Text = "No";
            btnNo.UseMnemonic = false;
            btnNo.UseVisualStyleBackColor = false;
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.FromArgb(13, 13, 13);
            btnSi.Cursor = Cursors.Hand;
            btnSi.FlatAppearance.BorderColor = Color.White;
            btnSi.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold);
            btnSi.ForeColor = Color.Snow;
            btnSi.Location = new Point(83, 147);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(120, 65);
            btnSi.TabIndex = 32;
            btnSi.Text = "Si";
            btnSi.UseMnemonic = false;
            btnSi.UseVisualStyleBackColor = false;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMensaje.ForeColor = SystemColors.Control;
            labelMensaje.Location = new Point(60, 54);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(349, 40);
            labelMensaje.TabIndex = 31;
            labelMensaje.Text = "¿Confirma la operación?";
            // 
            // ConfirmarEliminacion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 275);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(labelMensaje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmarEliminacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNo;
        private Button btnSi;
        private Label labelMensaje;
    }
}
