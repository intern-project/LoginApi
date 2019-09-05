using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagment.Data
{
    public interface Ilogin
    {
           Task<Employee> login(User user);
    }
}
