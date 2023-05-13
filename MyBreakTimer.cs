using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroProjectPlus
{
    internal class MyBreakTimer
    {
        public int timeLeft;
        public MyBreakTimer(int timeLeft)
        {
            this.timeLeft = timeLeft;
        }
        public void MyBreakTimerStarts()
        {
            for (int i = timeLeft; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Break time: {i}");
                Thread.Sleep(1000);

            }
            Console.WriteLine("Your break is over, let's work!");
        }
        public void MyBreakTimerStartsPlus()
        {
            for (int i = timeLeft; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Break time: {i}");
                Thread.Sleep(1000);

            }
            Console.WriteLine("You did it!");
        }
    }
}
