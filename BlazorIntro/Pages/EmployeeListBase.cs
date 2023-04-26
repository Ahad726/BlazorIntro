using Employeemanagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BlazorIntro.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            var emp1 = new Employee
            {
                Name = "Atm",
                Email = "atm@gmail.com",
                DateOfBirth = new DateTime(1998, 6, 11),
                Gender = Gender.Male,
                Department = new Department { DeptId = 1, DeptName = "ICT" },
                PhotoPath = "images/ATM_Abdul_Ahad_300x300.jpg"
            };
            var emp2 = new Employee
            {
                Name = "talha",
                Email = "talha@gmail.com",
                DateOfBirth = new DateTime(1998, 6, 11),
                Gender = Gender.Male,
                Department = new Department { DeptId = 1, DeptName = "BBA" },
                PhotoPath = "images/murad.jpg"
            };
            var emp3 = new Employee
            {
                Name = "Don",
                Email = "don@gmail.com",
                DateOfBirth = new DateTime(1998, 6, 11),
                Gender = Gender.Male,
                Department = new Department { DeptId = 1, DeptName = "IBA" },
                PhotoPath = "images/c7f06d49-e211-421c-aa9c-4cd5c18de3e1.jpg"
            };

            Employees = new List<Employee> { emp1, emp2, emp3 };
        }
    }
}
