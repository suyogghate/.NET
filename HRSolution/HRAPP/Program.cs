using HRAPP.Entities;
using HRAPP.Services;
using HRAPP.Controllers;
using HRAPP.Views;


// Console.WriteLine("Welcome to MVC in C#");
//new Employee{Id=1, Name="Shivam"}
IEmployeeService svc = new EmployeeService();
EmployeesController controller = new EmployeesController(svc);
bool flag = true;
while (flag)
{
    Console.WriteLine("Choose your option: ");
    Console.WriteLine("1. Display all employees \n2. Add new Employee \n3. Find employee by id \n4. Update employee details \n5. Delete employee details \n6. Exit");
    var choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            List<Employee> model = controller.GetAll();
            ListView view = new ListView(model);
            view.Render();
            break;
        case 2://Add
            Console.WriteLine("Enter id, name, salary, DA and IT of employee:");
            var id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            var sal = double.Parse(Console.ReadLine());
            var da = double.Parse(Console.ReadLine());
            var it = double.Parse(Console.ReadLine());
            Employee emp = new Employee(id, name, sal, da, it);
            controller.Insert(emp);
            break;
        case 3://find by id
            Console.WriteLine("Enter employee id to search: ");
            int empid = int.Parse(Console.ReadLine());
            Employee? em = controller.GetById(empid);
            if (em.Id > 0)
            {
                DetailsView details = new DetailsView(em);
                details.Render();
            }
            break;
        case 4://update
            Console.WriteLine("Enter ID for updation: ");
            int id1 = int.Parse(Console.ReadLine());
            List<Employee> listemp = controller.GetAll();
            foreach (Employee empl in listemp)
            {
                if (empl.Id == id1)
                {
                    Console.WriteLine("Enter new ID and Name");
                    empl.Id = int.Parse(Console.ReadLine()); 
                    empl.Name = Console.ReadLine();
                }
            }
            controller.UpdateList(listemp);
            break;
        case 5://delete
            Console.WriteLine("Enter emp id to delete: ");
            int empid2 = int.Parse(Console.ReadLine());
            controller.Delete(empid2);
            Console.WriteLine("Employee details deleted successfully!!!");
            break;
        case 6:
            Console.WriteLine("Bye!");
            flag = false;
            break;
        default:
            Console.WriteLine("Please choose correct choice!!");
            break;
    };
}