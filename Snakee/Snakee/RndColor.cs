using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
	public class RndColor
	{
		public static Random rnd = new Random(); //переменная класса Random
		//рандомный цвет
		public static ConsoleColor GetRandomConsoleColor()
		{
			var consoleColors = Enum.GetValues(typeof(ConsoleColor));
			return (ConsoleColor)consoleColors.GetValue(rnd.Next(1, consoleColors.Length));
		}
	}
}
