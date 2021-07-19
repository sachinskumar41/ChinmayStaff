using System;
using System.Collections.Generic;

namespace staff
{    
    class MenuActinos
    {   
        public int EmpId = 0;
        public void AddStaff(Staff staff,int empId, List<Staff> staffList)
        {
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            staff.Register(empId);
            Console.WriteLine("Staff successfully added..");
            staffList.Add(staff);
        }

        public void DisplayAstaff(List<Staff> staffList)
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

        public void UpdateAStaff(List<Staff> staffList)
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

        public void DisplayAllStaffs(List<Staff> staffList)
            {   
                foreach (Staff staff in staffList)  
                {  
                    staff.Display();
                }  
            }

        public void DeleteAStaff(List<Staff> staffList)
        {
            int selectedUser = ShowStaffList(staffList);
             try 
            {
                staffList[selectedUser-1] = null;
                staffList.RemoveAt(selectedUser-1);
                GC.Collect();                
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }    
        }   

        public int ShowStaffList(List<Staff> staffList)
        {
            int selectedUser;
            int i = 1;
            Console.WriteLine("Selecte the Staff");
            foreach (Staff staff in staffList)  
            {  
                Console.WriteLine($"{i}. {staff.Name}");
                i++;
            }
            selectedUser = Convert.ToInt32(Console.ReadLine());
            return selectedUser;
        }           
    }
}