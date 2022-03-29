using System.Collections.Generic;

namespace employeeWebAPI.Models
{
    public class EmployeeModel
    {

        #region Employee Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        public string empCity { get; set; }

        #endregion


        public EmployeeModel GetEmployee()
        {
            //we can connect to database here and pull the data
            //ADO.net, EF can be used 
            return new EmployeeModel() { empNo = 101, empName = "Kriti", empDesignation = "Sales", empSalary = 25000 };
        }

        public List<EmployeeModel> GetEmployeeModelsList()
        {


            List<EmployeeModel> empModels = new List<EmployeeModel>();
            empModels.Add(new EmployeeModel() { empNo =101, empName="Kriti", empCity="Mumbai", empDesignation="Sales", empIsPermenant=false, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =102, empName="Sonal", empCity="Chennai", empDesignation="HR", empIsPermenant=true, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =103, empName="Akshay", empCity="Mumbai", empDesignation="Sales", empIsPermenant=true, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =104, empName="Raj", empCity="Pune", empDesignation="Accounts", empIsPermenant=true, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =105, empName="Mohit", empCity="Mumbai", empDesignation="Sales", empIsPermenant=false, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =106, empName="Jitesh", empCity="Mumbai", empDesignation="Sales", empIsPermenant=true, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =107, empName="Dhara", empCity="Chennai", empDesignation="Sales", empIsPermenant=true, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =108, empName="Priya", empCity="Mumbai", empDesignation="Developer", empIsPermenant=false, empSalary=25000 });
            empModels.Add(new EmployeeModel() { empNo =109, empName="Riya", empCity="Pune", empDesignation="Developer", empIsPermenant=true, empSalary=25000 });

            return empModels;
        }
    }
}
