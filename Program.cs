Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

static void DisplayRandomNumbers() 
{
    Random random = new();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}