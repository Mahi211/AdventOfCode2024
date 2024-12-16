class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter part (1 or 2):");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Part1.Execute();
        }
        else if (input == "2")
        {
            Part2.Execute();
        }
        else
        {
            Console.WriteLine("Invalid part.");
        }
    }
}
