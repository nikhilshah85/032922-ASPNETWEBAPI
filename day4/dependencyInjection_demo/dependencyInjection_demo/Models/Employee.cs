using System.Collections.Generic;

namespace dependencyInjection_demo.Models
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }

        public Employee GetEmployee()
        {
            return new Employee() { empNo=101, empDesignation="Sales", empName="Someone", empSalary=6000 };
        }

        public List<Employee> GetListOfEmployee()
        {
            return new List<Employee>()
            {
                new Employee() { empNo=101, empDesignation="Sales", empName="Someone", empSalary=6000 },
                new Employee() { empNo=101, empDesignation="Sales", empName="Someone", empSalary=6000 },
               new Employee() { empNo=101, empDesignation="Sales", empName="Someone", empSalary=6000 },
                new Employee() { empNo=101, empDesignation="Sales", empName="Someone", empSalary=6000 },
                new Employee() { empNo=101, empDesignation="Sales", empName="Someone", empSalary=6000 }
            };
        
        }
    }
}
