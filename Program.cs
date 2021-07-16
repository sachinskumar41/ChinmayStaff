using System;
using System.Collections.Generic;

namespace staff
{
    class Program
    {    
        static void Main(string[] args)
        {   
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
                ActionMenu(staff);
                Console.WriteLine("Do you want to continue in main menu?(y/n)");
                continueOption = Console.ReadLine();                                  
            }while (continueOption == "y");
        }

        public static void ActionMenu(Staff staff)
        {   
            MenuActinos menuActions = new MenuActinos();
            string continueOption;
            int userChoice;
            do
            {
            Console.WriteLine("\nSelect your Action \n1.Add a staff\n2.Display a staff\n3.Upadate a staff\n");
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch(userChoice) 
                {
                case 1:      
                    menuActions.AddStaff(staff,1);
                    break;
                case 2:
                    menuActions.DisplayAStaff(staff);
                    break;
                case 3:
                    menuActions.UpdateAStaff(staff);           
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
