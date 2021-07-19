using System;
using System.Collections.Generic;

namespace staff
{
    
    class Program
    {    
        public static int empId;
        static void Main(string[] args)
        {   List<Staff> staffList = new List<Staff>();
            string continueOption;
            int userChoice;   
            Staff staff = null;    
            do
            {   
                Console.WriteLine("Select your job type \n1.Teaching staff\n2.Admin. staff\n3.Supporting Staff");
                userChoice = Convert.ToInt32(Console.ReadLine());
                switch(userChoice) 
                {
                    case 1:
                        staff = new Teaching();
                        break;
                    case 2:
                        staff = new Administrative();
                        break;
                    case 3:
                        staff = new Supporting();
                        break;
                    default:
                        Console.WriteLine("SELECT A VALID OPTION");
                        break;
                }
                ActionMenu(staff,staffList);
                Console.WriteLine("Do you want to continue in main menu?(y/n)");
                continueOption = Console.ReadLine();                            
                GC.Collect();      
            }while (continueOption == "y");
        }

        public static void ActionMenu(Staff staff,List<Staff> staffList)
        {   
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
                    menuActions.AddStaff(staff,empId,staffList);
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
                Console.WriteLine("Do you want to continue in action menu?(y/n)");
                continueOption = Console.ReadLine();
            }while(continueOption == "y");
        } 
    }     
}
