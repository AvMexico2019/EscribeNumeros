using System;
using System.Collections.Generic;
using System.IO;
using EscribeNumeros;

namespace GeneraSaliML
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LongRandom random = new LongRandom();
            NumerosAPalabras aPalabras = new NumerosAPalabras();
            List<string> ListaInvertida;
            const string FileName = @"C:\Users\desa21\source\repos\EscribeNumeros\datos.csv";
            int max = 0;
            int count;

            if (File.Exists(FileName)) File.Delete(FileName);
            
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(FileName, true))
            {
                file.WriteLine("numero," + "l1," + "l2," + "l3," + "l4," + "l5," + "l6," + "l7," + "l8," + "l9," + "l10," + "l11," + "l12," + "l13," + "l14," + "l15," + "l16," + "l17," + "l18," + "l19," + "l20," + "l21," + "l22," + "l23," + "l24," + "l25," + "l26," + "l27," + "l28," + "l29," + "l30," + "l31," + "l32," + "l33,");
                for (int i = 0; i < 5000; i++)
                {
                    file.Write(i + ",");
                    ListaInvertida = InvertirNumeros.invierte(aPalabras.enLetras(i));
                    if (ListaInvertida.Count > max) max = ListaInvertida.Count;
                    count = 0;
                    foreach (string pal in ListaInvertida)
                    {
                        count++;
                        file.Write(pal + ",");
                    }
                    for (int k = count; k < 33; k++)
                        file.Write(",");
                    file.WriteLine();
                    foreach (string pal in ListaInvertida) Console.Write(pal + ",");
                    Console.WriteLine();
                }
                for (int i = 0; i < 5000; i++)
                {
                    int j = i + 1000000000;
                    file.Write(j + ",");
                    ListaInvertida = InvertirNumeros.invierte(aPalabras.enLetras(j));
                    if (ListaInvertida.Count > max) max = ListaInvertida.Count;
                    count = 0;
                    foreach (string pal in ListaInvertida)
                    {
                        count++;
                        file.Write(pal + ",");
                    }
                    for (int k = count; k < 33; k++)
                        file.Write(",");
                    file.WriteLine();
                    foreach (string pal in ListaInvertida) Console.Write(pal + ",");
                    Console.WriteLine();
                }
                for (int i = 0; i < 5000; i++)
                {
                    long j = i + 1000000000000;
                    file.Write(j + ",");
                    ListaInvertida = InvertirNumeros.invierte(aPalabras.enLetras(j));
                    if (ListaInvertida.Count > max) max = ListaInvertida.Count;
                    count = 0;
                    foreach (string pal in ListaInvertida)
                    {
                        count++;
                        file.Write(pal + ",");
                    }
                    for (int k = count; k < 33; k++)
                        file.Write(",");
                    file.WriteLine();
                    foreach (string pal in ListaInvertida) Console.Write(pal + ",");
                    Console.WriteLine();
                }
                for (int i = 0; i < 5000; i++)
                {
                    int j = i + 1000000;
                    file.Write(j + ",");
                    ListaInvertida = InvertirNumeros.invierte(aPalabras.enLetras(j));
                    if (ListaInvertida.Count > max) max = ListaInvertida.Count;
                    count = 0;
                    foreach (string pal in ListaInvertida)
                    {
                        count++;
                        file.Write(pal + ",");
                    }
                    for (int k = count; k < 33; k++)
                        file.Write(",");
                    file.WriteLine();
                    foreach (string pal in ListaInvertida) Console.Write(pal + ",");
                    Console.WriteLine();
                }
                long numero = random.LRandom();
                for (int i = 0; i < 5000; i++)
                {
                    long r = random.LRandom();
                    file.Write(r + ",");
                    ListaInvertida = InvertirNumeros.invierte(aPalabras.enLetras(r));
                    if (ListaInvertida.Count > max) max = ListaInvertida.Count;
                    count = 0;
                    foreach (string pal in ListaInvertida)
                    {
                        count++;
                        file.Write(pal + ",");
                    }
                    for (int k = count; k < 33; k++)
                        file.Write(",");
                    file.WriteLine();
                    foreach (string pal in ListaInvertida) Console.Write(pal + ",");
                    Console.WriteLine();
                }
                Console.WriteLine("MAX = " + max);
                Console.ReadKey();
            }
        }
    }
}
