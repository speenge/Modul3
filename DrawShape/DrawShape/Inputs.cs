using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShape
{
    public class Inputs
    {
        private static void Input(int[] args)
        {
            int gold = args[0];
            int LogUpgrade = args[1];
            int logs = args[2];
            int farms = args[3];
            int wheat = args[4];
            int taverns = args[5];
            int inns = args[6];
            int food = args[0];
            
            
            ConsoleKeyInfo Pinput = Console.ReadKey();

            //if (Pinput.Key == ConsoleKey.Q)
            //{
            //    gamestate = false;

            //}
            //else
            if (Pinput.Key == ConsoleKey.L)
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

        internal void Input(int gold, int logUpgrade, int logs, int farms, int wheat, int taverns, int inns, int food)
        {
            throw new NotImplementedException();
        }
    }
}
