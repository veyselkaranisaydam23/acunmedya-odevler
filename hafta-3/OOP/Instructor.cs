namespace OOP;

public class Instructor : User
{
    public string Department { get; set; }

    public Instructor()
    {
        Department = string.Empty;
    }

    public Instructor(int id, string firstName, string lastName, string email, string password, string department)
        : base(id, firstName, lastName, email, password)
    {
        Department = department;
    }
}
