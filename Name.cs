
namespace Lab2;

internal class Name
{
    private string? surname;
    private string firstName;
    private string? patronymic;

    public string? Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    public string? Patronymic
    {
        get
        {
            return patronymic;
        }
        set
        {
            patronymic = value;
        }
    }

    public Name(string firstName)
    {
        this.firstName = firstName;
        surname = null;
        patronymic = null;
    }

    public Name(string surname, string firstName)
    {
        this.surname = surname;
        this.firstName = firstName;
        patronymic = null;
    }

    public Name(
        string surname,
        string firstName,
        string patronymic)
    {
        this.surname = surname;
        this.firstName = firstName;
        this.patronymic = patronymic;
    }

    public override string ToString()
    {
        string result = "";

        if (!string.IsNullOrWhiteSpace(surname))
        {
            result += surname + " ";
        }

        result += firstName;

        if (!string.IsNullOrWhiteSpace(patronymic))
        {
            result += " " + patronymic;
        }

        return result;
    }
}
