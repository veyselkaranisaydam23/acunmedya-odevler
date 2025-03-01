namespace OOP;

public class StudentManager
{
    private List<Student> _students;

    public StudentManager()
    {
        _students = new List<Student>();
    }

    public void Add(Student student)
    {
        _students.Add(student);
        Console.WriteLine($"Öğrenci eklendi: {student.FirstName} {student.Name}");
    }

    public List<Student> GetList()
    {
        return _students;
    }

    public void Delete(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            _students.Remove(student);
            Console.WriteLine($"Öğrenci silindi: {student.FirstName} {student.Name}");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.");
        }
    }

    public Student GetById(int id)
    {
        return _students.FirstOrDefault(s => s.Id == id);
    }
}
