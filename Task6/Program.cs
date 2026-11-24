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
        Console.WriteLine("Алынған цифрлар саны = " + removedCount);
    }

    // 2-нұсқа: жолдағы цифрларды алып тастау, алынған цифрлар санын out арқылы қайтару
    static string RemoveSpaces(string text, out int removedCount)
    {
        string result = "";
        removedCount = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch !=  ' ') // цифр емес болса, қосамыз ('0'..'9' символдары)
                result += ch;
            else
                removedCount++;        }
        return result;
    }
}
