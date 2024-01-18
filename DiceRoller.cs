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
        // connects to the Random class and establishes it throught the random variable

        private Random random = new Random();

        //establishes the SimulateRolls method, it rolls based on the numbers passed to the NumOfRolls parameter
        public int[] SimulateRolls(int NumOfRolls)
        {
            int[] aiRollTotals = new int[13];
          
            //Dice will roll between 1 and 6 and then be added together for a total.
            // The total result in the array will increase a tally for how many times a specific number is rolled based on the two dice

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
