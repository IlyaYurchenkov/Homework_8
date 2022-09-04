// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

if (rows == columns)
    {
        Console.WriteLine("Неккоректно введен размер массива. Повторите ввод: ");
        return;
    }

int[,] numbers = new int[rows, columns];
    
FillArray(numbers);
PrintArray(numbers);
    
 
int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);

for (int i = 1; i < numbers.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(numbers,i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine +1} - строка с минимальной суммой элементов.\nСумма элементов = {sumLine}: ");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine("\n");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}