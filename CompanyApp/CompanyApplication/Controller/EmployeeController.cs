using Domain.Models;
using Service.Services;
using Service.Services.Helpers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication.Controller
{
    public class EmployeeController
    {
        private EmployeeService _employeeService { get; }

        public EmployeeController()
        {
            EmployeeService = new EmployeeService();
        }

        public void Create()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add employee name :");
        EnterLibrarayId: string id = Console.ReadLine();
            int employeeid;

            bool idTrueemployeeId = int.TryParse(id, out employeeid);
            string employeename = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add employee surname :");
            string employeesurname = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add employee age :");
            string employeeage = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add employee company :");
            string employeecompany = Console.ReadLine();
            int id;

            employee = new employee
            {
                Name = employeename,
                Surname = employeesurname,
                Age = employeeage,
                Company = employeecompany

            };
            var result = _EmployeeService.Create(company);
            if (result != null)
            {
                Helper.WriteToConsole(ConsoleColor.Green, $"{employeename} {employeesurname} {employeeage} {employeecompany} employee created ");
            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Something is wrong");
            }


        }

        public static implicit operator EmployeeController(CompanyController v)
        {
            throw new NotImplementedException();
        }
        
        public void Update()
        {

        }
        public void GetById()
        {

        }
        public void Delete()
        {

        }
        
        public void GetByAge()
        {

        }

        public void GetAllById()
        {

        }
        
        
        
}   }         