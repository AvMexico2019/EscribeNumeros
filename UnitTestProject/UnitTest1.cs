using EscribeNumeros;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLong()
        {
            Trace.WriteLine("Pruebas unitarias para el tipo de datos long");

            NumerosAPalabras aPalabras = new NumerosAPalabras();
            for (int i = 0; i < ExpectedResults.Result.Length; i++)
            {
                Trace.Write(i + " " + ExpectedResults.Result[i].num + " ");
                Trace.Write(aPalabras.enLetras(ExpectedResults.Result[i].num) + " ");
                Trace.WriteLine(ExpectedResults.Result[i].EnPalabras);
                Assert.AreEqual(ExpectedResults.Result[i].EnPalabras, aPalabras.enLetras(ExpectedResults.Result[i].num));
            }
        }

        [TestMethod]
        public void TestMethodUlong()
        {
            Trace.WriteLine("Pruebas unitarias para el tipo de datos ulong");

            NumerosAPalabras aPalabras = new NumerosAPalabras();


        }

        [TestMethod]
        public void TestMethodDouble()
        {
            Trace.WriteLine("Pruebas unitarias para el tipo de datos double");

            NumerosAPalabras aPalabras = new NumerosAPalabras();


        }

        [TestMethod]
        public void TestMethodDecimal()
        {
            Trace.WriteLine("Pruebas unitarias para el tipo de datos decimal");

            NumerosAPalabras aPalabras = new NumerosAPalabras();


        }
    }
}
