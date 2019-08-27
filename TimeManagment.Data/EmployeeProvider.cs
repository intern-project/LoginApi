using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TimeManagment.Data
{
    public class EmployeeProvider : IEmployeeProvider
    {
        public readonly string connectionString;
        public EmployeeProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public IEnumerable<Employee> get()
        
        {
            IEnumerable<Employee> employee = null;

            using (var connection = new SqlConnection(connectionString))
            {
                employee = connection.Query<Employee>("select id, email as email , password as password, role as role from Employee where email="+"nimesh@gmail.com");
            }

            return employee;
        }
    }
}
