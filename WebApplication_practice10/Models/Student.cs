using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_practice10.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string lastName, string firstName, string group, DateTime birth,string zipcode)
        {
            LastName = lastName;
            FirstName = firstName;
            Group = group;
            Birth = birth;
            Zipcode = zipcode;
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Group { get; set; }
        public DateTime Birth { get; set; }
        public string Zipcode { get; set; }
    }
}
