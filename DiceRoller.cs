using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission2DiceRoll;

namespace Mission2DiceRoll
{
    internal class DiceRoller
    {
        private Random random = new Random();

        public int[] SimulateRolls(int NumOfRolls)
        {
            int[] aiRollTotals = new int[13];
          

            for (int iCount = 0; iCount < NumOfRolls; iCount++)
            {
                int iDie1 = random.Next(1, 7);
                int iDie2 = random.Next(1, 7);

                int iTotal = (iDie1 + iDie2);

                aiRollTotals[iTotal]++;

            }

            return aiRollTotals;
        }
}
}
