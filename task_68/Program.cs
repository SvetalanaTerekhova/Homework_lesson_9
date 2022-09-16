// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        n = n + 1;
        return n;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.Write("Введите значение m в функции Аккермана А(m,n): ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите значение n в функции Аккермана А(m,n): ");
int numberN = int.Parse(Console.ReadLine());

while (numberM < 0 || numberN < 0)
{
    Console.Write("Функция Аккермана — принимает два неотрицательных целых числа.");
    Console.WriteLine("Вы ввели отрицательное число.");
    Console.Write("Введите значение m в функции Аккермана А(m,n): ");
    numberM = int.Parse(Console.ReadLine());
    Console.Write("Введите значение n в функции Аккермана А(m,n): ");
    numberN = int.Parse(Console.ReadLine());
}

int resul = Ackermann(numberM, numberN);
Console.WriteLine($"Функция Аккермана при А({numberM},{numberN}) = {resul}");