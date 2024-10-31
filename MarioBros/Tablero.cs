using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioBros
{
    internal class Tablero
    {
        private int filas;
        private int columnas;
        private string[,] tablero;
        public Tablero(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.tablero = new string[filas,columnas];
        }
        public void rellenarTablero()
        {
            Random rnd = new Random();
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = rnd.Next(0,2).ToString();
                }
            }
        }
        public static void pintaTablero(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }



    }
}
