using System;
namespace staff
{
    class Administrative: Staff
    {         
        public string AdminNo {get;set;}
        public string AdmDprt {get;set;}

        public Administrative(string name,int empId,int salary,string admNo,string admDprt)
        {
            StaffType = TypesOfStaffs.Administrative;
            Name = name;
            EmpId = empId;
            Salary = salary;
            AdminNo = admNo;
            AdmDprt = admDprt;
        }
    }
}