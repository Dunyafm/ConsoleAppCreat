using Domain.Models;
using Service.Services;
using Service.Services.Helpers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication.Controller
{

    public class CompanyController
    {
        private CompanyService _companyService { get; }
        public CompanyController()
        {
            _companyService = new CompanyService();
        }
        public void Create()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company name");
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company name");
            EnterName:string companyname = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company address");
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company adrress");
            string companyaddress = Console.ReadLine();

            Company company = new Company ()
            {
                Name = companyname,
                Address = companyaddress

            };
            var result = _companyService.Create(company);
            if (result != null)
            {
                Helper.WriteToConsole(ConsoleColor.Green, $"{company.Id} {company.Name} company created ");
            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Something is wrong");
                goto EnterName;
            }



        }
        public void GetById()
        {
            Helper.WriteToConsole(ConsoleColor.Blue, "Add company's ID:");
        EnterId: string companyID = Console.ReadLine();
            int id;

            bool isTrue = int.TryParse(companyID, out id);

            if (isIdTrue)
            {
                var companies = _companyService.GetById(id);
                if (companies == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found.");
                }
                else
                {


                    Helper.WriteToConsole(ConsoleColor.Green, $"Name : {companies.Name} - Address:{companies.Address}")

                        goto EnterId;
                }
            }


            

        }

        public void Delete()
        {

            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id: ");
            string companyId = Console.ReadLine(); ;
            int id;

            bool isIdTrue = int.TryParse(companyId, out id);

            if (isIdTrue)
            {
                var result = _companyService.GetById(id);




                if (result == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found");

                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Red, $"{result.Id} - {result.Name } - {result.Address}");

                }



            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try again id");

            }

            
        }   

        public void GetById()  
        { 

        }

        public void GetAllByName()
        {

        }
         public void GetAll()
         {

         }




        public void Update()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id : ");
        EnterId: string companyId = Console.ReadLine();
            int id;
            bool isTrue = int.TryParse(companyId, out id);
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add new company name : ");
            string newName = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add new company address : ");
            string newAddress = Console.ReadLine();


            if (isTrue)
            {
                if (isIdTrue || string.IsNullOrEmpty(companyId))
                {
                    Company company = new Company
                    {
                        Name = newName,
                        Address = newAddress
                    };

                    Company newcompany = _companyService.Update(id, company);

                    Helper.WriteToConsole(ConsoleColor.Green, $"{newcompany.Id}-{newcompany.Name}-{newcompany.Address}");

                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Try again id");

                    goto EnterId;
                }

            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try again id");
                goto EnterId;
            }

        }





        public void GetById()
        {

            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id: ");
            string companyId = Console.ReadLine(); ;
            int id;

            bool isIdTrue = int.TryParse(companyId, out id);

            if (isIdTrue)
            {
                var result = _companyService.GetById(id);

                if (result == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found");

                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Red, $"{result.Id} - {result.Name } - {result.Address}");

                }







            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try again id");

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
    

   
                
            

         


    


                

               
                
            
         