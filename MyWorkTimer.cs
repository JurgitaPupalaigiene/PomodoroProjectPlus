using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroProjectPlus
{
    internal class MyWorkTimer
    {
        private int timeLeft;
        public MyWorkTimer(int timeLeft)
        {
            this.timeLeft = timeLeft;
        }
        public void MyWorkTimerStarts()
        {
            for (int i = timeLeft; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Work time: {i}");
                Thread.Sleep(1000);

            }
            Console.WriteLine("Now, take a break!");
        }
    }
}
