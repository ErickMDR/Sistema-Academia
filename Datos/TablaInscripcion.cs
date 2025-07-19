using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.IO;

namespace Sistema_Academia.Datos
{
    public class TablaInscripcion : TablaBase<TablaInscripcion>
    {
        protected override string NombreTabla => "Inscripcion";
        private readonly IConfigurationRoot _config;

        public TablaInscripcion() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }
        public void Insertar(Inscripcion inscripcion)
        {
            var query = _config["Inscripcion:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@personaId", inscripcion.PersonaId);
            cmd.Parameters.AddWithValue("@cursoId", inscripcion.CursoId);
            cmd.ExecuteNonQuery();
        }

        public void InsertarCompleto(Inscripcion inscripcion)
        {
            using var m = new ManejadorConexion(new Conexion());

            // 1. Verificar si la persona ya existe
            var personaId = ObtenerPersonaId(inscripcion.Cedula, m.ConexionAbierta);

            // 2. Si no existe, crear nueva persona
            if (personaId == 0)
            {
                personaId = InsertarPersona(inscripcion, m.ConexionAbierta);
            }

            // 3. Obtener el curso_id basado en materia y sección
            var cursoId = ObtenerCursoId(inscripcion.Materia, inscripcion.Seccion, m.ConexionAbierta);

            // 4. Crear la inscripción
            var query = _config["Inscripcion:Crear"];
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@personaId", personaId);
            cmd.Parameters.AddWithValue("@cursoId", cursoId);
            cmd.ExecuteNonQuery();
        }

        private int ObtenerPersonaId(string cedula, NpgsqlConnection conexion)
        {
            var query = _config["Inscripcion:ObtenerPersona"];
            using var cmd = new NpgsqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@cedula", cedula);
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }

        private int InsertarPersona(Inscripcion inscripcion, NpgsqlConnection conexion)
        {
            var query = _config["Inscripcion:InsertarPersona"];
            using var cmd = new NpgsqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@nombre", inscripcion.Nombre);
            cmd.Parameters.AddWithValue("@apellido", inscripcion.Apellido);
            cmd.Parameters.AddWithValue("@cedula", inscripcion.Cedula);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private int ObtenerCursoId(string materia, string seccion, NpgsqlConnection conexion)
        {
            var query = _config["Inscripcion:ObtenerCurso"];
            using var cmd = new NpgsqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@materia", materia);
            cmd.Parameters.AddWithValue("@seccion", seccion);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}