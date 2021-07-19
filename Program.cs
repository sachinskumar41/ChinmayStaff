using System;
using System.Collections.Generic;

namespace staff
{    
    class Program
    {    
        public static int empId;
        static void Main(string[] args)
        {   
            List<Staff> staffList = new List<Staff>();
            MenuActinos menuActions = new MenuActinos();
            string continueOption;
            int userChoice;   
            do
            {
                Console.WriteLine("\nSelect your Action \n1.Add a staff\n2.Display a staff\n3.Display all staffs\n4.Update a staff\n5.Delete a staff");
                userChoice = Convert.ToInt32(Console.ReadLine());
                switch(userChoice) 
                    {
                    case 1:    
                        empId++;  
                        menuActions.AddStaff(empId,staffList);
                        break;
                    case 2:
                        menuActions.DisplayAstaff(staffList);
                        break;
                    case 3:
                        menuActions.DisplayAllStaffs(staffList);    
                        break;
                    case 4:
                        menuActions.UpdateAStaff(staffList);
                        break;  
                    case 5:
                        menuActions.DeleteAStaff(staffList);
                        break;      
                    default:
                        Console.WriteLine("SELECT A VALID OPTION");
                        break;
                }
                Console.WriteLine("Do you want to continue in main menu?(y/n)");
                continueOption = Console.ReadLine();                            
            }while (continueOption == "y");
        }
    }     
}
