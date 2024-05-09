using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calcolatrice
    {
        public static float Somma(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Differenza(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Divisione(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Non puoi dividere un numero per zero");
            }
            return num1 / num2;
        }

        public static float Prodotto(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}

