using System;
using EscribeNumeros;

namespace GeneraSaliML
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LongRandom random = new LongRandom();
            NumerosAPalabras aPalabras = new NumerosAPalabras();
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\desa21\source\repos\EscribeNumeros\datos.csv", true))
            {
                file.WriteLine("numero", "letras");
                for (int i = 0; i < 5000; i++)
                {
                    file.WriteLine(i + "," + aPalabras.enLetras(i));
                }
                for (int i = 0; i < 5000; i++)
                {
                    int j = i + 1000000000;
                    file.WriteLine(j + "," + aPalabras.enLetras(j));
                }
                for (int i = 0; i < 5000; i++)
                {
                    long j = i + 1000000000000;
                    file.WriteLine(j + "," + aPalabras.enLetras(j));
                }
                for (int i = 0; i < 5000; i++)
                {
                    int j = i + 1000000;
                    file.WriteLine(j + "," + aPalabras.enLetras(j));
                }
                long numero = random.LRandom();
                for (int i = 0; i < 5000; i++)
                {
                    long r = random.LRandom();
                    file.WriteLine(r + "," + aPalabras.enLetras(r));
                }
            }
        }
    }
}
