using System;

namespace GuessNumber_MultiTable_DivizorsOfNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Игра Угадай число\n" +
                              "2. Таблица умножения\n" +
                              "3. Вывод делителей числа\n" +
                              "4. Закончить программу");
            Console.WriteLine("Введите операцию, котороую хотите выполнить");
            int menureader = Convert.ToInt32(Console.ReadLine());
            if (menureader == 1)
            {
                GuessTheNumber(args);
            }

            if (menureader == 2)
            {
                MultiTable(args);
            }

            if (menureader == 3)
            {
                DivizorOfNum(args);
            }

            if (menureader == 4)
            {
                StopProgram(args);
            }
        }

        static void GuessTheNumber(string[] args)
        {
            int randomnum = new Random().Next(100);
            Console.WriteLine("Компьютер загадал число от 0 до 100\n" +
                              "Угадай это число!");
            bool winres = true;
            do
            {
                Console.WriteLine("Введите число:");
                int guessnum = Convert.ToInt32(Console.ReadLine());
                if (guessnum < randomnum)
                {
                    Console.WriteLine("Нужно больше");
                }
                if (guessnum > randomnum)
                {
                    Console.WriteLine("Нужно меньше");
                }
                if (guessnum == randomnum)
                {
                    Console.WriteLine("Вы победили!");
                    winres = false;
                    Main(args);
                }
            } while (winres == true);
        }
        static void MultiTable(string[] args)
        {
            int length = 9;
            int height = 9;
            int[,] myltitable = new int[10, 10];
            for (int i = 1; i <= length; i++)
            {
                for (int a = 1; a <= height; a++)
                {
                    myltitable[i, a] = i * a;
                }
            }
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine();
                for (int a = 1; a <= height; a++)
                {
                    Console.Write("{0,3}", myltitable[i, a]);
                }
            }
            Console.WriteLine();
            Main(args);
        }
        static void DivizorOfNum(string[] args)
        {
            bool begindiv = true;
            do
            {
                Console.WriteLine("Введите число");
                int numreader = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= numreader; i++)
                {
                    if (numreader % i == 0)
                    {

                        Console.Write(i + "\t");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Чтобы ввести еще одно число для вывода делителей, введите любую цифру\n"+
                                  "Чтобы выйти в меню введите 'выйти'");

                string stopdiv = Convert.ToString(Console.ReadLine());

                if(stopdiv == "выйти")
                {
                    begindiv = false;
                    Console.WriteLine();
                    Main(args);
                }
              
            } while(begindiv == true);
        }

        static void StopProgram(string[] args)
        {
            Console.WriteLine("Вы закончили программу");
        }
    }
}