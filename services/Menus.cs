using System;
using Ui;
using Helpers;
using Liga_Futbol.src.Shared.Helpers;
using HexagonalTorneo.Persona.domain;
using HexagonalTorneo.Players.domain;
using Microsoft.VisualBasic;
using AlmostfinalForm.src.modules.Players.interfaces;
using System.Security.Cryptography.X509Certificates;

namespace TorneoManager
{
    public class SerPrincipal
    {
        public static void MenuPrincipal()
        {
            byte op = 0;
            do
            {
                Console.Clear();
                Menus.MostrarMenuPrincipal(); // Mostrar menú antes de pedir opción
                op = Validacion.ValiByte();
                switch (op)
                {
                    case 1:
                        MenuTorneo();
                        break;
                    case 2:
                        MenuEquipos();
                        break;
                    case 3:
                        MenuJugadores();
                        break;
                    case 4:
                        // Lógica para transferencias
                        break;
                    case 5:
                        // Lógica para estadísticas
                        break;
                    case 6:
                        Animaciones.MostrarAnimacionCarga("Saliendo del sistema");
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }
        private static void MenuTorneo()
        {
            byte op = 0;
            do
            {
                Console.Clear();
                Menus.MostrarMenuTorneo(); // Nombre correcto del método
                op = Validacion.ValiByte();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Add torneo");
                        // Lógica para crear torneo
                        break;
                    case 2:
                        Console.WriteLine("Buscar torneo");
                        // Lógica para buscar torneo
                        break;
                    case 3:
                        Console.WriteLine("eliminar torneo");
                        // Lógica para eliminar torneo
                        break;
                    case 4:
                        Console.WriteLine("actualizar torneo");
                        // Lógica para actualizar torneo
                        break;
                    case 5:
                        Animaciones.MostrarAnimacionCarga("Volviendo a menu principal");
                        break;
                    default:
                        break;
                }
            } while (op != 5);
        }
        private static void MenuEquipos()
        {
            byte op = 0;
            do
            {
                Console.Clear();
                Menus.MostrarMenuEquipos();
                op = Validacion.ValiByte();
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        // Lógica para buscar torneo
                        break;
                    case 3:
                        // Lógica para eliminar torneo
                        break;
                    case 4:
                        // Lógica para actualizar torneo
                        break;
                    case 5:
                        // Lógica para actualizar torneo
                        break;
                    case 6:
                        // Lógica para actualizar torneo
                        break;
                    case 7:
                        Animaciones.MostrarAnimacionCarga("Volviendo a menu principal");
                        break;
                    default:
                        break;
                }
            } while (op != 7);
        }
        private static void MenuJugadores()
        {
            byte op = 0;
            do
            {
                Console.Clear();
                Menus.MostrarMenuJugadores();
                op = Validacion.ValiByte();
                switch (op)
                {
                    case 1:
                        var context = DbContextFactory.Create();
                        var personas = new Player("Neymar", "Jr", 32, "1234567890", "CC", "Brasil", 1, "delantero");
                        //PlayerRepository.Crear(personas);
                        context.Player.Add(personas);
                        context.SaveChanges();
                        foreach (var persona in context.Player)
                        {
                            Console.WriteLine($"Nombre {persona.Name} {persona.LastName}, Edad: {persona.Age}, Document: {persona.DocumentType}.{persona.DocumentNumber}");
                        }
                        break;
                    case 2:
                        // Lógica para buscar torneo
                        break;
                    case 3:
                        // Lógica para eliminar torneo
                        break;
                    case 4:
                        // Lógica para actualizar torneo
                        break;
                    case 5:
                        Animaciones.MostrarAnimacionCarga("Volviendo a menu principal");
                        break;
                    default:
                        break;
                }
            } while (op != 5);
        }
    } 
}