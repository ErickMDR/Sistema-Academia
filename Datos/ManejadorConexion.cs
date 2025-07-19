using Npgsql;
using System;
using System.Data;

namespace Sistema_Academia.Datos
{
    public class ManejadorConexion : IDisposable
    {
        private readonly Conexion _conexionFactory;
        private NpgsqlConnection _connection;

        public ManejadorConexion(Conexion conexionFactory)
        {
            _conexionFactory = conexionFactory ?? throw new ArgumentNullException(nameof(conexionFactory));
        }

        public NpgsqlConnection ConexionAbierta
        {
            get
            {
                if (_connection == null)
                    _connection = _conexionFactory.ObtenerConexion();

                if (_connection.State != ConnectionState.Open)
                    _connection.Open();

                return _connection;
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();

                _connection.Dispose();
                _connection = null;
            }
        }
    }
}