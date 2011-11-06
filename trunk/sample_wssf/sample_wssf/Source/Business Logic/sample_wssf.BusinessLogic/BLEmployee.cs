using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sample_wssf.DataContracts;
using sample_wssf.DataAccess;

namespace sample_wssf.BusinessLogic
{
    public class BLEmployee
    {
        public ListDCEmployee SelectAllEmployees()
        {
            try
            {
                return new DAEmployee().SelectAllEmployees();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
