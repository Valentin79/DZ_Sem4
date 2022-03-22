//  Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции

void FillArray(int[] array)
{
    Random rnd = new Random();
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        arr[i] = rnd.Next(0,100);
    }
}


void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
