int[] GetRandomNumbers()
{
    Random rnd = new Random();
    int[] array = new int[15];
    for (int i = 0; i < array.Length; ++i)
        array[i] = rnd.Next(5);
    return array;
}

//Printing the numbers
int[] randomNumbers = GetRandomNumbers();
Console.Write("Random numbers: ");
foreach(int number in randomNumbers)
{
    Console.Write(number + " ");
}
Console.WriteLine("");

//Sum all the numbers

Console.Write("Sum of all the numbers: ");
int sum = 0;
foreach(int number in randomNumbers)
{
    sum += number;
}
Console.WriteLine(sum);


//Put all the numbers that are less than 2 in a separate list 

Console.Write("List with numbers < 2:  ");
List<int> list = new();
foreach(int number in randomNumbers)
{
    if (number < 2)
    {
        list.Add(number);
    }
}

int j = 0;

while (j < list.Count) 
{
    Console.Write(list[j] + " ");
    ++j;
} 
Console.WriteLine();

//Sort the list in ascending order

Console.Write("The list in ascending order: ");
list.Sort();
foreach(int number in list)
{
    Console.Write(number + " ");
}
Console.WriteLine();