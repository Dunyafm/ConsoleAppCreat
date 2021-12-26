using CompanyApplication.Controller;
using Domain.Models;
using Service.Services;
using Service.Services.Helpers;
using System;

namespace CompanyApplication
{
    class Program
    {
        CompanyController companyController = new CompanyController

        public static void Main(string[] args)
        {
            CompanyService companyService = new CompanyService();
            Helper.WriteToConsole(ConsoleColor.Blue, "Select options");
            CompanyController companyController = new CompanyController();
            while (true)
            {
                GetMenus();

                //Helper.WriteToConsole(ConsoleColor.Cyan, "1 - Create Company, 2- Update Company, 3- Delete Company ," +
                //    " 4- Get  Company by id, 5- Get all Company by name, 6- Get all Compaany," +
                //    " 7- Create Employee, 8- Update Employee, 9-Get Employee by id, 10- Delete Employee, 11 - Get Employee by age, 12- Get all Employee by Company id");


                EnterOptions: string selectOption = Console.ReadLine();
                int option;

                bool isTrueOption = int.TryParse(selectOption, out option);  //out vasitesti ile colden deyer vermemek olar.
                
                if(isTrueOption) 
                {


                    
                    switch (option)
                    {
                        case (int)MyEnums.Menus.CreateCompany:
                            companyController.Create();
                                break;
                        
                        case (int)MyEnums.Menus.UptadeCompany:

                            companyController.Uptade();
                            break;
                        case (int)MyEnums.Menus.DeleteCompany:

                            companyController.Delete();
                            break;
                        case (int)MyEnums.Menus.GetCompanyById:

                            companyController.GetById();
                            break;
                        case (int)MyEnums.Menus.GetallCompanyByName:

                            companyController.GetAllByName();
                            break;
                        case (int)MyEnums.Menus.GetAllCompany:

                            companyController.GetAll();
                            break;
                        case (int)MyEnums.Menus.CreateEmployee:

                            companyController.Create();
                            break;
                        case (int)MyEnums.Menus.UptadeEmployee:

                            companyController.Uptade();
                            break;
                        case (int)MyEnums.Menus.GetEmployeeById:

                            companyController.GetById();
                            break;
                        case (int)MyEnums.Menus.DeleteEmployee:

                            companyController.Delete();
                            break;
                        case (int)MyEnums.Menus.GetEmployeeByAge:

                            companyController.GetByAge();
                            break;
                        case (int)MyEnums.Menus.GetallEmployeeByCompanyId:
                            break;


                            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id: ");
                            string companyId = Console.ReadLine(); ;
                            int id;

                            bool isIdTrue = int.TryParse(companyId, out id);

                            if (isIdTrue)
                            {
                                var result = companyService.GetById(id);

                                if(Company == null)
                                {
                                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found");
                                    goto EnterId;
                                }
                                else
                                {
                                    Helper.WriteToConsole(ConsoleColor.Red, $"{company.Id} - {company.Name } - {company.Address}");
                                    
                                }







                            }
                            else
                            {
                                Helper.WriteToConsole(ConsoleColor.Red, "Try again id");
                                goto EnterId;
                            }
                            break;


                         

                    }

                }
                else
                {
                    goto EnterOptions;

                }
                
            }























            
            
        }
    }
}
