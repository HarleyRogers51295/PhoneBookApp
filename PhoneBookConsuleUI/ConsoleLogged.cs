using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookConsuleUI
{
    class ConsoleLogged
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to your new Contacts App!\n");
        }
        public static void EnterUserInfoNote()
        {
            Console.WriteLine("Please enter your personal information.\n");
        }
        public static void FirstContactNote()
        {
            Console.WriteLine("Now please create your first contact!\n");
        }
        public static void NoContacts()
        {
            Console.WriteLine("No Contacts Yet\n");
        }
        public static void InvalidEntry()
        {
            Console.WriteLine("Invaled Entry: must write 'true' or 'false'");
        }
        public static void InvalidEntryBase()
        {
            Console.WriteLine("Invalid Entry, Please Select Another Option.\n");
        }
    }
}
