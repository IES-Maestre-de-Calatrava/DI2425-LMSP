using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLikeExample.Domain;

namespace RogueLikeExample
{
    internal class Program
    {
        
        private const int N = 5;
        private const int TREASURES = 10;
        private const int TRAPS = 10;
        static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            Console.WriteLine("Welcome to the RogueLikeExample game!");
            Console.WriteLine("Enter your name:");
            string characterName = Console.ReadLine();
            Character c = new Character(characterName);
            Dashboard dash = new Dashboard(N,TREASURES,TRAPS);
            dash.Initialize(c);
            while(c.Lives > 0 && c.Tresaures < TREASURES)
            {
                dash.Move(c);
            }
            if(c.Tresaures == TREASURES)
            {
                Console.WriteLine("Congratulations! You have collected all the treasures!");
            }
            else
            {
                Console.WriteLine("Game Over!");
                Console.WriteLine("You have collected " + c.Tresaures + " treasures.");
            }
            
        }
    }
}
