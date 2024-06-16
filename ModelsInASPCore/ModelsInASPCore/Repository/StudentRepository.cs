using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> GetAllStudent()
        {
            return DataSource();
        }

        public Student GetStudentById(int id)
        {
            return DataSource().Where(x => x.RollNo == id).FirstOrDefault();
        }

        private List<Student> DataSource()
        {
            return new List<Student>
            {
                new Student {RollNo = 1, Name="Suyog", Gender = "Male", Standard = 12},
                new Student {RollNo = 2, Name="Neha", Gender = "Female", Standard = 11},
                new Student {RollNo = 3, Name="Natasha", Gender = "Female", Standard = 11},
                new Student {RollNo = 4, Name="Amrit", Gender = "Female", Standard = 10}
            };
        }
    }
}
