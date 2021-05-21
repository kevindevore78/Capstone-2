using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Classes
{
    class Employee
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }//constant 60,000 by default
        public Department Department { get; set; }
        public string HireDate { get; set; }
        public string FullName
        {
            get
            {
                return this.FirstName + this.LastName;
            }
        }

        public Employee (long employeeId, string firstName, string lastName, string email, Department department, string hireDate)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Department = department;//might work?
            this.HireDate = hireDate;
        }

        public Employee()
        {
            
        }

        public double RaiseSalary(double percent)
        {
            double raisedSalary;
            raisedSalary = (this.Salary * percent) + this.Salary;
            return raisedSalary;
        }
    }
}
