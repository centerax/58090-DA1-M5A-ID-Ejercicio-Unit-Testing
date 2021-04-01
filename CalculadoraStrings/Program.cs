using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CalculadoraStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var unaCalculadora = new Calculadora();

            int sumaVacia = unaCalculadora.Sumar("");
            int sumaTresNros = unaCalculadora.Sumar("3,4,6"); //13
            int sumaTresNrosChicos = unaCalculadora.Sumar("1,3,2"); //6
            int sumaCero = unaCalculadora.Sumar("0,0");
            int sumaImpares = unaCalculadora.Sumar("7,5,3"); //15

            int[] ultimasTresSumas = unaCalculadora.UltimasTresSumas();
            
            foreach (int suma in ultimasTresSumas)
            {
                Console.WriteLine(suma);
            }

            Console.ReadKey();
        }
    }
}
