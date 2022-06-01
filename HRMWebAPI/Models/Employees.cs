using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMWebAPI.Models
{
    public class Employees
    {
        //ctr r + e: create get / set;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? Salary { get; set; }
        public int? Department_id { get; set; }

        public Employees()
        {
        }

        public Employees(int ID, string FirstName, string LastName, string Gender
            , DateTime BirthDay, int Salary, int Department_id)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.BirthDay = BirthDay;
            this.Salary = Salary;
            this.Department_id = Department_id;

        }


    }
}