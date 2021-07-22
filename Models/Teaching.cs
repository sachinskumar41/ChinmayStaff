using System;

namespace staff
{
    class Teaching: Staff
    { 
        public string Subject {get;set;}
        public int NoOfHrs {get;set;}
        public Teaching(string name,int empId,int salary,string subject,int teachingHours)
        {
            StaffType = TypesOfStaffs.Teaching;
            Name = name;
            EmpId = empId;
            Salary = salary;
            Subject = subject;
            NoOfHrs = teachingHours;
        }        
       
    }
}