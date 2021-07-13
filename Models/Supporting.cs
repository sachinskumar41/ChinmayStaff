using System;

namespace staff
{
    class Supporting: Staff
    {
         
        public string Superior    
        {get;set;}
        public string Field
        {get;set;}

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter the Name of your superior");
            Superior = Console.ReadLine();
            Console.WriteLine("Enter the Supporting field");
            Field = Console.ReadLine();
        }
        public override void Display()
        {   
            base.Display();
            Console.WriteLine($"Staff type: Supporting staff");
            Console.WriteLine($"Name of superior: {Superior}");
            Console.WriteLine($"Supporting field: {Field}");
        }
    }
}