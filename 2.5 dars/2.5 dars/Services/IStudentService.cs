using _2._5_dars.Models;

namespace _2._5_dars.Services;

public interface IStudentService
{
    public Guid AddStudent(Student student);
    public bool UpdateStudent(Student student);
    public bool DeleteStudent(Guid studentId);
    public Student? GetStudentById(Guid studentId);
    public List<Student> GetAllStudents();
}
