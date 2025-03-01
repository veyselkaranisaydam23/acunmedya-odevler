using OOP;

StudentManager studentManager = new StudentManager();

Student student1 = new Student(1, "Ahmet", "Yılmaz", "ahmet@mail.com", "123456", "S1234");
Student student2 = new Student(2, "Zeynep", "Demir", "zeynep@mail.com", "654321", "S5678");

studentManager.Add(student1);
studentManager.Add(student2);

Console.WriteLine("\nTüm Öğrenciler:");
foreach (var student in studentManager.GetList())
{
    Console.WriteLine($"{student.Id} - {student.FirstName} {student.Name}");
}

Console.WriteLine("\nÖğrenci Silme:");
studentManager.Delete(1);

Console.WriteLine("\nGüncel Öğrenci Listesi:");
foreach (var student in studentManager.GetList())
{
    Console.WriteLine($"{student.Id} - {student.FirstName} {student.Name}");
}
