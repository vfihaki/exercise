using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UsernameID { get; set; }
        public string Password { get; set; }
        public string Emergency { get; set; }
        public Student(string _name, string _email, string _address, string _usernameid, string _password, string _emergency)
        {
            Name = _name;
            Email = _email;
            Address = _address;
            UsernameID = _usernameid;
            Password = _password;
            Emergency = _emergency;
        }
      
        int[] result = new int[4];

        public int[] Results
        {
            get { return result; }
            set { result = value; }
        }
        public string Studentinfo()
        {
            double average = 0;
            foreach (int x in Results)
                average += x;
            average = average / Results.Length;
            return $" Name: {Name}\nID: {UsernameID}\nResult 1: {Results[0]}\nResult 2: {Results[1]}\nResult 3: {Results[2]}\nResult 3: {Results[4]}\nAverage: {average}";
        }
    }
    class Program
    {

        static void Main(string[] args)

        {

           

            Console.Write("Please enter the students name: ");

            string name = Console.ReadLine();

            CheckString(name);

            Console.Write("Please enter the students Email Address: ");

            string email = Console.ReadLine();

            CheckString(email);
            Console.Write("Please enter the students Address: ");

            string address = Console.ReadLine();

            CheckString(address);
            Console.Write("Please enter the students ID: ");

            string id = Console.ReadLine();

            CheckString(id);
            
            Console.Write("Please enter the students password: ");

            string password = Console.ReadLine();

            CheckString(password);

            Console.Write("Please enter the students emergency contact number: ");

            string emergency = Console.ReadLine();

            CheckString(emergency);
            Console.WriteLine("Complete");
            Student s1 = new Student(name, email, address, id, password, emergency);
            Console.WriteLine(s1.Studentinfo());

            Console.ReadLine();
        }



        static string CheckString(string input)

        {

            do

            {

                if (input == "" || input == null)

                {

                    Console.Write("You need to enter a name, please enter the students name: ");

                    input = Console.ReadLine();

                }



            } while (input == "");

            return input;

        }
        static int Checkint(int input)

        {

            do

            {

                if (input > 10000000000 && input < 999999999999 )

                {

                    Console.Write("You need to enter a name, please enter the student emergency contact number: ");

                    input = int.Parse(Console.ReadLine());

                }



            } while (input > 10000000000 && input < 999999999999);

            return input;
        }
    }
}
