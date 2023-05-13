using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroProjectPlus
{
    internal class MyTimer
    {
        public int timeLeft;
        public MyTimer(int timeLeft)
        {
            this.timeLeft = timeLeft;
        }

        public void MyTimerStart()
        {
            for (int i = timeLeft; i >= 0; i--)
            {
                
               Console.Clear();
                Console.WriteLine($"{i}");
                Thread.Sleep(1000); //nezinau ka daro,kam reikalingas?
                
            }
            Console.WriteLine("Pomodoro Clock starts!!!");
            Thread.Sleep(2000);
            Console.WriteLine("Concentrate and start you work");
            Thread.Sleep(2000);
        }
    }
}
