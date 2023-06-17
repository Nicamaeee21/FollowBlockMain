
using System;
using System.Collections.Generic;using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBlockMain
{
    public class Fmenu
    {
        public string Welcome()
        {
            Console.WriteLine("WELCOME!");
            Console.WriteLine("1 - Log In");
            Console.WriteLine("2 - Sign Up");
            Console.WriteLine("x - exit");
            Console.WriteLine("Enter: ");
            string choice = Console.ReadLine();

            return choice;
        }

        public void ShowProfile(Profiles pl)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Name: {pl.proname} {pl.prosname}");
            Console.WriteLine($"Following: {pl.following}");
            Console.WriteLine($"Followers: {pl.followers}");
            Console.WriteLine($"Blocked: {pl.blocked}");
        }

        public string Screen()
        {

            Console.WriteLine("1 = Open Following");
            Console.WriteLine("2 = Open Block");
            Console.WriteLine("3 = Search");
            Console.WriteLine("x = exit ");
            Console.WriteLine("Enter Here: ");
            string chc = Console.ReadLine();

            return chc;
        }
    }
}
