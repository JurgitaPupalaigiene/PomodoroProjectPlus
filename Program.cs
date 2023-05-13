namespace PomodoroProjectPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomMode customMode = new CustomMode();
            customMode.ChooseCustomMode();
            
           // PomodoroClock pomodoroClock = new PomodoroClock();
            //pomodoroClock.Run();
            
            /*Console.WriteLine("Hello!");
            Thread.Sleep(3000);
            CustomMode customMode = new CustomMode();
            MyTimer myTimer = new MyTimer(3);
            MyWorkTimer myWorkTimer = new MyWorkTimer(15);
            MyBreakTimer myBreakTimer = new MyBreakTimer(5);
            Console.WriteLine("Pomodoro Clock is ready!");
            Thread.Sleep(1000);
            customMode.ChooseCustomMode();
            //Console.WriteLine("For POMODORO CLOCK, press 1," +
            //" for setting your own tim - press 2");

            //Console.ReadKey();
            Console.WriteLine("Pomodoro clock starts in 3 seconds");
            Thread.Sleep(2000); //dar gali būti Task.Delay
            myTimer.MyTimerStart();
            Thread.Sleep(2000);
            myWorkTimer.MyWorkTimerStarts();
            Thread.Sleep(2000);
            myBreakTimer.MyBreakTimerStarts();
            Thread.Sleep(2000);*/
        }
    }
}