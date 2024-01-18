using Mission2DiceRoll;
internal class Program
{
    // Author Name: Peter John Phethean
    // Section 004
    // Program Name: DiceRoll

    private static void Main()
    {
        // Program welcomes the user and asks them to input how many rolls they want it to simulate
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate? ");
        int iNumOfRolls = int.Parse(Console.ReadLine());

        //DiceRoller class is connected in this file
        DiceRoller dr = new DiceRoller();

        //The following method generates a series of rolls and tallies up how frequently they appear
        int[] aiResults = dr.SimulateRolls(iNumOfRolls);

        //Program prints the results based on the PrintHistogram method
        PrintHistogram(aiResults, iNumOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");



    }

    private static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        // Tallies up an asterisk for every percent each number has. This is based on how many times it has been rolled 
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            //calculates the percentage 
            double iPercentage = (results[iCount] / (float)totalRolls) * 100;

            string MsgAstCollect = "";
            // every percent equals an * when the result is printed
            for (int iCountPct = 0; iCountPct < iPercentage; iCountPct++) 
            {
                MsgAstCollect += "*";
            }

            Console.WriteLine($"{iCount}: {MsgAstCollect} ");
        }
    }
}