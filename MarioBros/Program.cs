﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioBros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero(8, 8);
            tablero.rellenarTablero();
        }
    }
}
