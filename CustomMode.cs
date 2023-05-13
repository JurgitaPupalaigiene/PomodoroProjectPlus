using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroProjectPlus
{
    internal class CustomMode
    {

        public CustomMode() { }

        public void ChooseCustomMode()
        {
            Console.WriteLine("For POMODORO CLOCK, press 1 and ENTER," +
        " for setting your own time - press 2 and ENTER");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("Pomodoro clocks starts in 3 seconds");
                Thread.Sleep(3000);
                DateTime start = DateTime.Now;
                while ((DateTime.Now - start).TotalSeconds < 1000)
                {
                    MyTimer myTimer = new MyTimer(3);
                    myTimer.MyTimerStart();
                    Thread.Sleep(1000);
                    MyWorkTimer myWorkTimer = new MyWorkTimer(5);
                    MyBreakTimer myBreakTimer = new MyBreakTimer(3);
                    myWorkTimer.MyWorkTimerStarts();
                    Thread.Sleep(2000);
                    myBreakTimer.MyBreakTimerStarts();
                    Thread.Sleep(2000);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }

                    }
                }

            }

            else if (userInput == 2)
            {
                PomodoroClock pomodoroClock = new PomodoroClock();
                pomodoroClock.Run();
            }
            else
            {
                Console.WriteLine("Sorry, you have choosen wrong button");
                Console.WriteLine("Buy!");
            }
                        Console.WriteLine("Press any key to exit!");
                        Console.ReadKey();
                    }
                }
            }
      