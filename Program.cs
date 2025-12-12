string[] fishArray = {"goldfish", "pufferfish", "clownfish", "bass", "flounder", "salmon"};

Console.Write("Fish search: ");
string searchTerm = Console.ReadLine();
Console.WriteLine( SearchForFish(searchTerm) );

string SearchForFish(string searchTerm)
{
    foreach (string fish in fishArray)
    {
        string lowerFish = fish.ToLower();
        string lowerSearchTerm = searchTerm.ToLower();

        if (lowerFish.Contains(lowerSearchTerm))
        {
            return $"Found fish: {fish}";
        }
    }

    return $"Did not find fish matching \"{searchTerm}\"";
}