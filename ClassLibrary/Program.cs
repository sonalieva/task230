using System;
using ClassLibrary;
namespace ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Aziz";
            employee.Surname = "Aliev";
            employee.Salary = 340;

            Employee employee1 = new Employee();
            employee1.Name = "Sugra";
            employee1.Surname = "Alhuseinova";
            employee1.Salary = 3000;


            Employee employee2 = new Employee();
            employee2.Name = "Adem";
            employee2.Surname = "Ali";
            employee2.Salary = 4000;

            Department department = new Department();
            department.EmployeeLimit = 3;
            department.AddEmployee(employee);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            foreach (var item in department.Employees)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }

        }
    }
    
}
