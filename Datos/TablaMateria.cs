using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;

namespace Sistema_Academia.Datos
{
    public class TablaMateria : TablaBase<TablaMateria>
    {
        protected override string NombreTabla => "Materia";
        private readonly IConfigurationRoot _config;

        public TablaMateria() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }

        public void Insertar(Materia materia)
        {
            var query = _config["Materia:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", materia.Nombre);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(Materia materia)
        {
            var query = _config["Materia:Actualizar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", materia.Nombre);
            cmd.Parameters.AddWithValue("@materiaId", materia.Id);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            var query = _config["Materia:Eliminar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@materiaId", id);
            cmd.ExecuteNonQuery();
        }

        public List<Materia> BuscarPorNombre(string nombreMateria)
        {
            var materias = new List<Materia>();
            var query = _config["Materia:Buscar"];

            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", $"%{nombreMateria}%");

            using var lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                materias.Add(new Materia
                {
                    Id = lector.GetInt32(lector.GetOrdinal("materia_id")),
                    Nombre = lector.GetString(lector.GetOrdinal("materia_de"))
                });
            }

            return materias;
        }
    }
}