﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TimeManagment.Data
{
    public class Login : Ilogin
    {
        public readonly string connectionString;
        public Login(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Token login(User user)
        {
            //Generating token


            //
            

            var email = user.email;

            
            IEnumerable<Employee> employeesFromDB = null;
         
            


            using (var connection = new SqlConnection(connectionString))
            {

                employeesFromDB = connection.Query<Employee>("select id, email as email , password as password, role as role from Employee where email =" + email);

            }
            //get the first instance of collection
            Employee EmployeeFromDB = employeesFromDB.FirstOrDefault();

            var userEmailFromDB = EmployeeFromDB.email;

            Token token = new Token();
            

            //checking existance of employee
            if (userEmailFromDB!= null)
            {
                return token;
            }
            else
            {
                token.token = "kkk";
                token.role = EmployeeFromDB.role;
                return token;

            }



            
        }
    }
}
