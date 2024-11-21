void CheckM(int m)
{ 
    if (m < 0)
    {
        Console.WriteLine("Некорректный ввод!");
    }
}

void CheckN(int n)
{ 
    if (n < 0)
    {
        Console.WriteLine("Некорректный ввод!");
    }
}
        
int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0) 
    {
        return AckermannFunction(m - 1, 1);
    }
    else 
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

Console.WriteLine("Введите неотрицательное число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
CheckM(numM);

Console.WriteLine("Введите неотрицательное число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
CheckN(numN);

int result = AckermannFunction(numM, numN);
Console.WriteLine($"Значение функции Аккермана для ({numM}, {numN}) равно: {result}");