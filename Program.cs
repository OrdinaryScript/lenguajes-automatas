using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "example@email.com";
        
        if (IsEmail(input))
        {
            Console.WriteLine("Es una dirección de correo electrónico");
        }
        else if (IsURL(input))
        {
            Console.WriteLine("Es una URL");
        }
        else if (IsText(input))
        {
            Console.WriteLine("Es una cadena de texto.");
        }
        {
            Console.WriteLine("No es ni una dirección de correo, ni una URL, ni texto.");
        }
    }

    // Lectura de la funcion para detectar el correo electronico
    static bool IsEmail(string input)
    {
        string patronCorreo = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        return Regex.IsMatch(input, patronCorreo);
    }
    // Lectura de la funcion para detectar una URL
    static bool IsURL(string input)
    {
        string patronURL = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
        return Regex.IsMatch(input, patronURL);
    }
    // Lectura de la funcion para detectar cadena de texto
    static bool IsText(string input)
    {
        return !string.IsNullOrWhiteSpace(input) && input.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c));
    }
}
