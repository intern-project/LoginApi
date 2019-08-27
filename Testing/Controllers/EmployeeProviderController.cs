using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeManagment.Data;

namespace TimeManagment.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeProviderController : ControllerBase
    {
        private readonly IEmployeeProvider employeeProvider;
        public EmployeeProviderController(IEmployeeProvider employeeProvider)
        {
            this.employeeProvider = employeeProvider;
        }
        // GET: api/EmployeeProvider
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeProvider.get();
        }

        // GET: api/EmployeeProvider/5
      

        // POST: api/EmployeeProvider
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/EmployeeProvider/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
