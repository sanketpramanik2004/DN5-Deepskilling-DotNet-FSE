Student student = new Student();
student.Name = "Sanket";
student.Id = 1;
student.Grade = "A";

StudentView view = new StudentView();

StudentController controller = new StudentController(student, view);
controller.DisplayStudent();
controller.UpdateGrade("A+");

Console.WriteLine("After Update");

controller.DisplayStudent();