void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]}; ");
    }
    Console.WriteLine();
}

void ThreeSymbolArray(string[] array)
{
        for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) Console.Write($"{array[i]}; ");
}


