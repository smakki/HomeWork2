using System;
using System.Linq.Expressions;

namespace HomeWork2
{
    internal class Program
    {
        static readonly int Height = 7;
        static readonly char symbol = '+';
        static int width{ get;set; }
        static string separator { get; set; }
        static string text { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите тольщину рамки число от 1 до 6");
            int border = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите выводимый текст");
            text = Console.ReadLine();

            WriteTable(border, text);

        }


        public static void WriteTable(int n, string s)
        {
            if (n <1 || n > 6) { Console.WriteLine("Число должно быть от 1 до 6"); return; }
            if (s.Length < 1) { Console.WriteLine("Нужно ввести строку"); return; }
            width = Math.Min( s.Length + n*2,40);
            string separator = new String(symbol, width);
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(separator);
                        function1();
                        break;
                    case 1:
                        Console.WriteLine(separator);
                        function2();
                        break;
                    case 2:
                        Console.WriteLine(separator);
                        function3();
                        Console.WriteLine(separator);
                        break;
                }
            }
        Console.ReadKey();
        }

        public static void function1()
        {
            string emptyString = new String(' ', width - 2).PadLeft(width-1,symbol).PadRight(width,symbol);
            string stringWithText = symbol + new String(' ', (width - text.Length)/2-1) + text + new String(' ', (width - text.Length) / 2 - 1) + symbol;
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

        public static void function2()
        {
            int y = 1;
            
            while (y < Height+1)
            {
                int x = 1;
                while (x < width+1)
                {
                    Console.Write(x==1||x==width||x%2==y%2?symbol:' ');
                    x++;
                }
                
                Console.WriteLine();
                y++;
            }
        }

        public static void function3()
        {
            int xPoint1 = 2; int xPoint2=width-1;
            int y = 1;
            do
            {
                int x = 1;
                do
                {
                    Console.Write(x == xPoint1 || x == xPoint2 || x ==1 || x == width ? symbol : ' ');
                    x++;
                }
                while (x < width + 1);
                Console.WriteLine();
                y++;
                xPoint1++;xPoint2--;
            }
            while (y< width-1); 
        }
    }
}
