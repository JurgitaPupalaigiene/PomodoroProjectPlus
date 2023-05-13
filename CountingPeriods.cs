using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroProjectPlus
{
    internal class CountingPeriods
    {
        int period;
        int remainder;
        public CountingPeriods()
        { }

       /* public void GettingUsersPeriod()
        {
        Console.WriteLine("Enter period of time (in minutes) you have: ");
           int period = int.Parse(Console.ReadLine());
            if (period < 0 || period==0)
            {
            Console.WriteLine("Wrong input");
            }
            else if (period >= 1)
            {
                 void CountPeriod()
                {
                    int repeat = period / (25 + 5);
                    int remainder = period % (25 +5);
                    if (period >=1 && remainder == 0) 
                    {
                        pomodoroClock.Run(repeat);
                    }
                    else if(repeat <= 0) 
                    {
                        Console.WriteLine("Insuficient period");
                    }
                    else 
                    {
                        Console.WriteLine(" Your Pomodoro clock is starting!");
                        pomodoroClock.CustomModeStart();
                    }

                }*/

        }
    }
