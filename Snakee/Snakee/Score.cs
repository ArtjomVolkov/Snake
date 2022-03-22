using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Score 
    {
        int a = 0;
        public Score()
        {
        }
        public void Vivod()
        {
            a++;
            Console.SetCursorPosition(70, 23);
            Console.WriteLine($"Счет: {a}");
        }
        public void Vivod2()
        {
            Console.SetCursorPosition(35, 11);
            Console.WriteLine($"Cчёт: {a}");
        }
    }
}
