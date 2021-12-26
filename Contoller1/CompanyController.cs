using Domain.Models;
using Service.Services;
using Service.Services.Helpers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication.Controller
{
  
    public  class CompanyController
    {
        private CompanyService _companyService { get; }
        public CompanyController()
        {
            _companyService = new CompanyService();
        }
        private  void Create()
        {

            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id: ");
            EnterId: string companyId = Console.ReadLine();
            int id;

            bool isIdTrue = int.TryParse(companyId, out id);

            if (isIdTrue)
            {
                var result = CompanyService.GetById(int);

                if (company == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found");
                    goto EnterId;
                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "${Company.Id} - {Company.Name } - {Company.Address}");

                }







            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try again id");
                goto EnterId;
            }
        }
        public void GetAll() 
        {
            var companies = _companyService.GetAll();

            foreach (var item in companies) 
            {
                Helper.WriteToConsole(ConsoleColor.Red, "$ {item.Id} - {item.Name } - {item.Address }");
            }

        } 
    }
}
