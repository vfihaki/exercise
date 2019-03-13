using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1S2Array
{
    class Program
    {
     //   static void Main(string[] args)
     //   {
            /*
            string[] names = new string[10];
            

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("***********************************************\n\tPlease enter your animal details\n***********************************************");
                Console.Write("Enter your name: ");
                string Name = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names}");
            }
            Console.ReadLine();
            
            111111
            string[] name = new string[];

            for (int i = 0; i < name.Length; i++)

            {

                Console.WriteLine($"Please enter name {i +1}: ");

                name[i] = Console.ReadLine();

                Console.Clear();
            }


            Console.WriteLine($"{name[0]}");
            Console.WriteLine($"{name[1]}");
            Console.WriteLine($"{name[2]}");
            Console.WriteLine($"{name[3]}");
            Console.WriteLine($"{name[4]}");
         /*   Console.WriteLine($"{name[5]}");
            Console.WriteLine($"{name[6]}");
            Console.WriteLine($"{name[7]}");
            Console.WriteLine($"{name[8]}");
            Console.WriteLine($"{name[9]}");*/

            struct Student
        {
            public string Name;
        }

        static void Main(string[] args)
        {
           // int numberOfStudents;
            Name[] names;
           // string input;
            /*
            Console.WriteLine("How many students are there?");
            input = Console.ReadLine();
            numberOfStudents = int.Parse(input);

            names = new Student[numberOfStudents];

    */
            for (int i = 0; i < names.Length; i++)
            {
                Name s;
                Console.WriteLine("Please enter student {0}'s name", (i + 1));
                s.Name = Console.ReadLine();
                names[i] = s;
            }
            Array.Sort<z>(names); 
            for (int i = 0; i < names.Length; i++)
            {

                Console.WriteLine(names[i].Name);
            }
        }





       
        
    }
}
