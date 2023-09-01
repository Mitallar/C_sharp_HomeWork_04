// Задача 29: Напишите программу, которая задаёт массив из 8 элементов,
// заполненных псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void WriteInArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(41);
    }
}

void DerivationArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int[] array = new int [8];

WriteInArray(array);
DerivationArr(array);