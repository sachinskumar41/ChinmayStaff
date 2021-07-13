using System;

namespace staff
{
    class Administrative: Staff
    {
         
        public string AdminNo    
        {get;set;}
        public string AdmDprt   
        {get;set;}
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter the admin no.");
            AdmDprt = Console.ReadLine();
            Console.WriteLine("Enter the adminstrating Department");
            AdminNo = Console.ReadLine();
        }
        public override void Display()
        {   
            base.Display();
            Console.WriteLine($"Staff type: Administrative staff");
            Console.WriteLine($"Administrative no: {AdminNo}");
            Console.WriteLine($"Administrating department: {AdmDprt}");
        }
    }
}