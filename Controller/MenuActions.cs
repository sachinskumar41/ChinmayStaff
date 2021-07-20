using System;
using System.Collections.Generic;

namespace staff
{    
    class MenuActinos
    {   
        public static Staff  AddStaff(int empId)
        {
            Staff staff =null; 
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            Console.WriteLine("Select your job type \n1.Teaching staff\n2.Admin. staff\n3.Supporting Staff");
            int userChoice = Convert.ToInt32(Console.ReadLine());
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
            staff.Register(empId);
            Console.WriteLine("Staff successfully added..");
            return staff;
        }

        public static void  DisplayAstaff(List<Staff> staffList)
        {   
            Console.WriteLine("----EMPLOYEE DETAILS---");
            int selectedUser =  MenuActinoHelper.ShowStaffList(staffList);  
            try 
            {
                staffList[selectedUser].Display();
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
        }

        public static void  UpdateAStaff(List<Staff> staffList)
        {                    
            int selectedUser =  MenuActinoHelper.ShowStaffList(staffList); 
            try 
            {
                staffList[selectedUser].Update();
                Console.WriteLine("----SUCCESSFULLY UPADATED----");
                
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }    
        }

        public static void DisplayAllStaffs(List<Staff> staffList)
            {   
                Console.WriteLine("----EMPLOYEE DETAILS---");
                foreach (Staff staff in staffList)  
                {  
                    staff.Display();
                }  
            }

        public static void  DeleteAStaff(List<Staff> staffList)
        {
            int selectedUser =  MenuActinoHelper.ShowStaffList(staffList);
             try 
            {
                staffList[selectedUser] = null;
                staffList.RemoveAt(selectedUser);
                GC.Collect();                
                Console.WriteLine("----SUCCESSFULLY DELETED----");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }    
        }   
    }
}