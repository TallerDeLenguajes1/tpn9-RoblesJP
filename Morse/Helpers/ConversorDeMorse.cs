using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public static class ConversorDeMorse
    {
        readonly static Dictionary<char, string> dic = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {' ', "/" }
        };

        public static string TextoAMorse(String texto)
        {
            texto = texto.ToLower();
            string morse = "";

            foreach(char caracter in texto.ToCharArray())
            {
                morse += dic[caracter] + " ";
            }

            return morse;
        }

        public static string MorseATexto(String morse)
        {
            string texto = "";

            foreach (string codigo in morse.Split(" "))
            {
                foreach (KeyValuePair<char, string> res in dic)
                {
                    if (res.Value == codigo)
                    {
                        texto += res.Key;
                    }
                }
            }
            return texto;
        }

        
    }
}
