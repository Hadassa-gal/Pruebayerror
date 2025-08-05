using System;
using HexagonalTorneo.Persona.domain;
namespace HexagonalTorneo.Tecnic.domain
{
    public class TecnicBody : Person
    {
        public string? Position { get; set; }
        public TecnicBody(string name, string lastname, int age, string documentNumber,string documentType, string countryOfOrigin, string position) : base(name, lastname, age, documentNumber, documentType, countryOfOrigin)
        {
            Position = position;
        }
    }
}