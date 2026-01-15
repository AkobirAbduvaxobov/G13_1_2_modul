using _2._5_dars.Models;

namespace _2._5_dars.Services;

public class StudentService : IStudentService
{
    List<Student> Students;
    public StudentService()
    {
        Students = new List<Student>();
    }

    public Guid AddStudent(Student student)
    {
        student.StudentId = Guid.NewGuid();
        Students.Add(student);
        return student.StudentId;
    }

    public bool DeleteStudent(Guid studentId)
    {
        foreach (var student in Students)
        {
            if (student.StudentId == studentId)
            {
                Students.Remove(student);
                return true;
            }
        }
        return false;
    }

    public List<Student> GetAllStudents()
    {
        return Students;
    }

    public Student? GetStudentById(Guid studentId)
    {
        foreach (var student in Students)
        {
            if (student.StudentId == studentId)
            {
                return student;
            }
        }

        return null;
    }

    public bool UpdateStudent(Student updatingStudent)
    {
        foreach (var student in Students)
        {
            if (student.StudentId == student.StudentId)
            {
                student.FirstName = updatingStudent.FirstName;
                student.LastName = updatingStudent.LastName;
                student.DateOfBirth = updatingStudent.DateOfBirth;
            }
            return true;
        }
        return false;
    }
}
