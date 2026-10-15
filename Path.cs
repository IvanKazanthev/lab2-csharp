// Задание 4.8. Создание городов.
// Дополнить класс города конструкторами,
// позволяющими создавать город по названию
// и по названию вместе с набором путей со стоимостью

namespace Lab2;

internal class Path
{
    private City _city;
    private int _cost;

    public City City
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }

    public int Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            _cost = value;
        }
    }

    public Path(City city, int cost)
    {
        _city = city;
        _cost = cost;
    }

    public override string ToString()
    {
        return City.Name + ":" + Cost;
    }
}
