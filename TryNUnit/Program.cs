using System;
using NUnit.Framework;

namespace TryNUnit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string FriendlyMainClaim()
        {
            return "I swear I'm nice!";
        }

        static string InternalFriendlyMainClaim()
        {
            return "Psst I'm nice";
        }
    }

    public class Stomach
    {
        public string Growl()
        {
            return "grrr";
        }
    }
}
