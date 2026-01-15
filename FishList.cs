using System;

namespace fish_search;

public static class FishList
{
    static string[] fishArray = {"goldfish", "pufferfish", "clownfish", "bass", "flounder", "salmon"};

    public static string Search(string searchTerm)
    {
        if (searchTerm == null || searchTerm == "") return "Please input a value.";
        // i forgot what happens when you dont input anything when Console.ReadLine() is called, so heres an OR gate

        foreach (string fish in fishArray)
        {
            string lowerFish = fish.ToLower();
            string lowerSearchTerm = searchTerm.ToLower();

            if (lowerFish.Contains(lowerSearchTerm))
            {
                return $"Found fish: {fish}";
            }
        }

        return "A fish was not found.";
    }
}
