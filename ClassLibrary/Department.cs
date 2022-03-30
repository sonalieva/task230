using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Department
    {
        public Department()
        {
            this.Employees = new Employee[0];
        }
        public string Name;
        private int _employeeLimit;
        public int SalaryLimit;
        public int EmployeeLimit
        {
            get
            {
                return _employeeLimit;
            }
            set
            {
                _employeeLimit = value;
            }
        }
        public Employee[] Employees;
        public void AddEmployee(Employee employee)
        {
            if (this.EmployeeLimit > this.Employees.Length)
            {
                Array.Resize(ref this.Employees, this.Employees.Length + 1);
                this.Employees[this.Employees.Length - 1] = employee;

            }
        }
    }
}
