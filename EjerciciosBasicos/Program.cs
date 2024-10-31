using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ej1(49);
            ej2(20);
            ej3(100);
            ej4(50000);
            Console.ReadKey();
        }
        public static void ej1(int mark)
        {
            if (mark >= 50)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

        }
        public static void ej2(int numero)
        {
            if ((numero % 2) != 0)
            {
                Console.WriteLine("Número Impar");
            }
            else
            {
                Console.WriteLine("Número Par");

            }
        }
        public static void ej3(int cota)
        {
            int result = 0;
            double media = 0;
            int iWhile = 0;
            int iDoWhile = 0;
            int div = 7;// int div = 2;
            int cuadrado = 0;
            /*for (int i = 1; i <= cota; i++)
            {
                result = result + i;
            }*/
            /* while (iWhile <= cota)
             {
                 result = result + iWhile;
                 iWhile++;
             }*/
            do
            {
                /*if((iDoWhile % div) == 0)
                {
                    result = result + iDoWhile;
                }
                iDoWhile++;*/
                cuadrado = iDoWhile * iDoWhile;
                result = result + cuadrado;
                iDoWhile++;

            }
            while (iDoWhile <= cota);


            media = (double) result / cota;
            Console.WriteLine("La suma es " + result);
            Console.WriteLine("La media es " + media);
        }
        public static void ej4(int n)
        {
            Double result1 = 0.0;
            Double result2 = 0.0;
            Double diferencia = 0.0;
            for (int i = 1; i<= n; i++)
            {
                result1 = result1 + (double)(1.0 / i);
            }
            for (int i = n; i > 0; i--)
            {
                result2 = result2 + (double)(1.0 / i);
            }
            Console.WriteLine("El resultado de izquierda a derecha es "+result1);
            Console.WriteLine("El resultado de derecha a izquierda es " + result2);
            diferencia = (result1 - result2);
            Console.WriteLine("La diferencias es " + diferencia);
            if (result1 > result2)
            {
                Console.WriteLine("De izquierda a derecha es mas preciso");
            }
            else
            {
                Console.WriteLine("De derecha a izquierda es mas preciso");
            }

        }
        public static void ej5(int nTerminos)
        {
            Double result = 0.0;
            for (int i = 1; i <= nTerminos; i++)
            {
            }
        }

    }
    
}
