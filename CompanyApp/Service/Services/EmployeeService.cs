using Domain.Models;
using Repository.Exceptions;
using Repository.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
       private  CompanyRepository _companyRepository { get; }
        private EmployeeRepository _employeeRepository { get; }
        private int count { get; set; }
        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
            _companyRepository = new CompanyRepository();
        }
        public Employee Create(Employee model,int companyId)
        {
            try
            {
                Company company = _companyRepository.Get(m => m.Id == companyId);
                if (company == null) throw new CustomExceptions("Company was not found");
                model.Id = count;
                model.Company = company;
                _employeeRepository.Create(model);
                return model;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Delete (Employee model)
        {
            _employeeRepository.Delete(model);
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.Get(m => m.Id == id);


        }
         
        public Employee GetEmployeeByAge(int age)
        {
            return _employeeRepository.Get(m => m.Age == age);
        }
        public List<Employee> GetAllEmployeeByCompany(int id)
        {
            return _employeeRepository.GetAll(m => m.Id == id);
        }

        public Employee Update(int id,Employee model)
        {
            Employee employee = GetById(id);
            model.Id = employee.Id;
            _employeeRepository.Update(model);
            return model;
        }

        Employee IEmployeeService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployeeByCompanyId(int id)
        {
            throw new NotImplementedException();
        }
    }


            
}    

  
    

