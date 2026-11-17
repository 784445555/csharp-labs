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

        int maxSum;
        int maxRow = FindMaxSumRow(matrix, out maxSum);
        Console.WriteLine("Элементтерінің қосындысы ең үлкен жол: " + maxRow + "-жол, қосындысы = " + maxSum);

        // Өз тестім 1: барлық элемент теріс (бастапқы мән 0 болса, қате нәтиже шығар еді)
        int[,] test1 =
        {
            { -5, -1, -2, -3, -4 },
            { -1, -1, -1, -1, -1 },
            { -9, -8, -7, -6, -5 },
            { -2, -2, -2, -2, -3 },
            { -10, -10, -10, -10, -10 }
        };
        RunTest("Өз тестім 1 (барлығы теріс)", test1);

        // Өз тестім 2: екі жолдың қосындысы бірдей - бірінші жол шығуы керек
        int[,] test2 =
        {
            { 1, 2, 3, 4, 5 },
            { 10, 0, 0, 0, 5 },
            { 3, 3, 3, 3, 3 },
            { 0, 0, 0, 0, 0 },
            { 5, 5, 5, 0, 0 }
        };
        RunTest("Өз тестім 2 (бірдей қосынды)", test2);
    }

    static void RunTest(string title, int[,] m)
    {
        Console.WriteLine();
        Console.WriteLine(title + ":");
        PrintMatrix(m);
        int sum;
        int row = FindMaxSumRow(m, out sum);
        Console.WriteLine("Элементтерінің қосындысы ең үлкен жол: " + row + "-жол, қосындысы = " + sum);
    }

    // 4-нұсқа: қосындысы ең үлкен жолдың нөмірі (1-ден бастап) және сол қосынды.
    // Бірдей болса, бірінші жол қалады (тек қатаң үлкені ғана ауыстырады).
    static int FindMaxSumRow(int[,] m, out int maxSum)
    {
        int rows = m.GetLength(0);
        int cols = m.GetLength(1);

        maxSum = RowSum(m, 0, cols); // бастапқы мән - бірінші жолдың қосындысы
        int maxRowIndex = 0;

        for (int i = 1; i < rows; i++)
        {
            int sum = RowSum(m, i, cols);
            if (sum > maxSum)
            {
                maxSum = sum;
                maxRowIndex = i;
            }
        }
        return maxRowIndex + 1;
    }

    // Бір жолдың қосындысы цикл арқылы
    static int RowSum(int[,] m, int row, int cols)
    {
        int sum = 0;
        for (int j = 0; j < cols; j++)
            sum += m[row, j];
        return sum;
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
