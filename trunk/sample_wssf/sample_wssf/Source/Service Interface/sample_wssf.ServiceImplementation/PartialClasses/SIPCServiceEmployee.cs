using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sample_wssf.MessageContracts;
using sample_wssf.DataContracts;
using sample_wssf.BusinessLogic;

namespace sample_wssf.ServiceImplementation
{
    public partial class ServiceEmployee
    {
        public override sample_wssf.MessageContracts.selectAllEmployeesResponse SelectAllEmployees()
        {
            return new selectAllEmployeesResponse(){
                ListEmployees = new BLEmployee().SelectAllEmployees()
            };
        }
    }
}
