//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

using System.Globalization;

string arr(string message)
{
    Console.Write(message);
    string array = Console.ReadLine()!;

    return array;
}

Console.WriteLine($"[{arr("Введите массив :")}]");