// Задание 2.1. Прямая.
// Создать класс линии, заданной начальной и конечной
// точками. Проверить изменение координат и ссылок
// на точки.

namespace Lab2;

internal class Line
{
    private Point _start;
    private Point _end;

    public Point Start
    {
        get
        {
            return _start;
        }
        set
        {
            _start = value;
        }
    }

    public Point End
    {
        get
        {
            return _end;
        }
        set
        {
            _end = value;
        }
    }

    public Line(Point start, Point end)
    {
        _start = start;
        _end = end;
    }

    public override string ToString()
    {
        return "Линия от " + Start +
            " до " + End;
    }
}
