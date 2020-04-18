using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using lesson3.DataAccess;

namespace lesson3
{
    class Programm
    {
        static void Main()
        {

        }
        static void ShowMenu(string type, int choice)
        {
            Company comp = new Company();
            switch (type)
            {
                case "Main":
                    {
                        System.Console.WriteLine("1. Show companies");
                        System.Console.WriteLine("2. Get one company by id");
                        System.Console.WriteLine("3. Add company");
                        System.Console.Write("Choice:");
                        var _choice = Console.ReadLine();
                        ShowMenu("Comapany", choice);
                    }; break;
                case "Company":
                    {
                        switch (choice)
                        {
                            case 1:
                                {
                                    var companyList = comp.SelectAll();
                                    foreach (var company in companyList)
                                    {
                                        System.Console.WriteLine();
                                    }
                                }
                                break;
                        }
                    }; break;
            }
        }
    }
}