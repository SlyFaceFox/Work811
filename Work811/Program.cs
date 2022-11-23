using System;
using System.Runtime.CompilerServices;

public class Mainclass
{
    public static void Main()
    {
        int num = 0;
        int[,] a = new int[12, 3];
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i, j] = random.Next(10000);
            }
        }
        Console.WriteLine("Работник\tМесяц");
        Console.WriteLine(" \t  1\t  2\t  3");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i} \t {a[i - 1, 0]} \t {a[i - 1, 1]}\t {a[i - 1, 2]}");

        }
        restart:

        Console.WriteLine("");
        Console.WriteLine("Выберите команду:");
        Console.WriteLine("1) Общую сумму, выплаченную за квартал всем работникам;");
        Console.WriteLine("2) Зарплату, полученную за квартал каждым работником;");
        Console.WriteLine("3) Общую зарплату всех работников за каждый месяц.");
        Console.WriteLine("Введите номер:...");

        num = int.Parse(Console.ReadLine());
        if (num < 1 || num > 3)
        {
            Console.WriteLine("Такой операции не существует,повтирите выбор;");
            goto restart;
        }
        if (num == 1)
        {
            int sum = a.Cast<int>().Sum();
            Console.WriteLine("");
            Console.WriteLine("Общая сумма, выплаченная за квартал всем работникам:");
            Console.WriteLine(sum);
            Console.WriteLine("");
            goto restart;
        }
        if (num == 2)
        {
            int IS = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        IS = IS + a[i, 0] + a[i, 1] + a[i, 2];
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"Зарплата работника {i + 1} за квартал составила {IS} руб.");
                    Console.WriteLine("");
                    goto restart;
                }
            }



        }
        if (num == 3)
        {
            int Month1 = 0;
            int Month2 = 0;
            int Month3 = 0;
            for (int i = 0; i < 12; i++)
            {
                Month1 += a[i, 0];
                if (i >= 11)
                {
                    for (i = 0; i < 12; i++)
                    {
                        Month2 += a[i, 1];
                        if (i >= 11)
                        {
                            for (i = 0; i < 12; i++)
                            {
                                Month3 += a[i, 2];
                            }
                        }
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Зарплата всех работников за первый месяц составила {Month1} руб.");
            Console.WriteLine($"Зарплата всех работников за второй месяц составила {Month2} руб.");
            Console.WriteLine($"Зарплата всех работников за третий месяц составила {Month3} руб.");
            Console.WriteLine("");
            goto restart;

        }



    }
}
            

    
    

