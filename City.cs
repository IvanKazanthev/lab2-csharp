// Задание 3.3. Города.
// Создать города и описать пути между ними,
// указав города назначения и стоимость путей.

namespace Lab2;

internal class City
{
    private string _name;
    private Path[] _paths;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public Path[] Paths
    {
        get
        {
            return _paths;
        }
        set
        {
            _paths = value;
        }
    }

    public City(string name)
    {
        _name = name;
        _paths = new Path[0];
    }

    public City(string name, Path[] paths)
    {
        _name = name;
        _paths = paths;
    }

    public City(string name, Path[] paths, int count)
    {
        _name = name;
        _paths = new Path[count];

        for (int i = 0; i < count; i++)
        {
            _paths[i] = paths[i];
        }
    }

    public void AddPath(City city, int cost)
    {
        Path[] newPaths = new Path[_paths.Length + 1];

        for (int i = 0; i < _paths.Length; i++)
        {
            newPaths[i] = _paths[i];
        }

        newPaths[_paths.Length] = new Path(city, cost);
        _paths = newPaths;
    }

    public void SetPaths(Path[] paths)
    {
        _paths = paths;
    }

    public override string ToString()
    {
        string result = _name + ": ";

        for (int i = 0; i < _paths.Length; i++)
        {
            result += _paths[i].ToString();

            if (i < _paths.Length - 1)
            {
                result += ", ";
            }
        }

        return result;
    }
}
