using Snakee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Snakee
{
	class Program
	{
		static void Main(string[] args)
		{
			//добавление музыки
			Media settings = new Media();
			Sound sound = new Sound(settings.GetResourceFolder());
			sound.Play(); //проигрывается начальная музыка
			Sound soundeat = new Sound(settings.GetResourceFolder());
			Sound deads = new Sound(settings.GetResourceFolder());
			//разрешение окна
			Console.SetWindowSize(80, 25);
			//появление границы
			Walls walls = new Walls(80, 25);
			walls.Draw();
			//точки	появление змейки
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();
			//точки появление еды
			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					deads.Deads(); //звук смерти
					break;
				}
				if (snake.Eat(food))
				{
					soundeat.PlayEat(); //звук поедание еды
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100); //задержка 100 секунд
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			GameOver gameOver = new GameOver();
			gameOver.WriteGameOver(); //конец игры
			Console.ReadLine();
		}
	}
}
