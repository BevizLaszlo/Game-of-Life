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

            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);
            timer.Start();
            while (Console.Read() != 'q') ;
        }
        static private void timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            game.printArea();
            game.nextState();
        }
    }
}
