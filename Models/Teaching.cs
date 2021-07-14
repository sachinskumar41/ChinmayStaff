using System;

namespace staff
{
    class Teaching: Staff
    { 
        public string Subject {get;set;}
        public int NoOfHrs {get;set;}
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter the subject that u teach");
            Subject = Console.ReadLine();
            Console.WriteLine("Enter the no. of teaching Hours that u have in a week");
            NoOfHrs = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {   
            base.Display();
            Console.WriteLine($"Staff type: Teaching staff");
            Console.WriteLine($"Teaching subject: {Subject}");
            Console.WriteLine($"No. of teaching hours in a week: {NoOfHrs} Hrs.");
        }
        public override void Update()
        {
            base.Update();
            Console.WriteLine("Enter the new subject that u teach");
            Subject = Console.ReadLine();
            Console.WriteLine("Enter the new no. of teaching Hours that u have in a week");
            NoOfHrs = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}