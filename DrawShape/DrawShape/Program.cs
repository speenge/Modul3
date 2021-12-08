using System;
using System.Timers;

namespace DrawShape
{
    class Program
    {
        public static int tickCount = 0;
        public static Timer tick;
        public static int food, logs, gold, iron, LogUpgrade, inns, taverns, wheat, farms, beer, mines;
        public static bool gamestate = true;
        static void Main(string[] args)
        {
            food = logs = gold = iron = LogUpgrade = inns = taverns = wheat = farms = beer = mines = 0;
            var Input = new Inputs();

            timer();
            gold = 100;
            while (gamestate)
            {
                Input.Input(gold, LogUpgrade, logs, farms, wheat, taverns, inns, food);

            }

        }

        private static void Input()
        {
            ConsoleKeyInfo Pinput = Console.ReadKey();

            if (Pinput.Key == ConsoleKey.Q)
            {
                gamestate = false;
            }
            else if (Pinput.Key == ConsoleKey.L)
            {
                if (gold >= 10)
                {
                    gold -= 10;
                    LogUpgrade += 1;
                }
            }
            else if (Pinput.Key == ConsoleKey.F)
            {
                if (logs >= 100)
                {
                    logs -= 100;
                    farms += 1;
                }
            }
            else if (Pinput.Key == ConsoleKey.T)
            {
                if (logs > 150 && wheat > 0)
                {
                    logs -= 150;
                    taverns += 1;
                }
            }
            else if (Pinput.Key == ConsoleKey.I)
            {
                if (logs >= 200 && food > 0)
                {
                    logs -= 200;
                    inns += 1;
                }
            }
        }

        public static void Tick_Elapsed(object sender, ElapsedEventArgs e)
        {
            tickCount++;
            logs += LogUpgrade;
            resourceTicks();
            menu();

            //throw new NotImplementedException();
        }

        private static void resourceTicks()
        {
            if (farms > 0)
            {
                wheat += 10 * farms;
                if (taverns > 0)
                {
                    wheat -= 8 * farms;
                    beer += 15 * farms;
                    food += 5 * farms;
                }

            }
            if (taverns > 0)
            {
                beer -= 6 * taverns;
                food -= 2 * taverns;
                gold += 5 * taverns;
            }
            if (inns > 0)
            {
                food -= 4 * inns;
                gold += 2 * inns;
            }
        }

        public static void timer()
        {
            tick = new System.Timers.Timer();
            tick.Interval = 1000;

            tick.Elapsed += Tick_Elapsed;
            tick.Enabled = true;
            tick.AutoReset = true;
            tick.Start();
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine($"Food: {food} | Wheat: {wheat} | Logs: {logs} | Gold: {gold} | Iron: {iron} |");
            Console.WriteLine($"\n Lumberjacks: {LogUpgrade}\n Taverns: {taverns}\n Inns: {inns} \n Farms: {farms}\n Mines: {mines}");
        }
    }
}
