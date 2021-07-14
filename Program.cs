using System;
using System.Collections.Generic;

namespace staff
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<dynamic> staffList = new List<dynamic>();
            int empId = 1;
            while (true)
            {   
                MenuActinos menuActions = new MenuActinos();
                Console.WriteLine("\nSelect the Action \n1.Add a staff\n2.view a staff\n3.view all staff\n4.Update a staff info\n5.Delete a Staff");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch(userChoice) 
                {
                case 1:
                    menuActions.AddStaff(staffList,empId);
                    Console.WriteLine("Staff successfully added..");
                    empId++;
                    break;
                case 2:
                    menuActions.DisplayAstaff(staffList);
                    break;
                case 3:
                    menuActions.DisplayAllStaffs(staffList);                   
                    break;
                case 4:
                    menuActions.UpdateAStaff(staffList);
                    Console.WriteLine("Updated succesfully...");
                    break;
                case 5:
                    menuActions.DeleteAStaff(staffList);
                    Console.WriteLine("Deleted succesfully...");
                    break;
                default:
                    Console.WriteLine("SELECT A VALID OPTION");
                    break;
                }                
            }  
        }   
    }     
}
