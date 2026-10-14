
using System;

namespace Lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        ShowPoints();
        ShowNames();
        ShowLines();
        ShowCities();
        ShowFractions();
    }

    private static void ShowPoints()
    {
        Console.WriteLine("ЗАДАНИЕ 1.1 — ТОЧКИ");

        Point first = new Point(3, 5);
        Point second = new Point(25, 6);
        Point third = new Point(7, 8);

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine();
    }

    private static void ShowNames()
    {
        Console.WriteLine("ЗАДАНИЕ 1.3 — ИМЕНА");

        Name first = new Name("Клеопатра");
        Name second = new Name(
            "Пушкин", "Александр", "Сергеевич");
        Name third = new Name("Маяковский", "Владимир");

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine();
    }

    private static void ShowLines()
    {
        Console.WriteLine("ЗАДАНИЕ 2.1 — ЛИНИИ");

        Point start1 = new Point(1, 3);
        Point end1 = new Point(23, 8);
        Line line1 = new Line(start1, end1);

        Point start2 = new Point(5, 10);
        Point end2 = new Point(25, 10);
        Line line2 = new Line(start2, end2);

        Line line3 = new Line(line1.Start, line2.End);

        Console.WriteLine("До изменений:");
        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine(line3);

        line1.Start.X = 2;
        line1.Start.Y = 4;
        line2.End.X = 30;

        Console.WriteLine();
        Console.WriteLine("После изменения координат:");
        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine(line3);

        line1.Start = new Point(100, 100);

        Console.WriteLine();
        Console.WriteLine("После замены начала линии 1:");
        Console.WriteLine(line1);
        Console.WriteLine(line3);
        Console.WriteLine();
    }

    private static void ShowCities()
    {
        Console.WriteLine("ЗАДАНИЕ 4.8 — ГОРОДА");

        City a = new City("A");
        City b = new City("B");
        City c = new City("C");
        City d = new City("D");
        City e = new City("E");
        City f = new City("F");

        a.SetPaths(
            new City[] { f },
            new int[] { 1 });

        b.SetPaths(
            new City[] { a },
            new int[] { 5 });

        c.SetPaths(
            new City[] { b, d },
            new int[] { 3, 4 });

        d.SetPaths(
            new City[] { a, e },
            new int[] { 6, 2 });

        e.SetPaths(
            new City[] { f },
            new int[] { 2 });

        f.SetPaths(
            new City[] { b },
            new int[] { 1 });

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine();
    }

    private static void ShowFractions()
    {
        Console.WriteLine("ЗАДАНИЕ 5.5 — ДРОБИ");

        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction(2, 3);
        Fraction f3 = new Fraction(1, 2);

        Console.WriteLine($"{f1} + {f2} = {f1.sum(f2)}");
        Console.WriteLine($"{f1} - {f2} = {f1.minus(f2)}");
        Console.WriteLine($"{f1} * {f2} = {f1.mult(f2)}");
        Console.WriteLine($"{f1} / {f2} = {f1.div(f2)}");

        Console.WriteLine($"{f1} + 2 = {f1.sum(2)}");
        Console.WriteLine($"{f1} - 2 = {f1.minus(2)}");
        Console.WriteLine($"{f1} * 2 = {f1.mult(2)}");
        Console.WriteLine($"{f1} / 2 = {f1.div(2)}");

        Fraction result = f1.sum(f2).div(f3).minus(5);

        Console.WriteLine();
        Console.WriteLine(
            "f1.sum(f2).div(f3).minus(5) = " + result);
        Console.WriteLine();
    }
}
