void CheckM(int m)
{ 
    if (m <= 0)
    {
        Console.WriteLine("Некорректный ввод!");
    }
}

void CheckN(int n)
{ 
    if (n <= 0)
    {
        Console.WriteLine("Некорректный ввод!");
    }
}

void PrintNaturalNumbers (int m, int n)
{
    if (m > n) return;

    Console.Write(m);

    if (m < n)
    {
        Console.Write(" ");
    }

    PrintNaturalNumbers(m + 1, n);
}

Console.WriteLine("Введите натуральное число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
CheckM(numM);

Console.WriteLine("Введите натуральное число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
CheckN(numN);

PrintNaturalNumbers(numM, numN);