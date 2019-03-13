using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExe2
{
    class Box
    {
        private int Height { get; set; }
        private int Width { get; set; }
        private int Length { get; set; }
        public Box(int _height, int _width, int _length)
        {
            Height = _height;
            Width = _width;
            Length = _length;
        }
        public string GetSurfaceArea()
        {
            return $"Surface Area: {2 *Height * Width + 2 * Height * Length + 2 * Width * Length}\n";
        }
        public string GetVolume()
        {
            return $"Volume: {Length * Width * Height}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter height: ");
            int HEIGHT = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int WIDTH = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length: ");
            int LENGTH = int.Parse(Console.ReadLine());
            Box b1 = new Box(HEIGHT, WIDTH, LENGTH);
            Console.WriteLine(b1.SurfaceArea() + b1.Volume());
            Console.ReadLine();
            */
            int h = 0;

            int w = 0;

            int l = 0;



            h = GetData(h, "Height");

            w = GetData(w, "Width");

            l = GetData(l, "Length");



            Box b1 = new Box(h, w, l);



            Console.WriteLine(b1.GetSurfaceArea());

            Console.WriteLine(b1.GetVolume());



            Console.ReadLine();

        }



        static int GetData(int number, string info)

        {

            bool check = true;

            bool confirm = false;



            do

            {


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Please enter the {info} of the box: ");

                confirm = int.TryParse(Console.ReadLine(), out number);

                do

                {
                    if (number < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Error please try again" );
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Please enter the {info} on the box");
                        confirm = int.TryParse(Console.ReadLine(), out number);

                        if (!confirm)

                        {

                            Console.Clear();

                            Console.Write($"Error, that was not a valid number please try again\nPlease enter the {info} of the box: ");

                            confirm = int.TryParse(Console.ReadLine(), out number);

                        }
                    }

                } while (!confirm);


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{info} Set\n\n");

                break;



            } while (check);

            return number;
        }
    }
}
