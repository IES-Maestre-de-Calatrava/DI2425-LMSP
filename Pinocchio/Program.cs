using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinocchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dashboard dashboard = new Dashboard(5, 5);
            Player pinocchio = new Player('P',"Pinocchio");
            Player cricket = new Player('J',"Jiminy Cricket");
            Player gepeto = new Player('G', "Gepeto");
            dashboard.InitDash();
            dashboard.GameOfPlayer(pinocchio);
            dashboard.GameOfPlayer(cricket);
            dashboard.GameOfPlayer(gepeto);
            
            Console.ReadLine();
        }
    }
}
