using System;

namespace HarshaBank.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** Harsha Bank ****************");
            Console.WriteLine("::Login Page::");

            string userName = null, password = null;
            Console.WriteLine("");

            Console.Write("UserName:");
            userName = Console.ReadLine();

            if (userName != "")
            {
                Console.Write("Password:");
                password = Console.ReadLine();

            }

            if (userName == "system" && password == "manager")
            {
                Console.WriteLine("TO DO: Main menu here");
            }

            Console.WriteLine("Thank you! Visit Again");
        }
    }
}
