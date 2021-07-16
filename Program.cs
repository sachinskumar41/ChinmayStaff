using System;
using System.Collections.Generic;

namespace staff
{
    class Program
    {
        public static Staff staff;
        public static int EmpId {get;set;}
        static void Main(string[] args)
        {   
            string continueOption;
            int userChoice;         
            do
            {   
                MenuActinos menuActions = new MenuActinos();
                Console.WriteLine("Select your job type \n1.Teaching staff\n2.Admin. staff\n3.Supporting Staff");
                userChoice = Convert.ToInt32(Console.ReadLine());
                switch(userChoice) 
                {
                    case 1:
                        menuActions.StaffType = "Teaching";
                        break;
                    case 2:
                        menuActions.StaffType = "Administrative";
                        break;
                    case 3:
                        menuActions.StaffType = "Supporting";    
                        break;
                    default:
                        Console.WriteLine("SELECT A VALID OPTION");
                        break;
                }
                ActionMenu(menuActions);
                Console.WriteLine("Do you want to continue in main menu?(y/n)");
                continueOption = Console.ReadLine();                                  
            }while (continueOption == "y");
        }

        public static void ActionMenu(MenuActinos menuActions)
        {   
            string continueOption;
            int userChoice;
            do
            {
            Console.WriteLine("\nSelect your Action \n1.Add a staff\n2.Display a staff\n3.Upadate a staff\n4.Delete a staff.");
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch(userChoice) 
                {
                case 1:      
                    EmpId++;
                    staff = menuActions.AddStaff(EmpId);
                    break;
                case 2:
                    menuActions.DisplayAStaff(staff);
                    break;
                case 3:
                    menuActions.UpdateAStaff(staff);           
                    break;
                case 4:
                    if(staff!= null)
                    {
                        staff = null;
                        GC.Collect();
                        Console.WriteLine("Deleted succesfully...");
                    }
                    else
                    {
                        Console.WriteLine("There is no staff to delete");
                    }    
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
