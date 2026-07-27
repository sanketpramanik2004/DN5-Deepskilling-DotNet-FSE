public class StudentController
{
    private Student student;
    private StudentView view;
    public StudentController(Student s, StudentView v)
    {
        student = s;
        view = v;
    }
    public void UpdateName(string name)
    {
        student.Name = name;
    }
    public void UpdateGrade(string grade)
    {
        student.Grade = grade;
    }
    public void DisplayStudent()
    {
        view.DisplayStudentDetails(student);
    }
}