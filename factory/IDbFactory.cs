using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlmostfinalForm.src.modules.Players.application;

namespace AlmostfinalForm.factory
{
    public interface IDbFactory
    {
        IPlayerRepository CrearPlayerRepository();
    }
}