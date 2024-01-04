using System.Collections.Generic;
using System;
using Enroll;

List<Employee> emp = new List<Employee>();
Employee e1 = new Employee("Suyog", 1000.000, 2000.0000, 500.0000);
Employee e2 = new Employee("Yash", 1000444.000, 200.0000, 8000.0000);
Employee e3 = new Employee("Harsh", 400.000, 200000.0000, 100.0000);
emp.Add(e1); emp.Add(e2); emp.Add(e3);
bool flag = false;
while (!flag)
{
    Console.WriteLine("1.Show All Emp 2.Search emp by ID 3 Add Employee.\n 4.Remove by ID 5.Calculate sal by ID  6.Name with Sal 7.Exit");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            foreach (Employee em in emp)
            {
                Console.WriteLine(em);
            }
            break;
        case 2:
            Console.WriteLine("Enter ID to search Employee");
            int idt = int.Parse(Console.ReadLine());
            foreach (Employee em in emp)
            {
                if (idt == em.Id)
                {
                    Console.WriteLine(em);
                }
            }
            break;
        case 3:
            Console.WriteLine("Employee Name , Basic sal, DA, IT");
            emp.Add(new Employee(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
            break;
        case 4:
            Console.WriteLine("Enter Employee ID");
            int temp = int.Parse(Console.ReadLine());
               Employee sil=emp.Find(s=> s.Id==temp);
               emp.Remove(sil);
                break;
         case 5:
          Console.WriteLine("Enter ID to Calculate salary of Employee");
            int id8 = int.Parse(Console.ReadLine());
            foreach (Employee em in emp)
            {
                if (id8 == em.Id)
                {
                    Console.WriteLine(em.Name+" Net is "+em.ComputeSal());
                }
            }
            break;
        case 6:
            foreach (Employee em in emp)
            {
              Console.WriteLine(em.Name+" Net is "+em.ComputeSal());
            }
                    break;
        case 7:
                    flag = true;
                    break;
                }

            }
