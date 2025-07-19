using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;
using System.Diagnostics;

namespace Sistema_Academia.Datos
{
    public class Conexion : IDisposable
    {
        private readonly string _connectionString;
        private NpgsqlConnection _connection;

        public Conexion()
        {
            try
            { 
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("settings.json")
                    .Build();

                _connectionString = config["Default"];

                if (string.IsNullOrEmpty(_connectionString))
                    throw new InvalidOperationException("Cadena de conexión no configurada");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al configurar la conexión", ex);
            }
        }

        public NpgsqlConnection ObtenerConexion()
        {
            if (_connection == null)
            {
                _connection = new NpgsqlConnection(_connectionString);
            }

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }

        public void Dispose()
        {
            CerrarConexion();
        }

        public void CerrarConexion()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}