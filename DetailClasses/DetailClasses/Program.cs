using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailClasses
{
    class Details

    {

        public string fname;

        public string lname;

        public string username;

        private string password;



        public string Fname { get { return fname; } set { fname = value; } }

        public string Lname { get { return lname; } set { lname = value; } }
        public string Username { get { return username; } set { username = value; } }

        private string Password { get { return password; } set { password = value; } }
       

        public Details(string _fname, string _lname, string _username, string _password)

        {

            Fname = _fname;

            Lname = _lname;

            Username = _username;

            Password = _password;

        }

        public string GetFullDetail()

        {

            return $"First Name: {Fname}\nLast Name: {Lname}\nUsername: {Username}\nPassword: {Password}";

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Details[] details = new Details[1];
            for (int i = 0; i < details.Length; i++)
            {
                Console.WriteLine("***********************************************\n\tPlease enter your animal details\n***********************************************");
                Console.Write("Enter your first name: ");
                string FirstName = Console.ReadLine();
                Console.Write("Enter the last name: ");
                string LastName = Console.ReadLine();
                Console.Write("Enter username: ");
                string USERNAME = Console.ReadLine();
                Console.Write("Enter the password: ");
                string PASSWORD = Console.ReadLine();
                Console.Clear();
                Details d1 = new Details(FirstName, LastName, USERNAME, PASSWORD);
                details[i] = d1;
            }

            for (int i = 0; i < details.Length; i++)
            {
                Console.WriteLine($"**********************************\n\tPerson {i + 1} details\n**********************************\n{details[i].GetFullDetail()}");
            }
            Console.ReadLine();



        }
    }
}
