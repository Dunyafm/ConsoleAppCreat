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
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(Employee entity)
        {
            try
            {
                AppDbContext<Employee>.datas.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Employee Get(Predicate<Employee> filter)
        {
            return filter == null ? AppDbContext<Employee>.datas[0] : AppDbContext<Employee>.datas.Find(filter);
        }

        public List<Employee> GetAll(Predicate<Employee> filter)
        {
            return filter == null ? AppDbContext<Employee>.datas : AppDbContext<Employee>.datas.FindAll(filter);
        }

        public bool GetById(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee entity)
        {
            try
            {
                var employee = Get(m => m.Id == entity.Id);
                if (employee != null)
                {
                    if (!string.IsNullOrEmpty(entity.Name))
                        employee.Name = entity.Name;

                    if (!string.IsNullOrEmpty(entity.Surname))
                        employee.Surname = entity.Surname;

                    if (!string.IsNullOrEmpty(entity.Age.ToString()))
                        employee.Age = entity.Age;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }





}

