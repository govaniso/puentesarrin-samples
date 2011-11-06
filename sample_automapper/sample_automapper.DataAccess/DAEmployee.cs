using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using sample_automapper.BusinessEntities;
using AutoMapper;

namespace sample_automapper.DataAccess
{
    public class DAEmployee
    {
        public List<BEEmployee> SelectAllEmployees()
        {
            try
            {
                List<BEEmployee> Lista = new List<BEEmployee>();
                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
                {
                    if (Connection.State == ConnectionState.Closed) Connection.Open();
                    using (SqlCommand Command = new SqlCommand("select EmployeeID, LastName, FirstName from employees", Connection))
                    {
                        using (IDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Mapper.CreateMap<IDataReader, BEEmployee>();
                                Lista = Mapper.Map<IDataReader, List<BEEmployee>>(reader);
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
