using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string patronCorreo = @"^([\w\.-]+)@(gmail\.com|hotmail\.com)$";

        while (true)
        {
            Console.WriteLine("Escribe una dirección de correo (Gmail o Hotmail): ");
            string correo = Console.ReadLine();

            if (Regex.IsMatch(correo, patronCorreo))
            {
                Console.WriteLine("Correo válido.");
            }
            else
            {
                Console.WriteLine("Correo inválido. ¿Deseas ingresar otro correo? (S/N)");
                string respuesta = Console.ReadLine();

                if (respuesta.Trim().Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Salir del bucle si el usuario no desea ingresar otro correo
                }
            }
        }

        string patronCURP = @"^([A-Z]{4})([0-9]{6})([H|M])([A-Z]{2})([A-Z]{4})([0-9]{1})";

        while (true)
        {
            Console.WriteLine("Escribe una CURP: ");
            string CURP = Console.ReadLine();

            if (Regex.IsMatch(CURP, patronCURP))
            {
                Console.WriteLine("CURP válida.");
            }
            else
            {
                Console.WriteLine("CURP inválida. ¿Deseas ingresar otra CURP? (S/N)");
                string respuesta = Console.ReadLine();

                if (respuesta.Trim().Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Salir del bucle si el usuario no desea ingresar otra CURP
                }
            }
        }
    }
}
