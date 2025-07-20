using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Sistema_Academia.Datos
{
    public class TablaSeccion : TablaBase<TablaSeccion>
    {
        protected override string NombreTabla => "Seccion";
        private readonly IConfigurationRoot _config;

        public TablaSeccion() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }

        public void Insertar(Seccion seccion)
        {
            var query = _config["Seccion:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", seccion.Descripcion);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(Seccion seccion)
        {
            var query = _config["Seccion:Actualizar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", seccion.Descripcion);
            cmd.Parameters.AddWithValue("@seccionId", seccion.Id);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            var query = _config["Seccion:Eliminar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@seccionId", id);
            cmd.ExecuteNonQuery();
        }

        public List<Seccion> BuscarPorDescripcion(string descripcionSeccion)
        {
            var secciones = new List<Seccion>();
            var query = _config["Seccion:Buscar"];

            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", $"%{descripcionSeccion}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                secciones.Add(new Seccion
                {
                    Id = reader.GetInt32(reader.GetOrdinal("seccion_id")),
                    Descripcion = reader.GetString(reader.GetOrdinal("seccion_de"))
                });
            }

            return secciones;
        }

        public DataTable ObtenerSeccionesPorMateria(int materiaId)
        {
            var query = _config["Seccion:ObtenerSeccionesPorMateria"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@materiaId", materiaId);
            var adapter = new NpgsqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}