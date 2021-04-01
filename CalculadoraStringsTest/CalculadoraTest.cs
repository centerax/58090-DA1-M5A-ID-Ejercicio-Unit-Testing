using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculadoraStrings;

namespace CalculadoraStringsTest
{
    [TestClass]
    public class CalculadoraTest
    {

        /*private Calculadora calc;

        [TestInitialize]
        public void Setup()
        {
            //Este código se ejecuta antes de cada test. (opcional)
            this.calc = new Calculadora();
        }

        [TestCleanup]
        public void TearDown()
        {
            //Este código se ejecuta luego de cada test. (opcional)
            this.calc = null;
        }*/

        [TestMethod]
        public void SumarStringVacio()
        {
            Calculadora calc = new Calculadora();

            int suma = calc.Sumar("");

            Assert.AreEqual(0, suma);
        }

        [TestMethod]
        public void SumarStringSinComa()
        {
            Calculadora calc = new Calculadora();

            int suma = calc.Sumar("3");

            Assert.AreEqual(3, suma);
        }

        [TestMethod]
        public void SumarStringConComaYDosNumeros()
        {
            Calculadora calc = new Calculadora();

            int suma = calc.Sumar("4,6");

            Assert.AreEqual(10, suma);
        }

        [TestMethod]
        public void SumarStringConComaYTresNumeros()
        {
            Calculadora calc = new Calculadora();

            int suma = calc.Sumar("1,3,2");

            Assert.AreEqual(6, suma);
        }


        [DataRow("0,2,10,8,4", 24, DisplayName = "Números pares")]
        [DataRow("3,7,11,19,23", 63, DisplayName ="Algunos primos")]
        [DataRow("100,1", 101)]
        [DataTestMethod]
        public void SumarStringConComaYVariosNumeros(string numeros, int sumaEsperada)
        {
            Calculadora calc = new Calculadora();

            int suma = calc.Sumar(numeros);

            Assert.AreEqual(sumaEsperada, suma);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SumarNumeroNegativo()
        {
            Calculadora calc = new Calculadora();
            
            int suma = calc.Sumar("2,-1,3");
        }

        [TestMethod]
        public void UltimasTresSumas()
        {
            var unaCalculadora = new Calculadora();

            // Usando discard https://docs.microsoft.com/en-us/dotnet/csharp/discards
            _ = unaCalculadora.Sumar("");
            _ = unaCalculadora.Sumar("3,4,6"); //13
            _ = unaCalculadora.Sumar("1,3,2"); //6
            _ = unaCalculadora.Sumar("0,0");
            _ = unaCalculadora.Sumar("7,5,3"); //15

            var ultimasTresSumas = unaCalculadora.UltimasTresSumas();

            Assert.AreEqual(3, ultimasTresSumas.Length);

            int[] sumasEsperadas = new int[] { 15, 0, 6 };

            CollectionAssert.AreEqual(sumasEsperadas, ultimasTresSumas);
        }
    }
}
