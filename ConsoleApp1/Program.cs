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
