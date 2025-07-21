using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.IO;
using System.Text;

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

        public DataTable Filtrar(string materia = null, string seccion = null)
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

            try
            {
                var queryBase = _config["Curso:FiltroCombinado"];
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
                throw new Exception("Error al filtrar cursos", ex);
            }

            return dt;
        }
    }
}