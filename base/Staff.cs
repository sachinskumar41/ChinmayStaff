using System;

namespace staff
{
    class Staff
    {       
        public string Name {get;set;}
        public int EmpId {get;set;}
        public int Salary {get;set;}
        public string StaffType {get;set;}
        public virtual void Display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------EPLOYEE DETAIALS------");
            Console.WriteLine($"Employee name: {Name}");
            Console.WriteLine($"Employee id: {EmpId}"); 
            Console.WriteLine($"Employee salary:Rs.{Salary}");
        }
        public virtual void Register(int empId)
        {
            EmpId = empId;
            Console.WriteLine("\n\nEnter ur name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter ur Salary");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Update()
        {
            Console.WriteLine("\n\nEnter the new name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the new Salary");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
    }
}    