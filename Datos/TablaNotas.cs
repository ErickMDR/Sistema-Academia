using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Entidades;
using System;
using System.Data;
using System.IO;

namespace Sistema_Academia.Datos
{
    public class TablaNotas : TablaBase<TablaNotas>
    {
        protected override string NombreTabla => "Notas";
        private readonly IConfigurationRoot _config;

        public TablaNotas() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }

        public void Insertar(Nota notas)
        {
            var query = _config["Notas:Asignar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@nota", notas.Calificacion);
            cmd.Parameters.AddWithValue("@inscripcionId", notas.InscripcionId);
            cmd.ExecuteNonQuery();
        }
    }
}
