using System;

namespace MyApp
{
    internal class Program
    {
        static int StringToInt(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                result = result + (text[text.Length - i - 1] - 48) * Power(10, i);
            }
            return result;
        }

        static int Power(int basis, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * basis;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int a = StringToInt("123");
            Console.WriteLine(a);
        }
    }
}