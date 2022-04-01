using System;
using System.Collections.Generic;

#nullable disable

namespace dependencyInjection_demo.Models.EF
{
    public partial class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int? EmpSalary { get; set; }
        public int? EmpDept { get; set; }

        public virtual DeptInfo EmpDeptNavigation { get; set; }
    }
}
