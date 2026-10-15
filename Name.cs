// Задание 1.3. Имена.
// Создать класс имени, содержащий фамилию, имя
// и отчество. Отсутствующие части имени не выводить.

namespace Lab2;

internal class Name
{
    private string _surname;
    private string _firstName;
    private string _patronymic;

    public Name(
        string surname,
        string firstName,
        string patronymic)
    {
        _surname = surname;
        _firstName = firstName;
        _patronymic = patronymic;
    }

    public override string ToString()
    {
        string result = "";

        if (_surname != "")
        {
            result = _surname;
        }

        if (_firstName != "")
        {
            if (result != "")
            {
                result += " ";
            }

            result += _firstName;
        }

        if (_patronymic != "")
        {
            if (result != "")
            {
                result += " ";
            }

            result += _patronymic;
        }

        return result;
    }
}
