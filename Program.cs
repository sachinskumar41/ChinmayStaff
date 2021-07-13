using System;

namespace staff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            Console.WriteLine("Select your job type \n1.Teaching staff\n2.Admin. staff\n3.Supporting Staff");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch(userChoice) 
            {
                case 1:
                    Teaching techObj = new Teaching();
                    techObj.Register();
                    techObj.Display();
                    break;
                case 2:
                    Administrative adminObj = new Administrative();
                    adminObj.Register();
                    adminObj.Display();
                    break;

                case 3:
                    Supporting supportingObj = new Supporting();
                    supportingObj.Register();
                    supportingObj.Display();
                    break;
                default:
                    Console.WriteLine("SELECT A VALID OPTION");
                    break;
            }
        }
    }
    
     
}
