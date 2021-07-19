using System;
using System.Collections.Generic;

namespace staff
{
    class MenuActinos
    {   
        public void AddStaff(Staff staff,int empId)
        {
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            staff.Register(empId);
            Console.WriteLine("Staff successfully added..");
        }

        public void UpdateAStaff(Staff staff)
        {                    
            try 
            {
                staff.Update();
                Console.WriteLine("Updated succesfully...");
            }
            catch(System.NullReferenceException e)
            {
                Console.WriteLine("There is no staff to update:",e);
            }    
        }

        public void DisplayAStaff(Staff staff)
        {
            try 
            {
                staff.Display();
            }
            catch(System.NullReferenceException e)
            {
                Console.WriteLine("There is no staff to display:",e);
            }    

        }
        
    }
}