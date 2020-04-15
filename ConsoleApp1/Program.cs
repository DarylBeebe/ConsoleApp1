using System;
using ConsoleApp1.People;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.personName = "John";
            person.personAge = 28;
            person.personHasPet = true;

            person.Greeting();

         
            int result = Calculator.Add(5, 10);
            Console.WriteLine("\r" + "\n" + "the calculated answer is: " + result) ;
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("First line");
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Next line");


            /*    Console.WriteLine("Hello World!");

                const string myName = "Daryl";
                string nameUp = myName.ToUpper();
                string tempName;

                int numberA = 61;


                Console.WriteLine(myName + nameUp);
                Console.WriteLine(numberA);
                Console.WriteLine(nameUp);

                */
        }
    }
}
