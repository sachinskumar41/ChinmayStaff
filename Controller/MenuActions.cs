using System;
using System.Collections.Generic;

namespace staff
{
    class MenuActinos
    {
        public void AddStaff(List<dynamic> staffList,int empId)
        {
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            Console.WriteLine("Select your job type \n1.Teaching staff\n2.Admin. staff\n3.Supporting Staff");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch(userChoice) 
            {
                case 1:
                    Teaching teachObj = new Teaching();
                    teachObj.EmpId = empId;
                    teachObj.Register();
                    staffList.Add(teachObj);
                    break;
                case 2:
                    Administrative adminObj = new Administrative();
                    adminObj.EmpId = empId;
                    adminObj.Register();
                    staffList.Add(adminObj); 
                    break;
                case 3:
                    Supporting sprtObject = new Supporting();
                    sprtObject.EmpId = empId;
                    sprtObject.Register();
                    staffList.Add(sprtObject);
                    break;
                default:
                    Console.WriteLine("SELECT A VALID OPTION");
                    break;
            }
        }

        public void DisplayAllStaffs(List<dynamic> staffList)
        {   
            foreach (dynamic staff in staffList)  
            {  
                staff.Display();
            }  
        }
        public void DisplayAstaff(List<dynamic> staffList)
        {  
            int selectedUser = ShowStaffList(staffList);  
            try 
            {
                staffList[selectedUser - 1].Display();
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
        }

        public void UpdateAStaff(List<dynamic> staffList)
        {                    
            int selectedUser = ShowStaffList(staffList);  
            try 
            {
                staffList[selectedUser - 1].Update();
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }    
        }
        public void DeleteAStaff(List<dynamic> staffList)
        {
            int selectedUser = ShowStaffList(staffList);
             try 
            {
                staffList.RemoveAt(selectedUser-1);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }    

        }

        public int ShowStaffList(List<dynamic> staffList)
        {
            int selectedUser;
            int i = 1;
            Console.WriteLine("Selecte the Staff");
            foreach (dynamic staff in staffList)  
            {  
                Console.WriteLine($"{i}. {staff.Name}");
                i++;
            }
            selectedUser = Convert.ToInt32(Console.ReadLine());
            return selectedUser;
        }
    }
}