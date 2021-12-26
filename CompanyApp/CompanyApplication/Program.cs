using CompanyApplication.Controllers;
using Domain.Models;
using Service.Helpers;
using Service.Services;
using Service.Services.Helpers;
using System;

namespace CompanyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyController companyController = new CompanyController();
            EmployeeController employeeController = new EmployeeController();

            Helper.WriteToConsole(ConsoleColor.Blue, "Select options");

            while (true)
            {
                GetMenus();


                EnterOption: string selectOption = Console.ReadLine();

                int option;

                bool isTrueOption = int.TryParse(selectOption, out option);  

                if (isTrueOption)
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
                            companyController.Delete();

                            break;
                        case (int)MyEnums.Menus.GetCompanyById:
                            companyController.GetById();

                            break;
                        case (int)MyEnums.Menus.GetAllCompanyByName:
                            companyController.GetAllByName();
                            
                            break;
                        case (int)MyEnums.Menus.GetAllCompany:

                            companyController.GetAll();
                            break;
                        case (int)MyEnums.Menus.CreateEmployee:
                            employeeController.Create();

                            break;

                        case (int)MyEnums.Menus.UpdateEmployee:
                            employeeController.Update();
                            break;

                        case (int)MyEnums.Menus.GetEmployeeById:
                            employeeController.GetById();
                            break;
                        case (int)MyEnums.Menus.DeleteEmployee:
                            employeeController.Delete();
                            break;

                        case (int)MyEnums.Menus.GetEmployeeByAge:
                            employeeController.GetByAge();
                            break;

                        case (int)MyEnums.Menus.GetAllEmployeeByCompanyId:
                            employeeController.GetAllByCompanyId();
                            break;





                    }

                }
                else
                {
                    goto EnterOption;

                }

            } 
            static void GetMenus()
            {


                  Helper.WriteToConsole(ConsoleColor.Cyan,  
                    "1 - Create Company, " + " 4 - Get  Company by id ,"  +   " 7- Create Employee," + " 10- Delete Employee" +
                    "2- Update Company," + " 5 - Get all Company by name,"+ "8 - Update Employee," + "11 - Get Employee by age" +
                    " 3- Delete Company ," + " 6 - Get all Compaany," + "9 - Get Employee by id,"+ " 12 - Get all Employee by Company id");

                    




            }

}   }   }


















            
            
        
    

