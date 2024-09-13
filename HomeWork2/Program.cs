using System;

namespace HomeWork2
{
    internal class Program
    {
        static readonly int Height = 7;
        static readonly char sym = '+';
        static int Width{ get;set; }
        static string Text { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите тольщину рамки число от 1 до 6");
            int border = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите выводимый текст");
            Text = Console.ReadLine();

            WriteTable(border, Text);

        }

        public static void WriteTable(int n, string s)
        {
            if (n <1 || n > 6) { Console.WriteLine("Число должно быть от 1 до 6"); return; }
            if (s.Length < 1) { Console.WriteLine("Нужно ввести строку"); return; }
            Width = Math.Min( s.Length + n*2,40);
            string separator = new String(sym, Width);
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(separator);
                        PrintTable1();
                        break;
                    case 1:
                        Console.WriteLine(separator);
                        PrintTable2();
                        break;
                    case 2:
                        Console.WriteLine(separator);
                        PrintTable3();
                        Console.WriteLine(separator);
                        break;
                }
            }
        Console.ReadKey();
        }

        public static void PrintTable1()
        {
            string emptyString = new String(' ', Width - 2).PadLeft(Width-1,sym).PadRight(Width,sym);
            string stringWithText = sym + new String(' ', (Width - Text.Length)/2-1) + Text + new String(' ', (Width - Text.Length) / 2 - 1) + sym;
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

        public static void PrintTable2()
        {
            int y = 1;
            
            while (y < Height+1)
            {
                int x = 1;
                while (x < Width+1)
                {
                    Console.Write(x==1||x==Width||x%2==y%2?sym:' ');
                    x++;
                }
                
                Console.WriteLine();
                y++;
            }
        }

        public static void PrintTable3()
        {
            int xPoint1 = 2; int xPoint2=Width-1;
            int y = 1;
            do
            {
                int x = 1;
                do
                {
                    Console.Write(x == xPoint1 || x == xPoint2 || x ==1 || x == Width ? sym : ' ');
                    x++;
                }
                while (x < Width + 1);
                Console.WriteLine();
                y++;
                xPoint1++;xPoint2--;
            }
            while (y< Width-1);
        }
    }
}
