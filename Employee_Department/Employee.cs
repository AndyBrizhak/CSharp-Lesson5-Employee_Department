using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Department
{
    class Employee
    {
        private string _emp_name { get; set; }
        private List<Department> _emp_dep { get; set; }

        public string Name;
        public List<Department> Dep;
        public Employee (string _emp_name, List<Department> _emp_dep )
        {
            Name = _emp_name;
            Dep = _emp_dep;
        }
    }
}
