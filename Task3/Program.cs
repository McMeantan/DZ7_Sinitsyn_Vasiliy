// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

void ShowReverse(int[] array, int index)
{
    if (index < 0) return;

    Console.Write($" {array[index]}");

    if (index > 0) Console.Write(",");

    ShowReverse(array, index - 1);
}

Console.WriteLine("Задайте размер массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRnd(n, -10, 10);
PrintArray(arr);
ShowReverse(arr, n - 1);