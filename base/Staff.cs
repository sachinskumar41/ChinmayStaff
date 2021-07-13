using System;

namespace staff
{
    class Staff
    {
        
        public string Name    
        {get;set;}
        public string EmpId    
        {get;set;}
        public int Salary
        {get;set;}
        public virtual void Display()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("------EPLOYEE DETAIALS------");
            Console.WriteLine($"Employee name: {Name}");
            Console.WriteLine($"Employee id: {EmpId}"); 
            Console.WriteLine($"Employee salary:Rs.{Salary}");

        }
        public virtual void Register()
        {
            Console.WriteLine("\n\nEnter ur name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter ur Employee Id");
            EmpId = Console.ReadLine();
            Console.WriteLine("Enter ur Salary");
            Salary = Convert.ToInt32(Console.ReadLine());


        }
    }
}    