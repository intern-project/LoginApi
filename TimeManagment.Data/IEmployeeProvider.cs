using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagment.Data
{
    public interface IEmployeeProvider
    {
        IEnumerable<Employee> get();
    }
}
