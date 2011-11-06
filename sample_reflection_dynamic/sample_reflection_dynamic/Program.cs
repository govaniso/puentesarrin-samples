using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace sample_reflection_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "/sample_reflection_dynamic.exe");
            Object oEmployee = Activator.CreateInstance(assembly.GetType("sample_reflection_dynamic.Employee"));
            ReadWithReflection(oEmployee);
            ReadWithDynamic(oEmployee);
            Console.Read();
        }

        static void ReadWithReflection(object oEmployee)
        {
            Type TypeEmployee = oEmployee.GetType();
            Console.WriteLine("With Reflection:");
            Console.WriteLine("EmployeeID: " + TypeEmployee.GetProperty("EmployeeID", typeof(int)).GetValue(oEmployee, null).ToString());
            Console.WriteLine("LastName: " + TypeEmployee.GetProperty("LastName", typeof(string)).GetValue(oEmployee, null).ToString());
            Console.WriteLine("FirstName: " + TypeEmployee.GetProperty("FirstName", typeof(string)).GetValue(oEmployee, null).ToString());
        }
        static void ReadWithDynamic(dynamic oEmployee)
        {
            Console.WriteLine("With dynamic:");
            Console.WriteLine("EmployeeID: " + oEmployee.EmployeeID);
            Console.WriteLine("LastName: " + oEmployee.LastName);
            Console.WriteLine("FirstName: " + oEmployee.FirstName);
        }
    }
}
