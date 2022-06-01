using HRMWebAPI.DTO;
using HRMWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMWebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeeManagerEntities db = new EmployeeManagerEntities();
        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }
        [HttpGet]
        [Route("api/Employees/Search")]
        public List<Employee> Search(string keyword)
        {
            using (EmployeeManagerEntities db = new EmployeeManagerEntities())
            {
                try
                {
                    return db.Employees.Where(e => e.ID.ToString().Contains(keyword) ||
                    (e.FirstName + " " + e.LastName).Contains(keyword)).ToList();
                }
                catch (Exception e)
                {
                    return null;
                }

            }
        }
        public GetEmployee_Result Get(int id)
        {
            //return db.Employees.SingleOrDefault(item => item.ID == id);
            //var data = (from e in db.Employees
            //            join d in db.Departments on e.Department_id equals d.ID
            //            where e.ID == id
            //            select new
            //            {
            //                id = e.ID,
            //                firstname = e.FirstName,
            //                lastname = e.LastName,
            //                birthday = e.Birthday,
            //                gender = e.Gender,
            //                salary = e.Salary,
            //                department_id = e.Department_id,
            //                department_name = d.DepartmentName
            //            }).ToList();
            //return new Employees(data[0].id, data[0].firstname, data[0].lastname, data[0].gender, DateTime.Parse(data[0].birthday.ToString()),
            //int.Parse(data[0].salary.ToString()), int.Parse(data[0].department_id.ToString()));
            return db.GetEmployee(id).ToList()[0];
        }

        public HttpResponseMessage Post([FromBody] Employee emp)
        {
            using (EmployeeManagerEntities db = new EmployeeManagerEntities())
            {
                try
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"err: " + e.Message);
                }

            }
        }
        

        public Employee Put([FromBody] Employee emp)
        {
            Employee e = db.Employees.SingleOrDefault(item => item.ID == emp.ID);
            e.FirstName = emp.FirstName;
            e.LastName = emp.LastName;
            e.Gender = emp.Gender;
            e.Birthday = emp.Birthday;
            e.Salary = emp.Salary;
            e.Department_id = emp.Department_id;
            
            db.SaveChanges();

            return e;
        }

        public List<Employee> Delete(int id)
        {
            Employee emp = db.Employees.SingleOrDefault(item => item.ID == id);
            db.Employees.Remove(emp);
            db.SaveChanges();

            return db.Employees.ToList();
        }
    }
}
