using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraStrings
{
    public class Calculadora
    {
        private List<int> sumas;

        public Calculadora()
        {
            sumas = new List<int>();
        }

        public int Sumar (string numeros)
        {
            int suma = 0;

            //String vacío
            if (string.IsNullOrEmpty(numeros))
            {
                sumas.Add(0);

                return suma;
            }

            //Un número
            if (numeros.Length ==  1)
            {
                suma = int.Parse(numeros);
            }

            //Hay ',' entonces más de un número
            if(numeros.Contains(","))
            {
                string[] valores = numeros.Split(',');
                
                foreach (var valor in valores)
                {
                    int valorASumar = int.Parse(valor);

                    //Validamos que no sea negativo
                    if (valorASumar < 0)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        suma += valorASumar;
                    }
                }
            }

            sumas.Add(suma);

            return suma;
        }

        public int[] UltimasTresSumas()
        {
            sumas.Reverse();

            return sumas.Take(3).ToArray();
        }
    }
}
