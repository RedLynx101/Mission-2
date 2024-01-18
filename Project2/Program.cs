// Noah Hicks
// IS 413 1/17/24

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] outcomes = roller.RollDice(numberOfRolls);

        HistogramGenerator generator = new HistogramGenerator();
        generator.GenerateHistogram(outcomes, numberOfRolls);
    }
}
