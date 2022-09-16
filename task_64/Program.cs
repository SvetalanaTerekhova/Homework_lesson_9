// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите значение, от которого будут выводиться натуральные числа: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите значение, до которого будут выводиться натуральные числа: ");
int numberN = int.Parse(Console.ReadLine());

while (numberM > numberN || numberM < 1)
{
    if (numberM > numberN)
    {
        Console.WriteLine("Вы ввели значение от которого будут формироваться натуральные числа больше чем до которого.");
        Console.WriteLine("Сформировать такой ряд натуральных чисел невозможно.");
        Console.Write("Введите значение, от которого будут выводиться натуральные числа: ");
        numberM = int.Parse(Console.ReadLine());
        Console.Write("Введите значение, до которого будут выводиться натуральные числа: ");
        numberN = int.Parse(Console.ReadLine());
    }
    if (numberM < 1)
    {
        Console.WriteLine("Вы ввели значение от которого будут формироваться натуральные числа меньше 1.");
        Console.WriteLine("Сформировать такой ряд натуральных чисел невозможно.");
        Console.Write("Введите значение, от которого будут выводиться натуральные числа: ");
        numberM = int.Parse(Console.ReadLine());
        Console.Write("Введите значение, до которого будут выводиться натуральные числа: ");
        numberN = int.Parse(Console.ReadLine());
    }
}

// 1 вариант решения с помощью цикла

Console.Write($"Ответ по 1 варианту: натуральные числа от {numberM} до {numberN}:");
for (int i = numberM; i <= numberN; i++)
{
    if (i < numberN)
    {
        Console.Write($" {i},");
    }
    if (i == numberN)
    {
        Console.WriteLine($" {i}");
    }
}

// 2 Вариант решение с помощью рекурсии

void NaturalNumber(int arg1, int arg2)
{
    if (arg1 == arg2)
    {
        Console.WriteLine($" {arg1}");
        return;
    }
    if (arg1 < arg2)
    {
        Console.Write($" {arg1},");
        NaturalNumber(arg1 + 1, arg2);
    }
}

Console.Write($"Ответ по 2 варианту: натуральные числа от {numberM} до {numberN}:");
NaturalNumber(numberM, numberN);