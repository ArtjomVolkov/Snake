﻿using Snakee;
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
			Sound sounds = new Sound();
			sounds.Play();
			Console.SetBufferSize(180, 80);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек 22313123		
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					sounds.Deads();
					break;
				}
				if (snake.Eat(food))
				{
					sounds.PlayEat();
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			GameOver game = new GameOver();
            game.WriteGameOver();
			Console.ReadLine();
		}

	}
}
