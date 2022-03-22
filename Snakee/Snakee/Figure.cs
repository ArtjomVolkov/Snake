using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
	class Figure
	{
		protected List<Point> pList; //поле типа List, в котором будут содержаться значения типа Point
		public void Draw() //метод рисует точки
		{
			foreach (Point p in pList) 
			{

				p.Draw();
			}
		}

		internal bool IsHit(Figure figure) //метод для проверки столкновения, который берет объект типа класса Figure
		{
			foreach (var p in pList) 
			{
				if (figure.IsHit(p)) //если фигура столкнулась с точкой, то возвращает true, в ином случае false

					return true;
			}
			return false;
		}

		private bool IsHit(Point point) //метод для проверки столкновения, который берет объект типа класса Point. Возвращает bool значение
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
