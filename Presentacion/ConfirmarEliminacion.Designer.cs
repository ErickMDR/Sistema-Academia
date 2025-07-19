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
            btnNo.FlatAppearance.BorderColor = Color.White;
            btnNo.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold);
            btnNo.ForeColor = Color.Snow;
            btnNo.Location = new Point(271, 183);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(105, 54);
            btnNo.TabIndex = 33;
            btnNo.Text = "No";
            btnNo.UseMnemonic = false;
            btnNo.UseVisualStyleBackColor = false;
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.FromArgb(13, 13, 13);
            btnSi.FlatAppearance.BorderColor = Color.White;
            btnSi.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold);
            btnSi.ForeColor = Color.Snow;
            btnSi.Location = new Point(92, 183);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(104, 54);
            btnSi.TabIndex = 32;
            btnSi.Text = "Si";
            btnSi.UseMnemonic = false;
            btnSi.UseVisualStyleBackColor = false;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMensaje.ForeColor = SystemColors.Control;
            labelMensaje.Location = new Point(47, 107);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(386, 30);
            labelMensaje.TabIndex = 31;
            labelMensaje.Text = "¿Está seguro de que desea eliminar?";
            // 
            // ConfirmarEliminacion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 355);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(labelMensaje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmarEliminacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmar Eliminación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNo;
        private Button btnSi;
        private Label labelMensaje;
    }
}
