using System;
using HexagonalTorneo.Persona.domain;
namespace HexagonalTorneo.Players.domain
{
    public class Player : Person
    {
        public int Dorsal { get; set; }
        public string Position { get; set; }
        public Player(string name, string lastname, int age, string documentNumber, string documentType, string countryOfOrigin, int dorsal, string position) : base(name, lastname, age, documentNumber, documentType, countryOfOrigin)
        {
            Dorsal = dorsal;
            Position = position;
        }
    }
}