using System;
using HexagonalTorneo.Persona.domain;
namespace HexagonalTorneo.Medic.domain
{
    public class MedicBody : Person
    {
        public string? Position { get; set; }
        public MedicBody(string name, string lastname, int age, string documentNumber,string documentType, string countryOfOrigin, string position) : base(name, lastname, age, documentNumber, documentType, countryOfOrigin)
        {
            Position = position;
        }
    }
}