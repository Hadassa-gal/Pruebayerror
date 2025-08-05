using System;

namespace HexagonalTorneo.Persona.domain
{
    public class Person
    {
        // Las propiedades se mantienen igual
        public int Id { get; set; } // BUENA PRÁCTICA: Añadir un ID para la base de datos
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentType { get; set; }
        public string? CountryOfOrigin { get; set; }

        // SOLUCIÓN: Añadir un constructor vacío.
        // Entity Framework y los inicializadores de objetos lo necesitan.
        public Person() { }

        // El constructor con parámetros se puede mantener si lo necesitas en otra parte.
        public Person(string? name, string? lastname, int age, string? documentNumber, string? documentType, string? countryOfOrigin)
        {
            Name = name;
            LastName = lastname;
            Age = age;
            DocumentNumber = documentNumber;
            DocumentType = documentType;
            CountryOfOrigin = countryOfOrigin;
        }
    }
}