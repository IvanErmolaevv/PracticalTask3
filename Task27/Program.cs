//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System.Globalization;

int number(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

void sum(int numb)
{
    int index = 1;
    int summ = 0;
    while (numb / index != 0)
    {
        summ = summ + ((numb / index) % 10);
        index = index * 10; 
    }
    index = index / 100;
    Console.WriteLine(summ);
}

sum(number("Введите число: "));