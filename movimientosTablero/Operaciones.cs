using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movimientosTablero
{
    internal class Operaciones
    { 
    
        //Rellenar la matriz con una cadena dada
        public static void rellenarMatriz(string[,] matriz,string cadena)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = cadena;
                }
            }
        }
        public static void ponerPosicion(string[,] matriz, int posI, int posJ, string cadena)
        {
            matriz[posI, posJ] = cadena;
        }
        public static void entradaOpciones(String[,] tablero,int posI, int posJ)
        {
            #region InicializaVariables
            string opcion;
            int opcionNum = 0;
            bool salir = false;
            #endregion
            #region LogicaWhile
            while (!salir)
            {
                mostrarOpciones();
                opcion = Console.ReadLine();

                if (Int32.TryParse(opcion, out opcionNum))
                {
                    switch (opcionNum)
                    {
                        case 1: moverDerecha(ref tablero,ref posI,ref posJ);break;
                        case 2: moverIzquierda(ref tablero,ref posI,ref posJ);break;
                        case 3: moverAbajo(ref tablero, ref posI, ref posJ); break;
                        case 4: moverArriba(ref tablero, ref posI, ref posJ); break;

                        case 5: salir = true; break;
                        default: Console.WriteLine("Solo entre 1 y 5"); break;
                    }
                    
                }
                pintaTablero(tablero);
            }
            #endregion
        }

        private static void mostrarOpciones()
        {
            Console.WriteLine("1.Derecha");
            Console.WriteLine("2.Izquierda");
            Console.WriteLine("3.Abajo");
            Console.WriteLine("4.Arriba");
            Console.WriteLine("5.Salir");
        }

        public static void pintaTablero(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]+" ");
                        
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void moverDerecha(ref string[,] tablero, ref int fila, ref int columna)
        {
            if (columna + 1 < tablero.GetLength(1))
            {
                tablero[fila, columna] = "X";
                columna++;
                tablero[fila, columna] = "0";
            }
            else
            {
                Console.WriteLine("Movimiento no válido: no puedes moverte fuera del tablero.");
            }
        }

        public static void moverIzquierda(ref string[,] tablero, ref int fila, ref int columna)
        {
            if (columna - 1 >= 0)
            {
                tablero[fila, columna] = "X";
                columna--;
                tablero[fila, columna] = "0";
            }
            else
            {
                Console.WriteLine("Movimiento no válido: no puedes moverte fuera del tablero.");
            }
        }

        public static void moverArriba(ref string[,] tablero, ref int fila, ref int columna)
        {
            if (fila - 1 >= 0)
            {
                tablero[fila, columna] = "X";
                fila--;
                tablero[fila, columna] = "0";
            }
            else
            {
                Console.WriteLine("Movimiento no válido: no puedes moverte fuera del tablero.");
            }
        }

        public static void moverAbajo(ref string[,] tablero, ref int fila, ref int columna)
        {
            if (fila + 1 < tablero.GetLength(0))
            {
                tablero[fila, columna] = "X";
                fila++;
                tablero[fila, columna] = "0";
            }
            else
            {
                Console.WriteLine("Movimiento no válido: no puedes moverte fuera del tablero.");
            }
        }
    }
}
