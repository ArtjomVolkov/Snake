using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
