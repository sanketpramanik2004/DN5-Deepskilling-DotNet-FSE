public class StudentView
{
    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Id: {student.Id}");
        Console.WriteLine($"Grade: {student.Grade}");
    }
}