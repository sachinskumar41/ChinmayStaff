using System;

namespace staff
{
    class Staff
    {       
        public string Name {get;set;}
        public int EmpId {get;set;}
        public int Salary {get;set;}
        public string StaffType {get;set;}

        public virtual void Display(){}
        
        public virtual void Register(int empId)
        {
            EmpId = empId;
            Console.WriteLine("\n\nEnter ur name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter ur Salary");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Update() {}
    }
}    