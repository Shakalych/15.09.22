Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillMatrixArray(array);
PrintMatrixArray(array);
AverageColumn(array);

void FillMatrixArray(int[,] array)
{
    for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 100);
		}
	}
}

void PrintMatrixArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
	{
        Console.Write("[");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
        Console.Write("]");
		Console.WriteLine();
	}
}

void AverageColumn(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average = (average + array[i, j]);
        }
        average = average / n;
        Console.Write(average + "; ");
    }    
}

