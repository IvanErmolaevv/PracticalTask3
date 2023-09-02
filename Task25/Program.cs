//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using System.Globalization;

int number1(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

int number2(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

Console.WriteLine(Math.Pow(number1("Введите число 1: "), number2("Введите число 2: ")));