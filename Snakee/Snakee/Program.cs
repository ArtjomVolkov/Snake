﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(180, 80);

            Horizon upLine = new Horizon(0,78,0,'+');
            Horizon downLine = new Horizon(0, 78, 24, '+');
            Vertical leftLine = new Vertical(0,24,0,'+');
            Vertical rightLine = new Vertical(0,24,78,'+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 10, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
        }
    }
}
