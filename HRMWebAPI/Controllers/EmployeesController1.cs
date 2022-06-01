//using HRMWebAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace HRMWebAPI.Controllers
//{
//    public class EmployeesController1 : ApiController
//    {
//        List<Employees> employees = new List<Employees>() {
//            new Employee(1, "Dang Hoang Long", true, DateTime.Parse("2001-07-24"), "Yen My, Hung Yen"),
//            new Employee(2, "Le Dinh Minh", true, DateTime.Parse("2001-01-01"), "Khoai Chau, Hung Yen"),
//            new Employee(3, "Nguyen Dinh Quang", true, DateTime.Parse("2001-02-02"), "Phu Cu, Hung Yen")
//        };

//        // GET api/<controller>
//        public IEnumerable<Employees> Get()
//        {
//            return employees;
//        }

//        // GET api/<controller>/5
//        public Employees Get(int id)
//        {
//            return employees.SingleOrDefault(item => item.id == id);
//        }

//        // POST api/<controller>
//        public List<Employees> Post([FromBody] Employees emp)
//        {
//            employees.Add(emp);
//            return employees;
//        }

//        // PUT api/<controller>/5
//        public Employees Put([FromBody] Employees emp)
//        {
//            Employees e = Get(emp.id);
//            e.name = emp.name;
//            e.gender = emp.gender;
//            e.dob = emp.dob;
//            e.address = emp.address;

//            return e;
//        }

//        // DELETE api/<controller>/5
//        public List<Employees> Delete(int id)
//        {
//            Employees emp = Get(id);
//            employees.Remove(emp);
//            return employees;
//        }
//    }
//}