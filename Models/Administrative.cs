using System;

namespace staff
{
    class Administrative: Staff
    {         
        public string AdminNo {get;set;}
        public string AdmDprt {get;set;}
        
        public override void Register(int empId)
        {
            base.Register(empId);
            Console.WriteLine("Enter the admin no.");
            AdmDprt = Console.ReadLine();
            Console.WriteLine("Enter the adminstrating Department");
            AdminNo = Console.ReadLine();
        }

        public override void Display()
        {   
            TableDispaly tableDisplayObj = new TableDispaly();
            tableDisplayObj.PrintLine();
            tableDisplayObj.PrintRow("Name", "EmpId","Staff Type","Salary", "Admin. No.","Adminisrating Dprtmnt.");
            tableDisplayObj.PrintLine();
            tableDisplayObj.PrintRow(Name, $"{EmpId}","Administrative", $"{Salary}", AdminNo,AdmDprt);
            tableDisplayObj.PrintLine();
            Console.WriteLine();
        }

        public override void Update()
        {
            Console.WriteLine("select the atribute that you want to change\n1.name\n2.salary\n3.Administrative no\n4.Administrating department");
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
                    Console.WriteLine("Enter the new Admin no.");
                    AdminNo =  Console.ReadLine();
                    break; 
                case 4:
                    Console.WriteLine("Enter the new Department");
                    AdmDprt = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("select a valid opyion");     
                    break;             
            }
        }
    }
}