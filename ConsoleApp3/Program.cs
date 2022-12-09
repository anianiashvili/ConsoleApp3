using System;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            int myNumber1 = 25;
            int myNumber2 = 525;
            Console.WriteLine(myNumber1 + myNumber2);
            Console.WriteLine("\ntask2");
            double test2 = Test1(23, 25);
            Console.WriteLine(test2);

            Console.WriteLine("\ntask4");
            double myBmi = FormulaBmi(46, 169);
            Console.WriteLine(myBmi);

            Console.WriteLine("\ntask5");
            Console.WriteLine("enter your name");
            string userName=Console.ReadLine();
            Console.WriteLine("\nenter your surname");
            string userSurname=Console.ReadLine();
            Console.WriteLine("\nage");
            string userAge=Console.ReadLine();
            Console.WriteLine("\nenter Weight");
            string userWeight = Console.ReadLine();
            Console.WriteLine("\nenter Bmi");
            string userBmi=Console.ReadLine();
            Console.WriteLine("your name is " + userName + "\nyour surname is " + userSurname + "\nyour Age is " + userAge + "\nyour weight is " + userWeight + "\nyou Bmi is " + userBmi);
        }
        static double Test1(double n1, double n2)

        {
            double sum = n1 + n2;
            return sum;
        }
        static double FormulaBmi(double weight, double height)
        {
            double result = weight / (height * height / 10000);
            return result;
        }
    }
}
