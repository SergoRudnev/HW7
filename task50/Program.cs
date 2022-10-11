//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue()
{
    return new Random().Next();
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue();
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
int stringNamber = GetNumberFromConsole("Введите номер строки");
int colNamber = GetNumberFromConsole("Введите номер столбца");
if (stringNamber < 0 | stringNamber > array.GetLength(0) - 1 | colNamber < 0 | colNamber > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
 else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[stringNamber - 1, colNamber - 1]);
    }