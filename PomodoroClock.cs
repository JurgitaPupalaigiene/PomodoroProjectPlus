using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroProjectPlus
{
    internal class PomodoroClock
    {

        int numberOfIntervals;
        public PomodoroClock()
        {

        }
        public void Run()
        {
            CountingPeriods countingPeriods = new CountingPeriods();
            MyTimer myTimer = new MyTimer(3);
            MyWorkTimer myWorkTimer = new MyWorkTimer(5);
            MyBreakTimer myBreakTimer = new MyBreakTimer(3);

            Console.WriteLine(" Enter your spare period of time in minutes and press ENTER: ");
            numberOfIntervals = int.Parse(Console.ReadLine()) / (5 + 3);
            Console.WriteLine($"The number of intervals: {numberOfIntervals}");
            Console.WriteLine("Let's start");
            Thread.Sleep(2000);
            int intervalsLeft = 0;

            
            for (int i = 0; i < numberOfIntervals; i++)
            {
                intervalsLeft++;
                
                if (intervalsLeft < numberOfIntervals)
                {
                   myWorkTimer.MyWorkTimerStarts();
                    Thread.Sleep(2000);
                    myBreakTimer.MyBreakTimerStarts();
                    Thread.Sleep(2000);
                    Console.Clear();

                }

                else
                {
                    Console.WriteLine("The last interval");
                    Thread.Sleep(2000);
                    myWorkTimer.MyWorkTimerStarts();
                    Thread.Sleep(2000);
                    myBreakTimer.MyBreakTimerStartsPlus();
                    Thread.Sleep(3000);
                    
                }
            }
            Console.Clear();
            Console.WriteLine("Great job!");

        }
    }
}
