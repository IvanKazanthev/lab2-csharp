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
        ShowCityConstructor();
        ShowFractions();
    }

    static void ShowPoints()
    {
        Console.WriteLine("ЗАДАНИЕ 1.1 — ТОЧКИ");

        Point p1 = ReadPoint("Первая точка");
        Point p2 = ReadPoint("Вторая точка");
        Point p3 = ReadPoint("Третья точка");

        Console.WriteLine("Первая: " + p1);
        Console.WriteLine("Вторая: " + p2);
        Console.WriteLine("Третья: " + p3);
        Console.WriteLine();
    }

    static void ShowNames()
    {
        Console.WriteLine("ЗАДАНИЕ 1.3 — ИМЕНА");

        string first;
        string surname;
        string patronymic;

        first = ReadText("Имя Клеопатры");
        Name n1 = new Name("", first, "");

        surname = ReadText("Фамилия Пушкина");
        first = ReadText("Имя Пушкина");
        patronymic = ReadText("Отчество Пушкина");

        Name n2 = new Name(surname, first, patronymic);

        surname = ReadText("Фамилия Маяковского");
        first = ReadText("Имя Маяковского");

        Name n3 = new Name(surname, first, "");

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine();
    }

    static void ShowLines()
    {
        Console.WriteLine("ЗАДАНИЕ 2.1 — ЛИНИИ");

        Console.WriteLine("Введите начало линии 1.");
        Point p1 = ReadPoint("Начальная точка");

        Console.WriteLine("Введите конец линии 1.");
        Point p2 = ReadPoint("Конечная точка");

        Console.WriteLine("Введите начало линии 2.");
        Point p3 = ReadPoint("Начальная точка");

        Console.WriteLine("Введите конец линии 2.");
        Point p4 = ReadPoint("Конечная точка");

        Line l1 = new Line(p1, p2);
        Line l2 = new Line(p3, p4);
        Line l3 = new Line(l1.Start, l2.End);

        Console.WriteLine("До изменений:");
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        Console.WriteLine("Изменяем координаты точек.");

        l1.Start.X = ReadNumber("Новое X начала линии 1");
        l1.Start.Y = ReadNumber("Новое Y начала линии 1");
        l2.End.X = ReadNumber("Новое X конца линии 2");
        l2.End.Y = ReadNumber("Новое Y конца линии 2");

        Console.WriteLine("После изменений:");
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        Console.WriteLine("Заменяем начало линии 1.");

        double x = ReadNumber("Новый X");
        double y = ReadNumber("Новый Y");

        l1.Start = new Point(x, y);

        Console.WriteLine("Линия 1: " + l1);
        Console.WriteLine("Линия 3: " + l3);
        Console.WriteLine();
    }

    static void ShowCities()
    {
        Console.WriteLine("ЗАДАНИЕ 3.3 — ГОРОДА");

        City a = new City("A");
        City b = new City("B");
        City c = new City("C");
        City d = new City("D");
        City e = new City("E");
        City f = new City("F");

        a.SetPaths(
            new City[] { f, d },
            new int[] { 1, 6 }
        );

        b.SetPaths(
            new City[] { a, c },
            new int[] { 5, 3 }
        );

        c.SetPaths(
            new City[] { d },
            new int[] { 4 }
        );

        d.SetPaths(
            new City[0],
            new int[0]
        );

        e.SetPaths(
            new City[] { d },
            new int[] { 2 }
        );

        f.SetPaths(
            new City[] { b, e },
            new int[] { 1, 2 }
        );

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine();
    }

    static void ShowCityConstructor()
    {
        Console.WriteLine("ЗАДАНИЕ 4.8 — СОЗДАНИЕ ГОРОДА");

        string name = ReadText("Название нового города");
        int count = ReadInteger("Количество путей", 0, 5);

        City[] destinations = new City[count];
        int[] costs = new int[count];

        for (int i = 0; i < count; i++)
        {
            string destinationName =
                ReadText("Название города назначения");

            destinations[i] = new City(destinationName);

            costs[i] = ReadInteger(
                "Стоимость пути",
                1,
                1000000
            );
        }

        City city = new City(name, destinations, costs);

        Console.WriteLine("Созданный город:");
        Console.WriteLine(city);
        Console.WriteLine();
    }

    static void ShowFractions()
    {
        Console.WriteLine("ЗАДАНИЕ 5.5 — ДРОБИ");

        int n1 = ReadInteger("Числитель f1", -1000000, 1000000);
        int d1 = ReadInteger("Знаменатель f1", -1000000, 1000000);

        while (d1 == 0)
        {
            Console.WriteLine("Знаменатель не может быть нулём.");
            d1 = ReadInteger(
                "Введите знаменатель f1",
                -1000000,
                1000000
            );
        }

        int n2 = ReadInteger("Числитель f2", -1000000, 1000000);
        int d2 = ReadInteger("Знаменатель f2", -1000000, 1000000);

        while (d2 == 0)
        {
            Console.WriteLine("Знаменатель не может быть нулём.");
            d2 = ReadInteger(
                "Введите знаменатель f2",
                -1000000,
                1000000
            );
        }

        int n3 = ReadInteger("Числитель f3", -1000000, 1000000);
        int d3 = ReadInteger("Знаменатель f3", -1000000, 1000000);

        while (d3 == 0 || n3 == 0)
        {
            Console.WriteLine("Дробь f3 не должна быть нулём.");

            n3 = ReadInteger(
                "Введите числитель f3",
                -1000000,
                1000000
            );

            d3 = ReadInteger(
                "Введите знаменатель f3",
                -1000000,
                1000000
            );
        }

        Fraction f1 = new Fraction(n1, d1);
        Fraction f2 = new Fraction(n2, d2);
        Fraction f3 = new Fraction(n3, d3);

        Console.WriteLine(
            f1 + " + " + f2 + " = " + f1.sum(f2)
        );

        Console.WriteLine(
            f1 + " - " + f2 + " = " + f1.minus(f2)
        );

        Console.WriteLine(
            f1 + " * " + f2 + " = " + f1.mult(f2)
        );

        if (f2.Numerator != 0)
        {
            Console.WriteLine(
                f1 + " / " + f2 + " = " + f1.div(f2)
            );
        }
        else
        {
            Console.WriteLine("Деление на нулевую дробь нельзя.");
        }

        int number = ReadInteger(
            "Введите целое число",
            -1000000,
            1000000
        );

        Console.WriteLine(
            f1 + " + " + number + " = " + f1.sum(number)
        );

        Console.WriteLine(
            f1 + " - " + number + " = " + f1.minus(number)
        );

        Console.WriteLine(
            f1 + " * " + number + " = " + f1.mult(number)
        );

        if (number != 0)
        {
            Console.WriteLine(
                f1 + " / " + number + " = " + f1.div(number)
            );
        }
        else
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }

        Fraction result = f1.sum(f2).div(f3).minus(5);

        Console.WriteLine(
            "f1.sum(f2).div(f3).minus(5) = " + result
        );

        Console.WriteLine();
    }

    static Point ReadPoint(string message)
    {
        Console.WriteLine(message);

        double x = ReadNumber("X");
        double y = ReadNumber("Y");

        return new Point(x, y);
    }

    static double ReadNumber(string message)
    {
        double number;

        Console.Write(message + ": ");

        while (!double.TryParse(
            Console.ReadLine(),
            out number))
        {
            Console.Write("Ошибка! Введите число: ");
        }

        return number;
    }

    static int ReadInteger(
        string message,
        int min,
        int max)
    {
        int number;

        Console.Write(message + ": ");

        while (!int.TryParse(
            Console.ReadLine(),
            out number)
            || number < min
            || number > max)
        {
            Console.Write(
                "Введите целое число от " +
                min + " до " + max + ": "
            );
        }

        return number;
    }

    static string ReadText(string message)
    {
        string text;

        Console.Write(message + ": ");
        text = Console.ReadLine();

        while (text == null || text.Trim() == "")
        {
            Console.Write("Поле не должно быть пустым: ");
            text = Console.ReadLine();
        }

        return text;
    }
}
