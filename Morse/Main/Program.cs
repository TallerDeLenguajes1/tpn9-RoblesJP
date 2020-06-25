using System;
using System.Runtime.CompilerServices;
using Helpers;
using System.IO;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string fecha = DateTime.Now.ToString("ddMMyyyy_hhmmss");

            string texto;

            string pathMorse = @"C:\Temp\morse_" + fecha + ".txt";
            string pathTexto = @"C:\Temp\texto_" + fecha + ".txt";

            Console.WriteLine(">> Ingrese un texto");
            texto = Convert.ToString(Console.ReadLine());
            File.WriteAllText(pathMorse, ConversorDeMorse.TextoAMorse(texto));
            Console.WriteLine("-- El texto traducido a codigo morse se guardo en {0}", pathMorse);


            string morse = File.ReadAllText(pathMorse);
            File.WriteAllText(pathTexto, ConversorDeMorse.MorseATexto(morse));

        }
    }
}
