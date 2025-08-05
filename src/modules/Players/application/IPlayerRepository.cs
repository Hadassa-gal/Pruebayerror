using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlmostfinalForm.src.modules.Shared.ports;
using HexagonalTorneo.Players.domain;
namespace AlmostfinalForm.src.modules.Players.application
{
    public interface IPlayerRepository : IGenericRepository<Player>
    {
        List<Player> ObtenerTodosPlayers();
    }
}