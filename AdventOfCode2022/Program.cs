
using AdventOfCode2022;

try
{
    var dayOne = new DayOne("calories.txt");
    var maxCalories = dayOne.GetMaxCaloriesOnElf();
    Console.WriteLine($"The max calories found are {maxCalories}");
    var maxThreeElves = dayOne.GetMaxCaloriesOfThreeElves();
    Console.WriteLine($"The 3 high (in calories!) elves carry {maxThreeElves} calories");
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}

