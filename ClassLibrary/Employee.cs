using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 250)
                    _salary = value;

            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(char.IsDigit(value[i]) && char.IsLower(value[0])))
                        _name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(char.IsDigit(value[i]) && char.IsLower(value[0])))
                        _surname = value;
                }
            }
        }
    }
}
