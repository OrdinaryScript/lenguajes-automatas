using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Pregunta inicial
        Console.WriteLine("Tipea tu cadena de texto/url/correo válido.");
        // Capturando la cadena tipeada
        string cadena = Console.ReadLine();
        
        // Condiciones para la validacion de cadenas
        if (IsEmail(cadena))
        {
            Console.WriteLine("Es una dirección de correo electrónico");
        }
        else if (IsURL(cadena))
        {
            Console.WriteLine("Es una URL");
        }
        else if (IsText(cadena))
        {
            Console.WriteLine("Es una cadena de texto.");
        }
        else
        {
            Console.WriteLine("No es ni una dirección de correo, ni una URL, ni texto.");
        }
    }

    // Lectura de la funcion para detectar el correo electronico
    static bool IsEmail(string cadena)
    {
        string patronCorreo = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        return Regex.IsMatch(cadena, patronCorreo);
    }
    // Lectura de la funcion para detectar una URL
    static bool IsURL(string cadena)
    {
        string patronURL = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
        return Regex.IsMatch(cadena, patronURL);
    }
    // Lectura de la funcion para detectar cadena de texto
    static bool IsText(string cadena)
    {
        return !string.IsNullOrWhiteSpace(cadena) && cadena.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c));
    }
}