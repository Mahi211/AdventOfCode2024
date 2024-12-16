
// PART 1  -  answer without using LINQ, could add like for memory effiency
string filePath = "Input.txt";
string[] lines = File.ReadAllLines(filePath);

List<int> firstLocations = new();
List<int> secondLocations = new();
int results = 0;

foreach  (string line in lines)
{
    var info = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    firstLocations.Add(int.Parse(info[0]));
    secondLocations.Add(int.Parse(info[1]));
}
firstLocations.Sort();
secondLocations.Sort();


for(int i = 0; i < firstLocations.Count; i++)
{
    int diff = Math.Abs(firstLocations[i] - secondLocations[i]);
    results += diff;
}

Console.WriteLine(results);




// PART 2 

int secondResult = 0;
int amount = 0;

foreach (int i in firstLocations)
{
    foreach(int j in secondLocations)
    {
        if (i == j)
        {
            amount += 1;
        }

    }
    secondResult += i * amount;
    amount = 0;
}

Console.WriteLine(secondResult);