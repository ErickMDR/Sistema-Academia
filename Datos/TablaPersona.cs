using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.IO;

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
    }
}