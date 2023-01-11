//Program Program.cs
//Programmer: Rob Garner (rgarner7@cnm.edu)
//Date: 10 Jan 2023
//Purpose: Demo programming in C#

namespace HelloWorldNoTopLevel
{
    internal class Program
    {
        //HelloWorldNoTopLevel.Program.Main()
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Inputing strings
            Console.Write("PLease enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            //Inputing numbers
            Console.Write("Please enter num1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter num2: ");
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("The sum is " + sum + ".");

            VolumeOfCone();
        }

        static void VolumeOfCone()
        {
            //Volume of a cone
            double radius = GetRadiusFromUser();
            double height = GetHeightFromUser();
            double volume = CalcVolumeOfCone(radius, height);

            Console.WriteLine($"The volume is {volume} m3.");
        }

        static double GetRadiusFromUser()
        {
            Console.Write("Please enter radius in meters: ");
            double radius = double.Parse(Console.ReadLine());
            return radius;
        }

        static double GetHeightFromUser()
        {
            Console.Write("Please enter height in meters: ");
            double height = double.Parse(Console.ReadLine());
            return height;
        }

        static double CalcVolumeOfCone(double radius, double height)
        {
            double volume = Math.PI * Math.Pow(radius, 2) * height / 3;
            return volume;
        }
       
    }
}