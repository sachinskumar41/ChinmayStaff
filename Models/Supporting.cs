using System;

namespace staff
{
    class Supporting: Staff
    {
        public string Superior {get;set;}
        public string Field {get;set;}
        public override void Register(int empId)
        {
            base.Register(empId);
            Console.WriteLine("Enter the Name of your superior");
            Superior = Console.ReadLine();
            Console.WriteLine("Enter the Supporting field");
            Field = Console.ReadLine();
        }
        public override void Display()
        {   
            
           TableDisplay.PrintLine();
           TableDisplay.PrintRow("Name", "EmpId","Staff Type","Salary", "Superior","Supporting field");
           TableDisplay.PrintLine();
           TableDisplay.PrintRow(Name, $"{EmpId}","Supporting", $"{Salary}", Superior,Field);
           TableDisplay.PrintLine();
            Console.WriteLine();
        }
        public override void Update()
        {
            Console.WriteLine("select the atribute that you want to change\n1.name\n2.salary\n3.Name of superior\n4.Supporting field");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch(userChoice)
            {
                case 1:
                    Console.WriteLine("\n\nEnter the new name");
                    Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter the new Salary");
                    Salary = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter the new superior");
                    Console.ReadLine();
                    break; 
                case 4:
                    Console.WriteLine("Enter the new Supporting field");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("select a valid opyion");     
                    break;             
            }
        }
    }
}