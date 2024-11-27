using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDivisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] result = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in numbers)
            {
                int count = 0;
                try
                {
                    result[count] = Division(item, item + 1);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by zero not allowed");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Out of Array bounds");
                }
                count++;
            }

        }
        public static int Division(int num,int div)
        {
            int result = num / div;
            return result;
        }
    }
}
