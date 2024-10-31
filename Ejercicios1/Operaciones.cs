using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    internal class Operaciones
    {
        private static object _syncLock;

        /*
        *1. Usuario introduce numeros y el programa cuenta el numero de positivos
        * */
        public static void CuentaPositivos()
        {
            /*Variables locales del metodo cuentaPositivos
             */
            int positivos = 0; int conta = 0; int numero; Boolean condicion = true;
            //Bucle while, cuando se selecciona 0 sale del bucle
            while (condicion)
            {
                Console.WriteLine("Introduce numero (0 = exit): ");
                numero = Int32.Parse(Console.ReadLine());
                conta++;
                if (numero > 0) positivos++;
                if (numero == 0) condicion = false;
            }
            Console.WriteLine("Has introducido un total de {0}", conta);
            Console.WriteLine("Has introducido {0} numeros positivos ", positivos);
            Console.ReadKey();

        }
        public static int GeneraRandom(int min, int max)
        {
            Random random = new Random();
            lock (_syncLock)
            {
                int rand = random.Next(min, max + 1);
                return rand;
            }
            
        }
        public static void PresentacionListas() 
        {
            List<string> ListaColores = new List<string>();
            ListaColores.Add("Azul");
            ListaColores.Add("Rojo");
            ListaColores.Add("Verde");
            ListaColores.Add("Amarillo");
            ListaColores.Add("Morado");
            Console.WriteLine(ListaColores[1]);
            Console.ReadKey();
            ListaColores[2] = "hola";
            Console.WriteLine(ListaColores[2]);
            Console.ReadKey();
            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
            ListaColores.Insert(2, "otravez");
            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
            ListaColores.Sort();
            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
            ListaColores.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
            Console.WriteLine(ListaColores.IndexOf("Rojo"));//index
            Console.WriteLine(ListaColores.Contains("Rojo"));//boolean
            ListaColores[ListaColores.IndexOf("otravez")] = "Verde";
            ListaColores.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
        public static List<int> ListaAleatorios(int min, int max)
        {
            List<int> ListaEnterosRandom = new List<int>();
             
            for (int i = 0; i <= 100;i++)
            {
                int rand = GeneraRandom(min, max);
                ListaEnterosRandom.Add(rand);
            }
            ListaEnterosRandom.ForEach(x => Console.WriteLine(x));
            return ListaEnterosRandom;
        }
      


    }
        
}
