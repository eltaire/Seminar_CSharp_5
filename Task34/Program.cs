// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100,1000);
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

int GetEvenNumbersQuantity(int[] a)
{
    int quan = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
            quan ++;
    }
    return quan;
}
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine("Сумма четных чисел в Вашем массиве равна " + GetEvenNumbersQuantity(array));