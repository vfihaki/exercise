using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees
{
    class Employee
    {
        public string FullName { get; set; }
        public double PhoneNum { private get; set; }
        public string Email { get; set; }
        public string IRDnum { get; set; }
        public double BankAccNum { private get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public Employee(string _fullname, double _phonenum, string _email, string _irdnum, double _bankaccnum, string _username, string _password)
        {
            FullName = _fullname;
            PhoneNum = _phonenum;
            Email = _email;
            IRDnum = _irdnum;
            BankAccNum = _bankaccnum;
            UserName = _username;
            Password = _password;
        }
        public string CardDetail()

        {

            return $"Name: {FullName}\nPhone Number: {PhoneNum}\nEmail: {Email}\nUsername: {UserName}\nPassword: {Password}";

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[5];
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine("***********************************************\n\tPlease enter your Credit Card details\n***********************************************");
                Console.Write("Enter your full name: ");
                string Fullname = Console.ReadLine();
                Console.Write("Enter phone number: ");
                double PhoneNumber = double.Parse(Console.ReadLine());
                Console.Write("Enter your email address: ");
                string EmailAdd = Console.ReadLine();
                Console.Write("Enter your IRD number: ");
                string IRD = Console.ReadLine();
                Console.Write("Enter Bank account number: ");
                double BankACCNum = double.Parse(Console.ReadLine());
                Console.Write("Enter your username: ");
                string UserName = Console.ReadLine();
                Console.Write("Enter your password: ");
                string PassWord = Console.ReadLine();
                Console.Clear();
                Employee e1 = new Employee(Fullname, PhoneNumber, EmailAdd, IRD, BankACCNum, UserName, PassWord );
                employee[i] = e1;
            }

            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Hi {employee[i].FullName} here is you information\n******************************************\n{employee[i].CardDetail()}\n******************************************");
            }
            Console.ReadLine();
        }
    }
}
