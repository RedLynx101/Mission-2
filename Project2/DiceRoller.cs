// Noah Hicks
// IS 413 1/17/24

public class DiceRoller
{
    public int[] RollDice(int numberOfRolls)
    {
        int[] outcomes = new int[11]; // From 2 to 12
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll = random.Next(1, 7) + random.Next(1, 7); // Rolling two 6-sided dice
            outcomes[roll - 2]++; // Increment count for this outcome
        }

        return outcomes;
    }
}
