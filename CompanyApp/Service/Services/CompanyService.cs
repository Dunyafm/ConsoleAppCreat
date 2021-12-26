using Domain.Models;
using Repository.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CompanyService : ICompanyService
    {
        private CompanyRepository _companyRepository;
        private int count { get; set; }
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }
       public Company Create(Company model)
        {
            model.Id = count;
            _companyRepository.Create(model);
            count++;
            return model;

            

        }

        public void Delete(int id)
        {
            var company = GetById(id);
            _companyRepository.Delete(company);
        }

        public Company GetById(int id)
        {
            return _companyRepository.Get(m => m.Id == id);
            
        }

        public List<Company> GetAll(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public Company GetByName(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public Company Update(int id, Company model)
        {
            var company = GetById(id);
            model.Id = company.Id;
            ((Repository.Inheritance.IRepository<Company>)_companyRepository).Update(company);
                return model;
        }

        public List <Company> GetAll()
        {
            return _companyRepository.GetAll(null);
        }

        public void Delete(Company model)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetByAge()
        {
            throw new NotImplementedException();
        }

        public Company GetAllById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
