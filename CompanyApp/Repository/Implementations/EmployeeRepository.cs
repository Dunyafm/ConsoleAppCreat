using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Inheritance;
using System;
using System.Collections.Generic;
namespace Repository.Implementations
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public bool Create(Employee entity)
        {
            try
            {
                if (entity == null)
                    throw new CustomExceptions("Entity is null");

                AppDbContext<Employee>.datas.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;

                Console.WriteLine(ex.Message);
            }


            throw new NotImplementedException();

           
        }

        public bool Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(Predicate<Employee> filter)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }
        public bool GetByAge (Employee entity)
        {
            throw new NotImplementedException();
        }
       
        public bool GetAllByCompany(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Deelete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(Predicate<Employee> filter)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(Predicate<Employee> filter)
        {
            throw new NotImplementedException();
        }
    }
}
