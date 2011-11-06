using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace sample_wssf.AppHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svEmployee = new ServiceHost(typeof(sample_wssf.ServiceImplementation.ServiceEmployee));
            svEmployee.Open();
            Console.WriteLine("Press any key to stop service.");
            Console.ReadKey();
            svEmployee.Close();
        }
    }
}
