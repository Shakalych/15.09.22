//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FilllMatrixArray(double[,] array)
{
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			array[i, j] = Convert.ToDouble(new Random().Next(-100 , 100)) / 10;
		}
	}
}

void PrintMatrixArray(double[,] array)
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

double[,] array = new double[3, 4];
FilllMatrixArray(array);
PrintMatrixArray(array);


