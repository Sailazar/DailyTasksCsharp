int[] GetRandomNumbers()
{
    Random rnd = new Random();
    int[] array = new int[15];
    for (int i = 0; i < array.Length; ++i)
        array[i] = rnd.Next(5);
    return array;
}

int[] randomNumbers = GetRandomNumbers();
Console.WriteLine("Random numbers: ");
foreach (int number in randomNumbers)
{
    Console.Write(number + " ");
}
Console.WriteLine("");