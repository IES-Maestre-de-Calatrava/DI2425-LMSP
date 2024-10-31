using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movimientosTablero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tablero = new string[4, 4];
            Operaciones.rellenarMatriz(tablero, "X");
            Operaciones.ponerPosicion(tablero, 0, 0, "0");
            Operaciones.pintaTablero(tablero);
            Operaciones.entradaOpciones(tablero,0,0);
            Operaciones.pintaTablero(tablero);

        }
    }
}
