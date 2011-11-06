using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace sample_entlib_logging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                i = i / i;
            }
            catch (Exception ex)
            {
                Logger.Write(ex);
            }
        }
    }
}
