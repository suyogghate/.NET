using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public interface IStudent
    {
        List<Student> GetAllStudent();

        Student GetStudentById(int id);
    }
}
