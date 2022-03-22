using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
	class GameOver
	{


		public void WriteGameOver() //метод,который пишет в конце игре по типу GameOver
		{
			int xOffset = 25; //кординаты по x
			int yOffset = 8; //кординаты по y
			Console.ForegroundColor = ConsoleColor.Green; //цвет текста
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++); //текст
			WriteText("    G A M E    O V E R", xOffset + 1, yOffset++); //текст
			WriteText("============================", xOffset, yOffset++); //текст
		}

		static void WriteText(String text, int xOffset, int yOffset) //метод, написание текста
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}


	}
}
