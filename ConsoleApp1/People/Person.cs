using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.People
{
    public class Person
    {
        public string personName;
        public int personAge;
        public bool personHasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi! My name is " + personName + " and my age is " + personAge);
        }

    }
}