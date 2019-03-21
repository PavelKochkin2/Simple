using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var pres1 = PresidentSingleton.GetInstance();
            Console.WriteLine(pres1.GetHashCode());
            var pres2 = PresidentSingleton.GetInstance();
            Console.WriteLine(pres2.GetHashCode());

            Console.ReadKey();
        }
    }

    class PresidentSingleton
    {
        private static PresidentSingleton _instance;

        private PresidentSingleton() { }

        public static PresidentSingleton GetInstance()
        {
            if(_instance == null)
                _instance = new PresidentSingleton();
            return _instance;
        }
    }
}