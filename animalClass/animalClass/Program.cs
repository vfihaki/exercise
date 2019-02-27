using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalClass
{
    class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string IDNo { get; set; }

        public Animal(string name, string age, string idNo)
        {
            Name = name;
            Age = age;
            IDNo = idNo;

        }
        public string DisplayAnimal()
        {
            return $"Animal Name: {Name}\nAnimal Age: {Age}\nAnimal ID Number: {IDNo}\n\n ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[5];
            for(int i = 0; i< animal.Length; i ++)
            {
                Console.WriteLine("***********************************************\n\tPlease enter your animal details\n***********************************************");
                Console.Write("Enter your animal's name: ");
                string Aniname = Console.ReadLine();
                Console.Write("Enter the animal's age: ");
                string Aniage = Console.ReadLine();
                Console.Write("Enter ID Number for the animal: \n");
                string AniID = Console.ReadLine();
                Console.Clear();
                Animal a1 = new Animal(Aniname, Aniage, AniID);
                animal[i] = a1;
            }

            for(int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine($"**********************************\n\tAnimal {i + 1} details\n**********************************\n{animal[i].DisplayAnimal()}" );
            }
            Console.ReadLine();
        }
    }
}
