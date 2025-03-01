namespace OOP;

public class Student : User
{
    public string StudentNumber { get; set; }

    public Student()
    {
        StudentNumber = string.Empty;
    }

    public Student(int id, string firstName, string lastName, string email, string password, string studentNumber)
        : base(id, firstName, lastName, email, password)
    {
        StudentNumber = studentNumber;
    }
}
