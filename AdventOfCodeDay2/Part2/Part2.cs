// PART 2  
class Part2
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
            int removalCount = 0;
            int i = 0;
            bool isIncreasing = numbers[1] > numbers[0]; // we have to check if its increasing or decreasing
            
            while (i < numbers.Count - 1)
            {
                int difference = numbers[i + 1] - numbers[i];

                // Logic which handles if its safe
                if (Math.Abs(difference) > 3 || difference == 0)
                {
                    if (removalCount == 1)
                        return false;
                    numbers.RemoveAt(i);
                    removalCount++;      
                    if (i > 0) i--;      
                    continue;
                }
                if ((isIncreasing && numbers[i + 1] <= numbers[i]) || (!isIncreasing && numbers[i + 1] >= numbers[i]))
                {
                    if (removalCount == 1)
                        return false; // if its more than 1 removed its false
                    numbers.RemoveAt(i); 
                    removalCount++;      
                    if (i > 0) i--;    
                    continue;
                }

                i++; 
            }
            return true;
        }

        Console.WriteLine(safeReports);
    }
}