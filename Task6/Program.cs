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

        string result = RemoveDigits(text);

        Console.WriteLine("Бастапқы жол: [" + text + "]");
        Console.WriteLine("Нәтиже:       [" + result + "]");
    }

    // 2-нұсқа: жолдағы цифрларды алып тастау
    static string RemoveDigits(string text)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch < '0' || ch > '9') // цифр емес болса, қосамыз ('0'..'9' символдары)
                result += ch;
        }
        return result;
    }
}
