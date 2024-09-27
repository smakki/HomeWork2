using System;

namespace HomeWork2
{
    internal class Program
    {

        const char sym = '+';

        static void Main(string[] args)
        {
            Console.WriteLine("Введите тольщину рамки число от 1 до 6");
            var border = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите выводимый текст");
            var Text = Console.ReadLine();

            WriteTable(border, Text);

        }

        public static void WriteTable(int N, string S)
        {
            if (N < 1 || N > 6) 
            { 
                Console.WriteLine("Число должно быть от 1 до 6"); 
                return; 
            }
            
            if (S.Length < 1) 
            { 
                Console.WriteLine("Нужно ввести строку"); 
                return; 
            }

            var Height = N * 2 + 1;
            var Width = Math.Min(S.Length + N * 2 + 2, 40);
            var Separator = new String(sym, Width);
            var MaxLenghtText = 40 - (N + 1) * 2;
            if (S.Length > MaxLenghtText)
            {
                S = S.Substring(0, MaxLenghtText);
            }
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(Separator);
                        PrintTable1(Height, Width, S);
                        break;
                    case 1:
                        Console.WriteLine(Separator);
                        PrintTable2(Height,Width);
                        break;
                    case 2:
                        Console.WriteLine(Separator);
                        PrintTable3(Width);
                        Console.WriteLine(Separator);
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void PrintTable1(int Height, int Width, string Text)
        {
            var emptyString = new String(' ', Width-2).PadLeft(Width - 1, sym).PadRight(Width, sym);
            var stringWithText = sym + new String(' ', (Width - Text.Length) / 2 - 1) + Text + new String(' ', (Width - Text.Length) / 2 - 1) + sym;
            for (int i = 0; i < Height; i++)
            {
                if (i != (Height - 1) / 2)
                {
                    Console.WriteLine(emptyString);
                }
                else
                {
                    Console.WriteLine(stringWithText);
                }
            }
        }

        public static void PrintTable2(int Height, int Width)
        {
            var y = 1;

            while (y < Height + 1)
            {
                var x = 1;
                while (x < Width + 1)
                {
                    Console.Write(x == 1 || x == Width || x % 2 == y % 2 ? sym : ' ');
                    x++;
                }

                Console.WriteLine();
                y++;
            }
        }

        public static void PrintTable3(int Width)
        {
            var xPoint1 = 2; var xPoint2 = Width - 1;
            var y = 1;
            do
            {
                var x = 1;
                do
                {
                    Console.Write(x == xPoint1 || x == xPoint2 || x == 1 || x == Width ? sym : ' ');
                    x++;
                }
                while (x < Width + 1);
                Console.WriteLine();
                y++;
                xPoint1++; xPoint2--;
            }
            while (y < Width - 1);
        }
    }
}
