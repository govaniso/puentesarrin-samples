using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample_reflection_dynamic
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Employee()
        {
            EmployeeID = 0;
            LastName = "Puente Sarrín";
            FirstName = "Jorge";
        }
    }
}
