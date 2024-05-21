using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the size of the square matrix (less than 5): ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[size, size];
        int[,] matrix2 = new int[size, size];
        int[,] resultMatrix = new int[size, size];

        Console.WriteLine("Input elements in the first matrix:");
        InputMatrix(matrix1, size);

        Console.WriteLine("Input elements in the second matrix:");
        InputMatrix(matrix2, size);

        DisplayMatrix("The First matrix is:", matrix1, size);
        DisplayMatrix("The Second matrix is:", matrix2, size);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        DisplayMatrix("The Addition of two matrices is:", resultMatrix, size);
    }

    static void InputMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i}],[{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void DisplayMatrix(string message, int[,] matrix, int size)
    {
        Console.WriteLine(message);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}