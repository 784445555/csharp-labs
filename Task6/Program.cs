using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string? text;
        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine();
        } while (string.IsNullOrEmpty(text));

        int removedCount;
        string result = RemoveSpaces(text, out removedCount);

        Console.WriteLine("Бастапқы жол: [" + text + "]");
        Console.WriteLine("Нәтиже:       [" + result + "]");
         Console.WriteLine("Алынған бос орындар саны = " + removedCount);
    }

    // Қорғау: жолдағы бос орындарды алып тастау, олардың санын out арқылы қайтару
    static string RemoveSpaces(string text, out int removedCount)
    {
        string result = "";
        removedCount = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch !=  ' ') // бос орын емес болса, қосамыз 
                result += ch;
            else
                removedCount++;        }
        return result;
    }
}
