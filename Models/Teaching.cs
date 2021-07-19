using System;

namespace staff
{
    class Teaching: Staff
    { 
        public string Subject {get;set;}
        public int NoOfHrs {get;set;}
        public override void Register(int empId)
        {
            base.Register(empId);
            Console.WriteLine("Enter the subject that u teach");
            Subject = Console.ReadLine();
            Console.WriteLine("Enter the no. of teaching Hours that u have in a week");
            NoOfHrs = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {              
            TableDispaly tableDisplayObj = new TableDispaly();
            tableDisplayObj.PrintLine();
            tableDisplayObj.PrintRow("Name", "EmpId","Staff Type","Salary", "Subject","Teching hrs");
            tableDisplayObj.PrintLine();
            tableDisplayObj.PrintRow(Name, $"{EmpId}","Teching", $"{Salary}", Subject,$"{NoOfHrs}");
            tableDisplayObj.PrintLine();
            Console.WriteLine();
        }
        public override void Update()
        {
            Console.WriteLine("select the atribute that you want to change\n1.name\n2.salary\n3.Teaching subject\n4.No. of teaching hours in a week");
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
                    Console.WriteLine("Enter the new subject");
                    Subject = Console.ReadLine();
                    break; 
                case 4:
                    Console.WriteLine("Enter the time");
                    NoOfHrs = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("select a valid opyion");     
                    break;             
            }
            
        }
    }
}