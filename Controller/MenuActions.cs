using System;
using System.Collections.Generic;

namespace staff
{
    class MenuActinos
    {
        public string StaffType {get;set;}
        public Staff AddStaff(int empId)
        {
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            dynamic staff = 0;
            
            switch(StaffType) 
            {
                case "Teaching":
                    Teaching teachObj = new Teaching();
                    teachObj.EmpId = empId;
                    teachObj.Register();
                    staff = teachObj;
                    break;
                case "Administrative":
                    Administrative adminObj = new Administrative();
                    adminObj.EmpId = empId;
                    adminObj.Register();
                    staff = adminObj;
                    break;
                case "Supporting":
                    Supporting sprtObject = new Supporting();
                    sprtObject.EmpId = empId;
                    sprtObject.Register();
                    staff = sprtObject;
                    break;
                default:
                    Console.WriteLine("SELECT A VALID OPTION");
                    break;
            }
            Console.WriteLine("Staff successfully added..");
            return staff;
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