namespace Sistema_Academia.Presentacion
{
    partial class FormPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanilla));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelInfo = new Panel();
            picfiltro = new PictureBox();
            filtro = new Button();
            panelNotas = new Panel();
            dataGridViewTabla = new DataGridView();
            title = new Label();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picfiltro).BeginInit();
            panelNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(22, 18, 30);
            panelInfo.Controls.Add(picfiltro);
            panelInfo.Controls.Add(filtro);
            panelInfo.Controls.Add(panelNotas);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(0, -5);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1902, 850);
            panelInfo.TabIndex = 5;
            // 
            // picfiltro
            // 
            picfiltro.BackgroundImage = (Image)resources.GetObject("picfiltro.BackgroundImage");
            picfiltro.Image = Properties.Resources.Filter;
            picfiltro.Location = new Point(64, 26);
            picfiltro.Name = "picfiltro";
            picfiltro.Size = new Size(22, 22);
            picfiltro.TabIndex = 1;
            picfiltro.TabStop = false;
            // 
            // filtro
            // 
            filtro.BackColor = Color.FromArgb(22, 18, 30);
            filtro.Cursor = Cursors.Hand;
            filtro.FlatAppearance.BorderColor = Color.FromArgb(22, 18, 30);
            filtro.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            filtro.FlatStyle = FlatStyle.Flat;
            filtro.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filtro.ForeColor = Color.Snow;
            filtro.ImageAlign = ContentAlignment.MiddleLeft;
            filtro.Location = new Point(89, 17);
            filtro.Name = "filtro";
            filtro.Size = new Size(83, 40);
            filtro.TabIndex = 0;
            filtro.Text = "Filtros";
            filtro.TextAlign = ContentAlignment.MiddleRight;
            filtro.UseVisualStyleBackColor = false;
            filtro.Click += filtro_Click;
            // 
            // panelNotas
            // 
            panelNotas.BorderStyle = BorderStyle.Fixed3D;
            panelNotas.Controls.Add(dataGridViewTabla);
            panelNotas.Controls.Add(title);
            panelNotas.Location = new Point(33, 65);
            panelNotas.Name = "panelNotas";
            panelNotas.Size = new Size(1850, 770);
            panelNotas.TabIndex = 0;
            // 
            // dataGridViewTabla
            // 
            dataGridViewTabla.AllowUserToAddRows = false;
            dataGridViewTabla.AllowUserToDeleteRows = false;
            dataGridViewTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTabla.BackgroundColor = Color.FromArgb(22, 18, 30);
            dataGridViewTabla.BorderStyle = BorderStyle.None;
            dataGridViewTabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(30, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTabla.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTabla.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTabla.EnableHeadersVisualStyles = false;
            dataGridViewTabla.GridColor = Color.LightGray;
            dataGridViewTabla.Location = new Point(-2, 65);
            dataGridViewTabla.Name = "dataGridViewTabla";
            dataGridViewTabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTabla.RowHeadersWidth = 49;
            dataGridViewTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTabla.Size = new Size(1850, 706);
            dataGridViewTabla.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.Control;
            title.Location = new Point(794, 13);
            title.Name = "title";
            title.Size = new Size(301, 40);
            title.TabIndex = 2;
            title.Text = "PLANILLA DE NOTAS";
            // 
            // FormPlanilla
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 845);
            Controls.Add(panelInfo);
            Name = "FormPlanilla";
            Text = "Planilla de notas";
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picfiltro).EndInit();
            panelNotas.ResumeLayout(false);
            panelNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Button filtro;
        private Panel panelNotas;
        private DataGridView dataGridViewTabla;
        private Label title;
        private PictureBox picfiltro;
    }
}