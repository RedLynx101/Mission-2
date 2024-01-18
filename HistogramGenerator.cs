// Noah Hicks
// IS 413 1/17/24

public class HistogramGenerator
{
    public void GenerateHistogram(int[] outcomes, int totalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

        for (int i = 0; i < outcomes.Length; i++)
        {
            int percentage = (outcomes[i] * 100) / totalRolls;
            string stars = new String('*', percentage);
            Console.WriteLine($"{i + 2}: {stars}");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
