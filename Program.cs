int o = 1;
while (o == 1)
{
    Console.WriteLine("выюерите действие: " +
        "\r\n 1. Игра \"Угадай число\"" +
        "\r\n 2. Таблица умножения" +
        "\r\n 3. Вывод делителей числа" +
        "\r\n 4. Выход из программы");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 1)
    {
        Random p = new Random();
        int a = p.Next(0, 100);
        while (o == 1)
        {
            Console.WriteLine("Введите число");
            int s = Convert.ToInt32(Console.ReadLine());
            if (a > s) { Console.WriteLine("загаданное число больше введенного"); }
            if (a < s) { Console.WriteLine("загаданное число меньше введенного"); }
            if (a == s)
            {
                Console.WriteLine("Вы угадали!");
                break;
            }
        }
    }
    else if (x == 2)
    {
        Console.WriteLine("таблица умножения:");
        for (int m = 1; m <= 9; m++)
        {
            for (int n = 1; n <= 9; n++)
            {
                Console.Write(m * n + "\t");
            }
            Console.WriteLine("\r\n");

        }

    }
    else if (x == 3)
    {
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("делители:");
        for (int s = a; a >0; a--)
        {
            if (s % a == 0)
            {
                Console.Write(a + ", ");
            }
        }
        Console.WriteLine("\r\n");
    }
    else if (x == 4) { break; }
    else { Console.WriteLine("error"); }
}