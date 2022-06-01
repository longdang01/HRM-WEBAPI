using HRMWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMWebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET api/values
        public IEnumerable<Department> Get()
        {
            using (EmployeeManagerEntities db = new EmployeeManagerEntities())
            {
                return db.Departments.ToList();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
