using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlmostfinalForm.src.modules.Players.application;
using AlmostfinalForm.src.modules.Shared.ports;
using HexagonalTorneo.Players.domain;
using AlmostfinalForm.mysql;
using MySqlConnector;
namespace AlmostfinalForm.src.modules.Players.interfaces
{
    public class PlayerRepository : IGenericRepository<Player>, IPlayerRepository
    {
        private readonly ConnectionSingleton _conexion;
        public PlayerRepository(string connectionString)
        {
            _conexion = ConnectionSingleton.Instancia(connectionString);
        }
        public void Actualizar(Player entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(Player Jugador)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO Jugadores(name) VALUES (@Name)";
            using var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", Jugador.Name);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Player> ObtenerTodosPlayers()
        {
            throw new NotImplementedException();
        }
    }
}