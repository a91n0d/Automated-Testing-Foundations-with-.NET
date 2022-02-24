using System;
using System.Text;

namespace Development_and_build_tools
{
    class Program
    {
        //Написать программу, которая принимает из командной строки последовательность символов(строку)
        //в качестве аргумента и выводит в консоль максимальное количество неодинаковых последовательных символов в строке.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность символов: ");
            string str = Console.ReadLine();
            while (str.Length == 0)
            {
                Console.WriteLine("Вы ввели пустую строку, попробуйте еще раз: ");
                str = Console.ReadLine();
            }            
            int len = str.Length;
            var sb = new StringBuilder();
            string maxUnequalChar = string.Empty;
            for (int i = 0; i < len; i++)
            {
                if (sb.Length == 0 || str[i] != sb[sb.Length - 1])
                {
                    sb.Append(str[i]);
                }
                else
                {
                    if (maxUnequalChar.Length < sb.Length)
                    {
                        maxUnequalChar = sb.ToString();                        
                    }
                    sb.Clear();
                    sb.Append(str[i]);
                }

                if (i == len - 1 && maxUnequalChar.Length < sb.Length)
                {
                    maxUnequalChar = sb.ToString();
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Максимальное количество неодинаковых последовательных символов в строке: {maxUnequalChar}");
        }
    }
}
