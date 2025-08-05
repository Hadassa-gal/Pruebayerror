using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ui;
using MySqlConnector;
namespace Helpers
{
    public class Validacion
    {
        public static byte ValiByte()
        {
            byte op = 0;
            if (!byte.TryParse(Console.ReadLine(), out op))
            {
                Acceptordeny.MostrarError("El valor ingresado debe ser un numero valido");
            }
            return op;
        }
    }
    public class MySqlVersionResolver
{
    public static Version DetectVersion(string connectionString)
    {
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        var raw = conn.ServerVersion;
        var clean = raw.Split('-')[0];
        return Version.Parse(clean);
    }
}
    
}