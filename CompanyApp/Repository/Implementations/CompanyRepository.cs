using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementations
{
    public class CompanyRepository : IRepository<Company>
    {
        public bool Create(Company entity)
        {
            try
            {
                if (entity == null)
                    throw new CustomExceptions("Entity is null");

                AppDbContext<Company>.datas.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;

                Console.WriteLine(ex.Message);
            }


            throw new NotImplementedException();
        }

        public bool Deelete(Company entity)
        {
            throw new NotImplementedException();
        }

        public Company Get(Predicate<Company> filter = null)
        {
            return filter ==null ? AppDbContext<Company>.datas.Find(filter);
        }

        public List<Company> GetAll(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public bool Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
