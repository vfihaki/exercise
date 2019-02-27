using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String Code;



            Boolean menu = true;

            do

            {

                Console.WriteLine("------Welcome to my application-------");

                Console.WriteLine("You may choose from the following Switch Practice Exercises below\n");

                Console.WriteLine("Question 1:" + " CODE: Q1");
                Console.WriteLine("Question 2:" + " CODE: Q2");
                Console.WriteLine("Question 3:" + " CODE: Q3");
                Console.WriteLine("Question 4:" + " CODE: Q4");
                Console.WriteLine("Question 5:" + " CODE: Q5");
                Console.WriteLine("Question 6:" + " CODE: Q6");
                Console.WriteLine("Question 7:" + " CODE: Q7");
                Console.WriteLine("Question 8:" + " CODE: Q8");
                Console.Write("\nPlease enter the CODE:");
                Code = Console.ReadLine().ToUpper();

                if (Code == "Q1")
                {
                    question1();
                }
                else if (Code == "Q2")
                {
                    question2();
                }
                else if (Code == "Q3")
                {
                    question3();
                }
                else if (Code == "Q4")
                {
                    question4();
                }
                else if (Code == "Q5")
                {
                    question5();
                }
                else if (Code == "Q6")
                {
                    question6();
                }
                else if (Code == "Q7")
                {
                    question7();
                }
                else if (Code == "Q8")
                {
                    question8();
                }
                else
                {
                    Console.WriteLine("Wrong Code, please try again");
            
                }
                Console.WriteLine("\n\nDo you want to choose another Exercise Y/N ?");

                var check = Console.ReadLine().ToUpper();

                if (check == "N")

                { menu = false; }

                Console.Clear();
                Console.Clear();

            } while (menu);

        }
        public static void question1()
        { 
        Console.WriteLine("Hello");
            Console.WriteLine("Hamiora Taurima");
            Console.ReadLine();

        }
        public static void question2()
        {
            int sum1 = 74 + 36;
            Console.WriteLine(sum1);
            Console.ReadLine();
            
        }
        public static void question3()
        {
            int sum2 = 50 / 3;
            Console.WriteLine(sum2);
            Console.ReadLine();
        }
        public static void question4()
        {
            Console.WriteLine("Input first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            int num2 = int.Parse(Console.ReadLine());

           

            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
            Console.Read();
        }
        public static void question5()
        {
            Console.WriteLine("Input a number: ");
            int num = int.Parse(Console.ReadLine());

            for( int i = 1; i <= 10; i ++ )
            {
                
                Console.WriteLine($"{num} x {i} = {i * num} ");
            }
            
            Console.ReadLine();
        }
        public static void question6()
        {
            Console.WriteLine("Input a number: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine(" Perimeter = {0}", 2 * Math.PI * radius);
            Console.WriteLine("Area = {0}", Math.PI * (radius*radius) );
            Console.ReadLine();

        }
        public static void question7()
        {
            int A = 10;
            int B = 20;
            Console.WriteLine($"Before swap: A = {A}\tB = {B}\n");

            int C = A;
            A = B;
            B = C;
            Console.WriteLine($"After swap: A = {A}\tB = {B}");
            Console.ReadLine();
        }
        public static void question8()
        {
            int[] arr = new int[100];
            Random rand = new Random();
            for(int i = 0; i < 100; i ++)
            {
                arr[i] = rand.Next(1000, 9999);
            }
            for(int i = 1; i <= arr.Length; i ++)
            {
                Console.Write(arr[i + 1] + "\t\t\t");
                if(i%2 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
