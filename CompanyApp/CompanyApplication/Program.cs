using CompanyApplication.Controller;
using Domain.Models;
using Service.Services;
using Service.Services.Helpers;
using System;

namespace CompanyApplication
{
    class Program
    {
         static void Main(string[] args)
         {
            CompanyController companyController =  new CompanyController();
            EmployeeController employeeController = new CompanyController();


            CompanyService companyService = new CompanyService();
            Helper.WriteToConsole(ConsoleColor.Blue, "Select options");
            CompanyController CompanyController = new CompanyController();
            while (true)
            {


                Helper.WriteToConsole(ConsoleColor.Cyan, "1 - Create Company, 2- Update Company, 3- Delete Company ," +
                    " 4- Get  Company by id, 5- Get all Company by name, 6- Get all Compaany," +
                    " 7- Create Employee, 8- Update Employee, 9-Get Employee by id, 10- Delete Employee, 11 - Get Employee by age, 12- Get all Employee by Company id");


            EnterOption: string selectOption = Console.ReadLine();
                int option;

                bool isTrueOption = int.TryParse(selectOption, out option);  //out vasitesti ile colden deyer vermemek olar.
                
                if(isTrueOption) 
                {


                    
                    switch (option)
                    {
                        case (int)MyEnums.Menus.CreateCompany:
                            companyController.Create();
                                break;
                        
                        case (int)MyEnums.Menus.UpdateCompany:
                          companyController.Update();
                            break;
                        case (int)MyEnums.Menus.DeleteCompany:

                            
                            break;
                        case (int)MyEnums.Menus.GetCompanyById:
                            companyController.GetById();
                            
                            break;
                        case (int)MyEnums.Menus.GetAllCompanyByName:

                            
                            break;
                        case (int)MyEnums.Menus.GetAllCompany:

                            companyController.GetAll();
                            break;
                        case (int)MyEnums.Menus.CreateEmployee:


                        break;

                        case (int)MyEnums.Menus.UptadeEmployee:

                            break;

                        case (int)MyEnums.Menus.GetEmployeeById:

                            break;

                        case (int)MyEnums.Menus.DeleteEmployee:

                            break;
                        case (int)MyEnums.Menus.GetEmployeeByAge:
                            break;

                        case (int)MyEnums.Menus.GetAllEmployeeByCompanyId:
                            break;
                        

                            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id: ");
                            string companyId = Console.ReadLine(); ;
                            int id;

                            bool isIdTrue = int.TryParse(companyId, out id);

                            if (isIdTrue)
                            {
                                var result = companyService.GetById(id);

                                if(result == null)
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
                            break;


                         

                    }

                }
                else
                {
                    goto EnterOption;

                }
                
            }























            
            
        }
    }
}
