using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService : IEmployeeService
{
   List<Employee> employees = new List<Employee>();
   RepositoryManager mgr = new RepositoryManager();
   string fileName = @"F:\DotNet\HRSolution\employees.json";
   public EmployeeService()
   {
      employees = mgr.DeSerialize(fileName);
   }
   public List<Employee> GetAll()
   {
      return employees;
   }
   public void Insert(Employee emp)
   {
      employees.Add(emp);
      mgr.Serialize(employees, fileName);
   }
   public Employee? GetById(int id)
   {
      foreach (Employee e in employees)
      {
         if (e.Id == id)
         {
            return e;
         }
      }
      return null;
   }
   public void Update(Employee emp)
   {

   }

   public void UpdateList(List<Employee> list)
   {
      mgr.Serialize(list, fileName);
   }
   public void Delete(int id)
   {
      Employee em = employees.Find(p => p.Id == id);
      employees.Remove(em);
      mgr.Serialize(employees, fileName);
   }

}