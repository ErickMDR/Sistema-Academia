using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.IO;

namespace Sistema_Academia.Datos
{
    public class TablaCurso : TablaBase<TablaCurso>
    {
        protected override string NombreTabla => "Curso";

        private readonly IConfigurationRoot _config;

        public TablaCurso() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }

        // Listado completo usando la view vw_cursos
        public DataTable Listado()
        {
            var dt = new DataTable();
            var query = _config["Curso:Leer"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // Búsqueda por cédula de profesor
        public DataTable BuscarCursosPorCedulaProfesor(int cedulaProfesor)
        {
            var dt = new DataTable();
            var query = _config["Curso:Buscar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@cedulaProfesor", cedulaProfesor);
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public int Insertar(Curso nuevoCurso)
        {
            var query = _config["Curso:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@personaId", nuevoCurso.ProfesorId);
            cmd.Parameters.AddWithValue("@materiaId", nuevoCurso.MateriaId);
            cmd.Parameters.AddWithValue("@seccionId", nuevoCurso.SeccionId);
            return cmd.ExecuteNonQuery();
        }

        public void Actualizar(Curso curso)
        {
            var query = _config["Curso:Actualizar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@personaId", curso.ProfesorId);
            cmd.Parameters.AddWithValue("@materiaId", curso.MateriaId);
            cmd.Parameters.AddWithValue("@seccionId", curso.SeccionId);
            cmd.Parameters.AddWithValue("@cursoId", curso.Id);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            var query = _config["Curso:Eliminar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@cursoId", id);
            cmd.ExecuteNonQuery();
        }

        // Obtenemos el curso_id dado materia y sección
        public int ObtenerCursoId(int materiaId, int seccionId)
        {
            var query = _config["Curso:BuscarPorMateriaSeccion"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@materiaId", materiaId);
            cmd.Parameters.AddWithValue("@seccionId", seccionId);
            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToInt32(result);
        }
    }
}