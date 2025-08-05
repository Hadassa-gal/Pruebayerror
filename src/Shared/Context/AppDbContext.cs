using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalTorneo.Persona.domain;
using HexagonalTorneo.Players.domain;
using Microsoft.EntityFrameworkCore;

namespace Liga_Futbol.src.Shared.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {}
        public DbSet<Player> Player { get; set; }
    }
}