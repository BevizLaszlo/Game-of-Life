using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfLife
{
    class Program
    {
        static System.Timers.Timer timer = new System.Timers.Timer();
        static GameOfLife game = new GameOfLife();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            timer.Interval = 100;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);
            timer.Start();
            while (true) ;
        }
        static private void timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.SetCursorPosition(0, 0);
            game.printArea();
            game.nextState();
        }
    }
}
