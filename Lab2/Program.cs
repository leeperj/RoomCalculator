using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
            while (repeat == "y" || repeat == "Y")
            {
                //input Get 2 numbers from user
                Console.WriteLine("Welcome to the Room Calculator.");
                Console.WriteLine("Enter the length of the room.");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the room.");
                double width = double.Parse(Console.ReadLine());

                //processing calculate area/perimeter

                double area = length * width;
                double perimeter = (length + length) + (width + width);
                //assuming the height of the room is 10 feet.
                double volume = (length * width * 10);


                //displays area and perimeter
                Console.WriteLine("The area is " + area);
                Console.WriteLine("The perimeter is " + perimeter);
                Console.WriteLine("The volume is " + volume);
                Console.WriteLine("Would you like to measure another room? y or n");
                repeat = Console.ReadLine();
            }
        }
    }
}
