namespace AdventOfCode2022;

public class DayOne(string file)
{
    public int GetMaxCaloriesOnElf()
    {
        var caloriesByElf = File.ReadAllText(file)
            .Split(Environment.NewLine + Environment.NewLine)
            .Select(s => s
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .Sum()
            ).ToArray();
        
        return caloriesByElf.Max();
    }

    public int GetMaxCaloriesOfThreeElves()
    {
        var threeElvesCalories = new [] { 0, 0, 0 };
        var currentCalories = 0;
        using StreamReader reader = new StreamReader(file);
        while (!reader.EndOfStream)
        {
            if (int.TryParse(reader.ReadLine(), out var calories))
            {
                currentCalories += calories;
            }
            else
            {
                var smallestIndex = 0;
                for (var i = 1; i < 3; i++)
                {
                    if (threeElvesCalories[i] < threeElvesCalories[smallestIndex])
                        smallestIndex = i;
                }

                if (threeElvesCalories[smallestIndex] < currentCalories)
                    threeElvesCalories[smallestIndex] = currentCalories;
                currentCalories = 0;
            }
        }

        return threeElvesCalories.Sum();
    }
}