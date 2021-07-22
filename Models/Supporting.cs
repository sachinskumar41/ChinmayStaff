using System;

namespace staff
{
    class Supporting: Staff
    {
        public string Superior {get;set;}
        public string Field {get;set;}

        public Supporting(string name,int empId,int salary,string superior,string supportingField)
        {
            StaffType = TypesOfStaffs.Supporting;
            Name = name;
            EmpId = empId;
            Salary = salary;
            Superior = superior;
            Field = supportingField;
        }
    }
}