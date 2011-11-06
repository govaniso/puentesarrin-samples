using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sample_datatables.BusinessEntities;
using sample_datatables.DataAccess;

namespace sample_datatables.BusinessLogic
{
    public class BLEmployee
    {
        public List<BEEmployee> SelectAllEmployees()
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
