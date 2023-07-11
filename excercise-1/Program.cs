using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eId;
            string eName;
            char eGender;
            double eSalary;
            DateTime edoj;
           

            Console.WriteLine("Enter ID ");
            eId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            eName = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            eGender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Employee salary");
            eSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            edoj = DateTime.Parse(Console.ReadLine());
            if (eSalary > 90000) 
            {
                Console.WriteLine("you have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("tax will be 15%");
            }
            Console.WriteLine("ID \t Employee Name\t Employee Gender \t Employee Salary \t Date of Joining ");

            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine(eId+"\t\t"+eName+"\t\t"+eGender+"\t\t"+eSalary+"\t\t\t"+edoj);
            Console.WriteLine("\n You need to pay___________");
            Console.ReadKey();

        }
    }
}
