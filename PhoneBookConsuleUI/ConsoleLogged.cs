using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookConsuleUI
{
    class ConsoleLogged
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to your new Contacts App!");
            Console.WriteLine();
        }
        public static void EnterUserInfoNote()
        {
            Console.WriteLine("Thank you for choosing My Contacts App!");
            Console.WriteLine();
            Console.WriteLine("Please enter your personal information.");
            Console.WriteLine();
        }
        public static void FirstContactNote()
        {
            Console.WriteLine("Now please create your first contact!");
            Console.WriteLine();
        }
        public static void NoContacts()
        {
            Console.WriteLine("No Contacts Yet");
            Console.WriteLine();
        }
        public static void InvalidEntry()
        {
            Console.WriteLine("Invaled Entry: must write 'true' or 'false'");
        }
        public static void InvalidEntryBase()
        {
            Console.WriteLine("Invalid Entry, Please Select Another Option.");
            Console.WriteLine();
        }
    }
}
