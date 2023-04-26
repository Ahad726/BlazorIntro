using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }


    }
}
