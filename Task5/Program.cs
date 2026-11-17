using System;

class Program
{
    static void Main()
    {
        int nomer = 7; // тізімдегі нөмірім
        int n = 5;
        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rnd.Next(-10, 11);

        Console.WriteLine("Матрица (Random(" + nomer + ")):");
        PrintMatrix(matrix);
    }

    // Матрицаны кесте түрінде шығару
    static void PrintMatrix(int[,] m)
    {
        int rows = m.GetLength(0);
        int cols = m.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(m[i, j].ToString().PadLeft(5));
            Console.WriteLine();
        }
    }
}
