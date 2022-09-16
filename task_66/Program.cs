// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите значение, от которого будет вычисляться сумма натуральных чисел: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите значение, до которого будет вычисляться сумма натуральных чисел: ");
int numberN = int.Parse(Console.ReadLine());

while (numberM > numberN || numberM < 1)
{
    if (numberM > numberN)
    {
        Console.WriteLine("Вы ввели значение от которого будет вычисляться сумма натуральных чисел больше чем до которого.");
        Console.WriteLine("Сформировать такой ряд натуральных чисел невозможно.");
        Console.Write("Введите значение, от которого будет вычисляться сумма натуральных чисел: ");
        numberM = int.Parse(Console.ReadLine());
        Console.Write("Введите значение, до которого будет вычисляться сумма натуральных чисел: ");
        numberN = int.Parse(Console.ReadLine());
    }
    if (numberM < 1)
    {
        Console.WriteLine("Вы ввели значение от которого будут формироваться натуральные числа меньше 1.");
        Console.WriteLine("Сформировать такой ряд натуральных чисел невозможно.");
        Console.Write("Введите значение, от которого будет вычисляться сумма натуральных чисел: ");
        numberM = int.Parse(Console.ReadLine());
        Console.Write("Введите значение, до которого будет вычисляться сумма натуральных чисел: ");
        numberN = int.Parse(Console.ReadLine());
    }
}

// 1 вариант решения с помощью цикла
int sum = 0;
for (int i = numberM; i <= numberN; i++)
{
    if (i <= numberN)
    {
        sum += i;
    }
}
Console.WriteLine($"Ответ по 1 варианту: сумма натуральных чисел от {numberM} до {numberN}: {sum}");

// 2 Вариант решение с помощью рекурсии

void SumNumber(int arg1, int arg2, int sum)
{
    if (arg1 == arg2)
    {
        sum += arg1;
        Console.WriteLine($" {sum}");
        return;
    }
    if (arg1 < arg2)
    {
        sum += arg1;
        SumNumber(arg1 + 1, arg2, sum);
    }
}

sum = 0;
Console.Write($"Ответ по 2 варианту: сумма натуральных чисел от {numberM} до {numberN}:");
SumNumber(numberM, numberN, sum);