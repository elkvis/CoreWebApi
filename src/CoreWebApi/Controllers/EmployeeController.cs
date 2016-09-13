using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Model.Employee> Get()
        {
            var employees = new List<Model.Employee>
            {
                new Model.Employee {EmployeeId = 1,FirstName = "Jalpesh",LastName = "Vadgama",Designation = "Technical Architect"},
                new Model.Employee {EmployeeId = 2,FirstName = "Vishal",LastName = "Vadgama",Designation = "Technical Lead"}
            };
            return employees;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Model.Employee Get(int id)
        {
            if (id == 1)
            {
                return new Model.Employee { EmployeeId = 1, FirstName = "Jalpesh", LastName = "Vadgama", Designation = "Technical Architect" };
            }
            else if (id == 2)
            {
                return new Model.Employee { EmployeeId = 2, FirstName = "Vishal", LastName = "Vadgama", Designation = "Technical Lead" };
            }
            else if (id == 3)
            {
                return new Model.Employee { EmployeeId = 3, FirstName = "foo", LastName = "bar", Designation = "none" };
            }

            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Model.Employee value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Model.Employee value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
