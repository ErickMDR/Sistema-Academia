using Sistema_Academia.Datos;
using Sistema_Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Academia.Presentacion.Filtros
{
    public partial class FormFiltroPersona : Form
    {
        private readonly TablaPersona _tablaPersona;
        public List<Persona> PersonasFiltradas { get; private set; }

        public FormFiltroPersona()
        {
            InitializeComponent();
            _tablaPersona = new TablaPersona();
            PersonasFiltradas = new List<Persona>();
        }

        private void filtro_Click(object sender, EventArgs e)
        {
            try
            {
               // string nombre = txtnombre.Text.Trim();
                //string apellido = txtapellido.Text.Trim();
                //string cedula = txtcedula.Text.Trim();
                //string materia = txtmateria.Text.Trim();
                //string seccion = txtseccion.Text.Trim();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                List<string> condiciones = new List<string>();

                /*if (!string.IsNullOrEmpty(nombre))
                {
                    parametros.Add("@nombre", $"%{nombre}%");
                    condiciones.Add("p.persona_no LIKE @nombre");
                }

                if (!string.IsNullOrEmpty(apellido))
                {
                    parametros.Add("@apellido", $"%{apellido}%");
                    condiciones.Add("p.persona_ap LIKE @apellido");
                }

                if (!string.IsNullOrEmpty(cedula))
                {
                    parametros.Add("@ci", cedula);
                    condiciones.Add("p.persona_ci = @ci");
                }

                if (!string.IsNullOrEmpty(materia))
                {
                    parametros.Add("@materia", $"%{materia}%");
                    condiciones.Add("p.persona_id IN (SELECT DISTINCT c.persona_id FROM curso c JOIN materia m ON c.materia_id = m.materia_id WHERE m.materia_de LIKE @materia)");
                }

                if (!string.IsNullOrEmpty(seccion))
                {
                    parametros.Add("@seccion", $"%{seccion}%");
                    condiciones.Add("p.persona_id IN (SELECT DISTINCT c.persona_id FROM curso c JOIN seccion s ON c.seccion_id = s.seccion_id WHERE s.seccion_de LIKE @seccion)");
                }*/

                string whereClause = condiciones.Count > 0 ? "WHERE " + string.Join(" AND ", condiciones) : "";

                string query = $@"
                    SELECT DISTINCT p.*, 
                           CASE WHEN p.tipo_persona_id = 1 THEN 'Profesor' ELSE 'Estudiante' END AS tipo_persona
                    FROM persona p
                    LEFT JOIN tipo_persona t ON p.tipo_persona_id = t.tipo_persona_id
                    {whereClause}
                    ORDER BY p.persona_ap, p.persona_no";

                //var dt = _tablaPersona.EjecutarConsultaDinamica(query, parametros);
                //PersonasFiltradas = ConvertirDataTableALista(dt);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Persona> ConvertirDataTableALista(DataTable dt)
        {
            var lista = new List<Persona>();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Persona
                {
                    Id = Convert.ToInt32(row["persona_id"]),
                    Nombre = row["persona_no"].ToString(),
                    Apellido = row["persona_ap"].ToString(),
                    Cedula = Convert.ToInt32(row["persona_ci"]),
                    TipoPersona = row["tipo_persona"].ToString()
                });
            }
            return lista;
        }
    }
}