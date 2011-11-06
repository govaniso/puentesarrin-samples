using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sample_automapper.BusinessEntities;
using sample_automapper.DataAccess;

namespace sample_automapper.BusinessLogic
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
