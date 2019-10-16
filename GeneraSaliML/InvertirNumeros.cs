using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GeneraSaliML
{
    static public class InvertirNumeros
    {
        static public List<string> invierte(string numero)
        {
            Regex rx = new Regex(@"[a-zA-ZÁÉÍÓÚáéíóú]+ ", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(numero);
            List<string> ListaInvertida = new List<string>();
            foreach (Match match in matches)
            {
                ListaInvertida.Add(match.Value);
            }
            ListaInvertida.Reverse();
            return (ListaInvertida);
        }
    }
}
