class Part1
{
    public static void Execute()
    {
        string filePath = "Input.txt";
        string[] lines = File.ReadAllLines(filePath);
        int safeReports = 0;


        foreach (string line in lines)
        {
            var numbers = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToList();
            if (TryMe(numbers))
            {
                safeReports += 1;
            }

        }

        bool TryMe(List<int> numbers)
        {
            bool isIncreasing = numbers[1] > numbers[0]; // we have to check if its increasing or decreasing

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int difference = numbers[i + 1] - numbers[i];

                // Logic which handles if its safe
                if (Math.Abs(difference) > 3 || difference == 0)
                {
                    return false;
                }

                // Here we check if it keeps on increasing or keeps on decreasing
                if ((isIncreasing && numbers[i + 1] <= numbers[i]) || (!isIncreasing && numbers[i + 1] >= numbers[i]))
                {
                    return false;
                }
            }

            return true;
        }

        Console.WriteLine(safeReports);
    }
}
