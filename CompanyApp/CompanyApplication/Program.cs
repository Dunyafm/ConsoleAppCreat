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


                    //  var result = libraryService.Create()
                    switch (option)
                    {
                        case (int)MyEnums.Menus.CreateCompany:
                            companyController.Create();
                                break;
                        //    Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company name");
                        //    string companyName = Console.ReadLine();
                        //    Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company name");
                        //EnterCount: string placeCount = Console.ReadLine();
                        //    int count;
                        //    bool isTrueCount = int.TryParse(placeCount, out count);
                        //    if (isTrueCount)
                        //    {
                        //        Company company = new Company
                        //        {
                        //            Name = companyName,
                        //            Address = count
                        //        };
                        //        var result = companyService.Create(company);

                        //        if (result != null)
                        //        {

                        //            Helper.WriteToConsole(ConsoleColor.Green, $"{company.Id} - {company.Name } company created");
                                   

                        //        }
                        //        else
                        //        {
                        //            Helper.WriteToConsole(ConsoleColor.Green, "Something is wrong");
                        //            return;
                        //        }



                        //    }
                        //    else
                        //    {
                        //        Helper.WriteToConsole(ConsoleColor.Green, "Try again count");
                        //        goto EnterCount;
                        //    }

                        //    break;
                        case 2:
                            break;
                        case 3:;
                            break;
                        case (int)MyEnums.Menus.CreateCompanyById:
                            companyController.GetById();

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
