using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            int numero = random.Next(1, 100);
            Jugar(numero);

        }
        private static void Jugar(int numero)
        {
            int intentos = 0;
            int numeroUsuario = 0;
            do
            {
                Console.Write("Introduce un número: ");
                numeroUsuario = int.Parse(Console.ReadLine());
                intentos++;
                if (numeroUsuario > numero)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (numeroUsuario < numero)
                {
                    Console.WriteLine("El número es mayor");
                }
            } while (numeroUsuario != numero);
            Console.WriteLine($"¡Has acertado en {intentos} intentos!");
        }
    }
}
