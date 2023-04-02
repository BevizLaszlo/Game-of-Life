using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfLife
{
	class GameOfLife
	{
		bool[,] _playArea = new bool[25, 90];

		public GameOfLife()
		{
			_playArea = fillBlankArea();

			Random random = new Random();
			for (int i = 1; i < _playArea.GetLength(0) - 1; i++)
			{
				for (int j = 1; j < _playArea.GetLength(1) - 1; j++)
				{
					_playArea[i, j] = (random.Next(0,5) == 1);
				}
			}
		}

		private bool[,] fillBlankArea()
		{
            bool[,] Area = new bool[_playArea.GetLength(0), _playArea.GetLength(1)];

            for (int i = 0; i < Area.GetLength(0); i++)
            {
                for (int j = 0; j < Area.GetLength(1); j++)
                {
                    Area[i, j] = false;
                }
            }

			return Area;
        }

		public void nextState()
		{
			bool[,] nextPlayArea = fillBlankArea();

            for (int i = 1; i < _playArea.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < _playArea.GetLength(1) - 1; j++)
                {
					int cells = NumOfCells(i, j);
                    if (_playArea[i, j])
					{
						if (cells == 2 || cells == 3) nextPlayArea[i, j] = true;
                    }
                    else
					{
						if (cells == 3) nextPlayArea[i, j] = true;
					}
                }
            }

			_playArea = nextPlayArea;
        }

		private int NumOfCells(int x, int y)
		{
			int cells = 0;

			for (int i = x - 1; i <= x + 1; i++)
			{
				for (int j = y - 1; j <= y + 1; j++)
				{
					if ((i != x || j != y) && _playArea[i, j]) cells++;
				}
			}

			return cells;
		}

		public void printArea()
		{
			string area = "";
			for (int i = 0; i < _playArea.GetLength(0); i++)
			{
				for (int j = 0; j < _playArea.GetLength(1); j++)
				{
                    if (_playArea[i, j]) area += "█";
                    else area += " ";
                }
				area += "\n";
			}

			Console.Write(area);
		}
	}
}
