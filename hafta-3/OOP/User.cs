namespace OOP;

public class User : BaseEntity<int>
{
    public string FirstName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User()
    {
        FirstName = string.Empty;
        Name = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
    }

    public User(int id, string firstName, string name, string email, string password)
    {
        Id = id;
        FirstName = firstName;
        Name = name;
        Email = email;
        Password = password;
    }
}
