using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Department
    {
        string _name;
        int _employeeLimit;
        double _salaryLimit;
        Employee[] _employees;
        public string Name{ get { return _name; } set { _name = value; } }
        public int EmployeeLimit { get { return _employeeLimit; } 
            set 
            {
                if (_employeeLimit <= 270)
                {
                    _employeeLimit = value;
                }
                else
                {
                    Console.WriteLine("Isci limiti asib:");
                }
            } 
        }
        public double SalaryLimit { get { return _salaryLimit; } 
            set 
            {
                if (value <= 2000)
                {
                    _salaryLimit = value;
                }
            } 
        }
        public Employee[] Employees { get { return _employees; } 
            set 
            {
                _employees = value; 
            } 
        }

        public void AddEmployee(string employee)
        {
            Array.Resize(ref _employees, Employees.Length + 1);
            Employee[_employees.Length - 1] = employee;
        }
    }
}
