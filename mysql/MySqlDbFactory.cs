using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlmostfinalForm.factory;
using AlmostfinalForm.src.modules.Players.application;
using AlmostfinalForm.src.modules.Players.interfaces;

namespace AlmostfinalForm.mysql
{
    public class MySqlDbFactory : IDbFactory
    {
        private readonly string _connectionString;

        public MySqlDbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IPlayerRepository CrearPlayerRepository()
        {
            return new PlayerRepository(_connectionString);
        }
    }
}