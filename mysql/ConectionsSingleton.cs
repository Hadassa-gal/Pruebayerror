using MySqlConnector;

namespace AlmostfinalForm.mysql
{
    public class ConnectionSingleton  // Nombre corregido (Connection con "ct")
    {
        private static ConnectionSingleton? _instancia;
        private readonly string _connectionString;
        private MySqlConnection? _conexion;

        private ConnectionSingleton(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static ConnectionSingleton Instancia(string connectionString)
        {
            _instancia ??= new ConnectionSingleton(connectionString);
            return _instancia;
        }

        public MySqlConnection ObtenerConexion()
        {
            _conexion ??= new MySqlConnection(_connectionString);

            if (_conexion.State != System.Data.ConnectionState.Open)
                _conexion.Open();

            return _conexion;
        }
    }
}