using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;
using System.IO;
using System.Text;

namespace Sistema_Academia.Datos
{
    public class TablaPlanilla : TablaBase<TablaPlanilla>
    {
        protected override string NombreTabla => "Planilla";
        private readonly IConfigurationRoot _config;

        public TablaPlanilla() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }

        public DataTable Filtrar(string materia = null, string seccion = null,
                       string nombre = null, string apellido = null,
                       int? cedula = null)
        {
            var dt = new DataTable();
            var condiciones = new StringBuilder();
            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(materia))
            {
                condiciones.Append(" AND m.materia_de ILIKE @materia");
                parametros.Add(new NpgsqlParameter("@materia", $"%{materia}%"));
            }

            if (!string.IsNullOrEmpty(seccion))
            {
                condiciones.Append(" AND s.seccion_de ILIKE @seccion");
                parametros.Add(new NpgsqlParameter("@seccion", $"%{seccion}%"));
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                condiciones.Append(" AND p.persona_no ILIKE @nombre");
                parametros.Add(new NpgsqlParameter("@nombre", $"%{nombre}%"));
            }

            if (!string.IsNullOrEmpty(apellido))
            {
                condiciones.Append(" AND p.persona_ap ILIKE @apellido");
                parametros.Add(new NpgsqlParameter("@apellido", $"%{apellido}%"));
            }

            if (cedula.HasValue)
            {
                condiciones.Append(" AND p.persona_ci = @cedula");
                parametros.Add(new NpgsqlParameter("@cedula", cedula.Value));
            }

            try
            {
                var queryBase = _config["Planilla:FiltroCombinado"];
                var queryFinal = string.Format(queryBase, condiciones.ToString());

                using (var manejador = new ManejadorConexion(new Conexion()))
                using (var cmd = new NpgsqlCommand(queryFinal, manejador.ConexionAbierta))
                {
                    cmd.Parameters.AddRange(parametros.ToArray());

                    using (var lector = cmd.ExecuteReader())
                    {
                        dt.Load(lector);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar planillas", ex);
            }

            return dt;
        }
    }
}