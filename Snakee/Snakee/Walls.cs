using Snakee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
	class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();

			//рамки
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+'); //Граница поля
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+'); //Граница поля
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+'); //Граница поля
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+'); //Граница поля

			wallList.Add(upLine); //добавление в wallList
			wallList.Add(downLine); //добавление в wallList
			wallList.Add(leftLine); //добавление в wallList
			wallList.Add(rightLine); //добавление в wallList
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}
