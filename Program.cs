﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

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

string[] array = { "lol", "ka", "keks", "chops", "cats", "cat", "int", "internet" };

PrintArray(array);
ThreeSymbolArray(array);


