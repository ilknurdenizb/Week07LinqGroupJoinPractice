using System;
using Week07GroupJoinMain;
public class Program
{
    // This program demonstrates a group join operation using LINQ in C#.
    static void Main ()
    {   // Define the Student and Class Lists
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
        };
        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };
        // Perform a group join operation to group students by their classes
        var groupYoinResult = from c in classes
                              join s in students
                              on c.ClassId equals s.ClassId into studentGroup
                              select new
                              {
                                  ClassName = c.ClassName,
                                  Students = studentGroup

                              };
        // Display the results of the group join operation
        foreach (var item in groupYoinResult)
        {
            Console.WriteLine($"Class: {item.ClassName}");
            foreach (var student in item.Students)
            {
                Console.WriteLine($" - Student: {student.StudentName}");
            }
        }
    }
}