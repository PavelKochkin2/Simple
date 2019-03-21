using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var godelPeople = new GodelPeople();
            foreach (var person in godelPeople)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}