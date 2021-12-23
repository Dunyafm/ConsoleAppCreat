using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public  interface ICompanyService 
    {


        Company Create(Company model);
        Company Update(int id, Company model);
        void Delete(Company model);
        Company GetById(int id);
        List<Company> GetAllByName(string name);
        List<Company> GetAll();
        List<Company> GetByAge();
        Company GetAllById(int id);


            

    }
}
