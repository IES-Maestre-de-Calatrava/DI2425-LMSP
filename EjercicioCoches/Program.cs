using System;
using System.Collections;


namespace EjercicioCoches
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*


            //EJERCICIO 2
            Coche coche1 = new Coche(123456,"Ford", "Focus", 160000, 12542.50);

            //EJERCICIO 3
            Console.WriteLine(coche1.getId());
            Console.WriteLine(coche1.getMarca());
            Console.WriteLine(coche1.getModelo());
            Console.WriteLine(coche1.getKm());
            Console.WriteLine(coche1.getPrecio());
            //EJERCICIO 4
            coche1.setPrecio(24000);
            //EJERCICIO 5
            Console.WriteLine(coche1.ToString());
            Console.ReadKey();


            */

            //EJERCICIO 6
            ArrayList aLC = new ArrayList();
            

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("----- Vamos a crear el objeto " + (i + 1)+" --------");
                Console.WriteLine("Introduce el ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la marca: ");
                String marca = Console.ReadLine();
                Console.WriteLine("Introduce el modelo: ");
                String modelo = Console.ReadLine();
                Console.WriteLine("Introduce los km: ");
                int km = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el precio: ");
                double precio = double.Parse(Console.ReadLine());

                Coche c = new Coche(id, marca, modelo, km, precio);
                aLC.Add(c);
                Console.WriteLine("----- Hemos creado el Coche " + (i + 1) + " --------");
                Console.WriteLine("#################################################################");
            }
            //EJERCICIO 7
            foreach (Coche i in aLC)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
