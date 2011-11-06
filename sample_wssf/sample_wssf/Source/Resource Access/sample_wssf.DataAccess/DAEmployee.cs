using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using sample_wssf.DataContracts;

namespace sample_wssf.DataAccess
{
    public class DAEmployee
    {
        public ListDCEmployee SelectAllEmployees()
        {
            try
            {
                ListDCEmployee Lista = new ListDCEmployee();
                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
                {
                    if (Connection.State == ConnectionState.Closed) Connection.Open();
                    using (SqlCommand Command = new SqlCommand("select employeeid, lastname, firstname from employees", Connection))
                    {
                        using (IDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Lista.Add(new DCEmployee()
                                {
                                    EmployeeID = Convert.ToInt32(reader["employeeid"]),
                                    FirstName = Convert.ToString(reader["firstname"]),
                                    LastName = Convert.ToString(reader["lastname"])
                                });
                            }
                        }
                    }
                    if (Connection.State == ConnectionState.Open) Connection.Close();
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
