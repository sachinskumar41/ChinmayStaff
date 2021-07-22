using System;

namespace staff
{
    public enum TypesOfStaffs
        {
            Teaching=1,
            Administrative,
            Supporting
        }
    class Staff
    {       
        public string Name {get;set;}
        public int EmpId {get;set;}
        public int Salary {get;set;}
        public TypesOfStaffs StaffType{get;set;}
    }
}    