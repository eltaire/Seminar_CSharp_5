// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min,max);
    }
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

int GetSumNumbersOddPosition(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i ++)
    {
        if (i % 2 != 1)
            sum += a[i];
    }
    return sum;
}

int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine("Сумма чисел, стоящих на нечетных позициях в Вашем массиве равна " + GetSumNumbersOddPosition(array));