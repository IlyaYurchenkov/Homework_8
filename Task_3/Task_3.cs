// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
int m = ReadInt("Введите число строк 1-й матрицы: ");
int n = ReadInt("Введите число столбцов 1-й матрицы и число строк 2-1 матрицы: ");
int p = ReadInt("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"\nПервая матрица: ");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
FillArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица: ");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);


void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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