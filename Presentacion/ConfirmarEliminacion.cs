using System;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion
{
    public partial class ConfirmarEliminacion : Form
    {
        public bool Confirmado { get; private set; } = false;
        public ConfirmarEliminacion()
        {
            InitializeComponent();
            btnSi.Click += (s, e) => { Confirmado = true; this.DialogResult = DialogResult.OK; this.Close(); };
            btnNo.Click += (s, e) => { Confirmado = false; this.DialogResult = DialogResult.Cancel; this.Close(); };
        }
    }
}
