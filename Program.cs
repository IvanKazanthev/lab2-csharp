using System;

namespace Lab2;

internal class Program
{
    static void Main()
    {
        ShowPoints();
        ShowNames();
        ShowLines();
        ShowCities();
        ShowFractions();
    }

    static void ShowPoints()
    {
        Console.WriteLine("ЗАДАНИЕ 1.1 — ТОЧКИ");

        double x;
        double y;

        Console.Write("X первой точки: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y первой точки: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p1 = new Point(x, y);

        Console.Write("X второй точки: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y второй точки: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p2 = new Point(x, y);

        Console.Write("X третьей точки: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y третьей точки: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p3 = new Point(x, y);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }

    static void ShowNames()
    {
        Console.WriteLine("\nЗАДАНИЕ 1.3 — ИМЕНА");

        string first;
        string surname;
        string patronymic;

        Console.Write("Имя первого человека: ");
        first = Console.ReadLine();

        while (first == null || first.Trim() == "")
        {
            Console.Write("Ошибка! Введите имя: ");
            first = Console.ReadLine();
        }

        Name n1 = new Name(first);

        Console.Write("Фамилия второго человека: ");
        surname = Console.ReadLine();

        while (surname == null || surname.Trim() == "")
        {
            Console.Write("Ошибка! Введите фамилию: ");
            surname = Console.ReadLine();
        }

        Console.Write("Имя второго человека: ");
        first = Console.ReadLine();

        while (first == null || first.Trim() == "")
        {
            Console.Write("Ошибка! Введите имя: ");
            first = Console.ReadLine();
        }

        Console.Write("Отчество второго человека: ");
        patronymic = Console.ReadLine();

        while (patronymic == null || patronymic.Trim() == "")
        {
            Console.Write("Ошибка! Введите отчество: ");
            patronymic = Console.ReadLine();
        }

        Name n2 = new Name(surname, first, patronymic);

        Console.Write("Фамилия третьего человека: ");
        surname = Console.ReadLine();

        while (surname == null || surname.Trim() == "")
        {
            Console.Write("Ошибка! Введите фамилию: ");
            surname = Console.ReadLine();
        }

        Console.Write("Имя третьего человека: ");
        first = Console.ReadLine();

        while (first == null || first.Trim() == "")
        {
            Console.Write("Ошибка! Введите имя: ");
            first = Console.ReadLine();
        }

        Name n3 = new Name(surname, first);

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
    }

    static void ShowLines()
    {
        Console.WriteLine("\nЗАДАНИЕ 2.1 — ЛИНИИ");

        double x;
        double y;

        Console.Write("X начала линии 1: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y начала линии 1: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p1 = new Point(x, y);

        Console.Write("X конца линии 1: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y конца линии 1: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p2 = new Point(x, y);
        Line l1 = new Line(p1, p2);

        Console.Write("X начала линии 2: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y начала линии 2: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p3 = new Point(x, y);

        Console.Write("X конца линии 2: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Console.Write("Y конца линии 2: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        Point p4 = new Point(x, y);
        Line l2 = new Line(p3, p4);
        Line l3 = new Line(l1.Start, l2.End);

        Console.WriteLine("До изменений:");
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        l1.Start.X = ReadLineCoordinate(
            "Новое X начала линии 1: ");
        l1.Start.Y = ReadLineCoordinate(
            "Новое Y начала линии 1: ");
        l2.End.X = ReadLineCoordinate(
            "Новое X конца линии 2: ");

        Console.WriteLine("После изменения координат:");
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        x = ReadLineCoordinate("X новой точки начала: ");
        y = ReadLineCoordinate("Y новой точки начала: ");

        l1.Start = new Point(x, y);

        Console.WriteLine("После замены точки:");
        Console.WriteLine(l1);
        Console.WriteLine(l3);
    }

    static double ReadLineCoordinate(string message)
    {
        double value;

        Console.Write(message);
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        return value;
    }

    static void ShowCities()
    {
        Console.WriteLine("\nЗАДАНИЕ 3.3 И 4.8 — ГОРОДА");

        City[] cities = new City[6];
        string[] names = { "A", "B", "C", "D", "E", "F" };

        for (int i = 0; i < cities.Length; i++)
        {
            cities[i] = new City(names[i]);
        }

        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine("\nПути из " + names[i]);

            int count;
            Console.Write("Количество путей (0-5): ");

            while (!int.TryParse(Console.ReadLine(), out count)
                || count < 0 || count > 5)
            {
                Console.Write("Введите число от 0 до 5: ");
            }

            City[] destinations = new City[count];
            int[] costs = new int[count];

            for (int j = 0; j < count; j++)
            {
                Console.WriteLine("Города назначения:");

                for (int k = 0; k < cities.Length; k++)
                {
                    Console.WriteLine(k + " - " + names[k]);
                }

                int index;
                Console.Write("Индекс города: ");

                while (!int.TryParse(Console.ReadLine(), out index)
                    || index < 0 || index > 5)
                {
                    Console.Write("Введите индекс от 0 до 5: ");
                }

                destinations[j] = cities[index];

                Console.Write("Стоимость пути: ");
                while (!int.TryParse(
                    Console.ReadLine(), out costs[j])
                    || costs[j] <= 0)
                {
                    Console.Write(
                        "Введите положительное число: ");
                }
            }

            cities[i].SetPaths(destinations, costs);
        }

        Console.WriteLine("\nСписок городов:");

        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine(cities[i]);
        }

        Console.WriteLine("\nВторой конструктор City.");

        string extraName;
        Console.Write("Название дополнительного города: ");
        extraName = Console.ReadLine();

        while (extraName == null || extraName.Trim() == "")
        {
            Console.Write("Ошибка! Введите название: ");
            extraName = Console.ReadLine();
        }

        int destination;
        Console.Write("Индекс города назначения (0-5): ");

        while (!int.TryParse(Console.ReadLine(), out destination)
            || destination < 0 || destination > 5)
        {
            Console.Write("Введите индекс от 0 до 5: ");
        }

        int cost;
        Console.Write("Стоимость пути: ");

        while (!int.TryParse(Console.ReadLine(), out cost)
            || cost <= 0)
        {
            Console.Write("Введите положительное число: ");
        }

        City extra = new City(extraName);
        extra.SetPaths(
            new City[] { cities[destination] },
            new int[] { cost });

        Console.WriteLine(extra);
    }

    static void ShowFractions()
    {
        Console.WriteLine("\nЗАДАНИЕ 5.5 — ДРОБИ");

        int n1;
        int d1;
        int n2;
        int d2;
        int n3;
        int d3;

        Console.Write("Числитель первой дроби: ");
        while (!int.TryParse(Console.ReadLine(), out n1))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }

        Console.Write("Знаменатель первой дроби: ");
        while (!int.TryParse(Console.ReadLine(), out d1)
            || d1 == 0)
        {
            Console.Write("Знаменатель не может быть нулём: ");
        }

        Console.Write("Числитель второй дроби: ");
        while (!int.TryParse(Console.ReadLine(), out n2))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }

        Console.Write("Знаменатель второй дроби: ");
        while (!int.TryParse(Console.ReadLine(), out d2)
            || d2 == 0)
        {
            Console.Write("Знаменатель не может быть нулём: ");
        }

        Console.Write("Числитель третьей дроби: ");
        while (!int.TryParse(Console.ReadLine(), out n3)
            || n3 == 0)
        {
            Console.Write("Числитель не может быть нулём: ");
        }

        Console.Write("Знаменатель третьей дроби: ");
        while (!int.TryParse(Console.ReadLine(), out d3)
            || d3 == 0)
        {
            Console.Write("Знаменатель не может быть нулём: ");
        }

        Fraction f1 = new Fraction(n1, d1);
        Fraction f2 = new Fraction(n2, d2);
        Fraction f3 = new Fraction(n3, d3);

        Console.WriteLine(
            f1 + " + " + f2 + " = " + f1.sum(f2));
        Console.WriteLine(
            f1 + " - " + f2 + " = " + f1.minus(f2));
        Console.WriteLine(
            f1 + " * " + f2 + " = " + f1.mult(f2));

        if (f2.Numerator != 0)
        {
            Console.WriteLine(
                f1 + " / " + f2 + " = " + f1.div(f2));
        }
        else
        {
            Console.WriteLine("На нулевую дробь делить нельзя.");
        }

        int number;
        Console.Write("Введите целое число: ");

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }

        Console.WriteLine(
            f1 + " + " + number + " = " + f1.sum(number));
        Console.WriteLine(
            f1 + " - " + number + " = " + f1.minus(number));
        Console.WriteLine(
            f1 + " * " + number + " = " + f1.mult(number));

        if (number != 0)
        {
            Console.WriteLine(
                f1 + " / " + number + " = " + f1.div(number));
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя.");
        }

        Fraction result = f1.sum(f2).div(f3).minus(5);

        Console.WriteLine(
            "f1.sum(f2).div(f3).minus(5) = " + result);
    }
}
