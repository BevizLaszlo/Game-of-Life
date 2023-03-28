using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfLife
{
    class Gameplay
    {
        bool[,] _playArea = new bool[5, 5];

        public Gameplay()
        {
            for (int i = 0; i < _playArea.GetLength(0); i++)
            {
                for (int j = 0; j < _playArea.GetLength(1); j++)
                {
                    _playArea[i, j] = false;
                }
            }

            Random random = new Random();
            for (int i = 1; i < _playArea.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < _playArea.GetLength(1) - 1; j++)
                {
                    _playArea[i, j] = Convert.ToBoolean(random.Next(0, 2));
                }
            }

            //for (int i = 0; i < _playArea.GetLength(0); i++)
            //{
            //    for (int j = 0; j < _playArea.GetLength(1); j++)
            //    {
            //        if (_playArea[i, j]) Console.Write("1\t");
            //        else Console.Write("0\t");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
