
using System;

namespace Lab2;

internal class Line
{
    private Point start;
    private Point end;

    public Point Start
    {
        get
        {
            return start;
        }
        set
        {
            start = value
                ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public Point End
    {
        get
        {
            return end;
        }
        set
        {
            end = value
                ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public Line(Point start, Point end)
    {
        this.start = start
            ?? throw new ArgumentNullException(nameof(start));
        this.end = end
            ?? throw new ArgumentNullException(nameof(end));
    }

    public override string ToString()
    {
        return $"Линия от {Start} до {End}";
    }
}
