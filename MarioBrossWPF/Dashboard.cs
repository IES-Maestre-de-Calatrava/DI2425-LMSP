﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarioBrossWPF
{
    internal class Dashboard
    {
        private int rows;
        private int cols;
        public String[,] dash;
        public Dashboard(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.dash = new string[rows,cols];
        }
        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }

        public void InitDash()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    dash[i,j] = rnd.Next(0, 2).ToString();
                }
            }
        }
        
    }
}
