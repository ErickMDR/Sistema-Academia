using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.IO;

namespace Sistema_Academia.Datos
{
    public class TablaInscripcion : TablaBase<TablaInscripcion>, IDisposable
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
            var query = _config["Inscripcion:Inscribir"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@personaId", inscripcion.PersonaId);
            cmd.Parameters.AddWithValue("@cursoId", inscripcion.CursoId);
            cmd.ExecuteNonQuery();
        }

        public void InsertarCompleto(Inscripcion inscripcion)
        {
            using var m = new ManejadorConexion(new Conexion());

            var personaId = ObtenerPersonaId(inscripcion.Cedula, m.ConexionAbierta);
            var cursoId = ObtenerCursoId(inscripcion.Materia, inscripcion.Seccion, m.ConexionAbierta);

            if (personaId == 0)
            {
                throw new Exception($"No se encontró a la persona de cédula {inscripcion.Cedula}");
            }

            if (cursoId <= 0)
            {
                throw new Exception($"No se encontró un curso válido para {inscripcion.Materia} - {inscripcion.Seccion}");
            }

            var query = _config["Inscripcion:Inscribir"];
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@personaId", personaId);
            cmd.Parameters.AddWithValue("@cursoId", cursoId);
            cmd.ExecuteNonQuery();
        }

        private int ObtenerPersonaId(string cedula, NpgsqlConnection conexion)
        {
            var query = _config["Inscripcion:ObtenerPersona"];
            using var cmd = new NpgsqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@cedula", Convert.ToInt32(cedula));
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }

        private int ObtenerCursoId(string materia, string seccion, NpgsqlConnection conexion)
        {
            var query = _config["Inscripcion:ObtenerCurso"];
            using var cmd = new NpgsqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@materia", materia);
            cmd.Parameters.AddWithValue("@seccion", seccion);
            var result = cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                throw new Exception($"No se encontró un curso para la materia '{materia}' y sección '{seccion}'");
            }

            return Convert.ToInt32(result);
        }
    }
}