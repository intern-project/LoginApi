using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TimeManagment.Data
{
    public class Login 
    {
        public readonly string connectionString;
        public Login()
        {
            this.connectionString = connectionString;
        }
        public Token login(User user)
        {
            //Generating token


            //




            

            var email = user.email;

            
            IEnumerable<Employee> employeeFromDB = null;
         
            


            using (var connection = new SqlConnection(connectionString))
            {

                employeeFromDB = connection.Query<Employee>("select id, email as email , password as password, role as role from Employee where email =" + email);

            }

            Employee Employee1 = employeeFromDB.FirstOrDefault();

            Token token = new Token();
            token.token = "kkkkk";
            token.role = Employee1.role;

            return token;
        }
    }
}
