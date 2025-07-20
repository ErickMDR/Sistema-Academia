using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Sistema_Academia.Datos
{
    public class TablaPersona : TablaBase<TablaPersona>
    {
        protected override string NombreTabla => "Persona";
        private readonly IConfigurationRoot _config;

        public TablaPersona() : base()
        {
            _config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("queries.json")
              .Build();
        }

        public int Insertar(Persona p)
        {
            var q = _config["Persona:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@ci", p.Cedula);
            cmd.Parameters.AddWithValue("@tipoPersona", ConvertirTipoPersonaANumero(p.TipoPersona));
            return cmd.ExecuteNonQuery();
        }

        public void Actualizar(Persona p)
        {
            var q = _config["Persona:Actualizar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@ci", p.Cedula);
            cmd.Parameters.AddWithValue("@tipoPersona", ConvertirTipoPersonaANumero(p.TipoPersona));
            cmd.Parameters.AddWithValue("@personaId", p.Id);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(string nombre, string apellido)
        {
            var q = _config["Persona:Eliminar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.ExecuteNonQuery();
        }

        public Persona BuscarPorCedula(int ci)
        {
            var q = _config["Persona:BuscarCi"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@ci", ci);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Persona
                {
                    Id = reader.GetInt32(reader.GetOrdinal("persona_id")),
                    Nombre = reader.GetString(reader.GetOrdinal("persona_no")),
                    Apellido = reader.GetString(reader.GetOrdinal("persona_ap")),
                    Cedula = reader.GetInt32(reader.GetOrdinal("persona_ci")),
                    TipoPersona = ObtenerDescripcionTipoPersona(reader.GetInt32(reader.GetOrdinal("tipo_persona_id")))
                };
            }
            return null;
        }

        private int ConvertirTipoPersonaANumero(string tipo) =>
            tipo.ToLower() == "profesor" ? 1 : 2;

        private string ObtenerDescripcionTipoPersona(int id) =>
            id == 1 ? "Profesor" : "Estudiante";

        public DataTable Filtrar(string materia = null, string seccion = null, string tipoPersona = null)
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

            if (!string.IsNullOrEmpty(tipoPersona))
            {
                condiciones.Append(" AND tp.tipo_persona_de ILIKE @tipoPersona");
                parametros.Add(new NpgsqlParameter("@tipoPersona", $"%{tipoPersona}%"));
            }

            try
            {
                var queryBase = _config["Persona:FiltroCombinado"];
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
                throw new Exception("Error al filtrar personas", ex);
            }

            return dt;
        }

        public DataTable ObtenerMaterias()
        {
            return EjecutarConsulta(_config["Persona:ObtenerMaterias"]);
        }

        public DataTable ObtenerSecciones()
        {
            return EjecutarConsulta(_config["Persona:ObtenerSecciones"]);
        }

        public DataTable ObtenerTiposPersona()
        {
            return EjecutarConsulta(_config["Persona:ObtenerTiposPersona"]);
        }

        private DataTable EjecutarConsulta(string query)
        {
            var dt = new DataTable();
            using (var manejador = new ManejadorConexion(new Conexion()))
            using (var cmd = new NpgsqlCommand(query, manejador.ConexionAbierta))
            using (var lector = cmd.ExecuteReader())
            {
                dt.Load(lector);
            }
            return dt;
        }
    }
}