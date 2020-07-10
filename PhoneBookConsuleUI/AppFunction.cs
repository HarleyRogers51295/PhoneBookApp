using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PhoneBookConsuleUI
{
    public class AppFunction
    {


        /***********************INTRO*********************************/
        public static void Intro()
        {
            ConsoleLogged.WelcomeMessage();
            do
            {
                ConsoleLogged.EnterUserInfoNote();
                UserInfoInput();
                ConsoleLogged.FirstContactNote();
                AddContact();
            }while (Contact.ContactsList == null);
        }

        /*************************EXECUTE*******************************/
        public static void Execute()
        {
            Contact contact = new Contact();

            string choice;
            string[] CreateOrExit = { "1. Create New Contact", "\n2. View Favorites ", "\n3. View Contacts", "\n4. User Info", "\n5. Exit Program" };
            do
            {
                Console.WriteLine("Enter '1' to create contact. \nEnter '2' to View favorites. \nEnter '3' to view All contacts. \nEnter '4' View/Update Your Info. \nEnter '5' To Exit Program ");
                CreateOrExit[0] = "1";
                CreateOrExit[1] = "2";
                CreateOrExit[2] = "3";
                CreateOrExit[3] = "4";
                CreateOrExit[4] = "5";
                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == CreateOrExit[0])
                {
                    AddContact();
                }
                else if (choice == CreateOrExit[1])
                {
                    ListFaveContact();
                }
                else if (choice == CreateOrExit[2])
                { 
                    ListRegContact();
                }
                else if (choice == CreateOrExit[3])
                {
                    UserInformation();
                }
               
            } while (choice != CreateOrExit[4]);

            
                
        }
        /***********************USER INFO****************************/
        public static void UserInformation()
        {

            ObjectIDGenerator obj = new ObjectIDGenerator();
            bool isFirstTime;
            

            Console.WriteLine("Your Information\n");
            foreach (UserInfo user in UserInfo.userInfo)
            {
                long theID = obj.GetId(user, out isFirstTime);
                Console.WriteLine($"Name: {user.FirstName} {user.LastName}\nPhone Number: {user.NumberFormatted}" +
                    $"\nAddress: {user.StreetAddress}\n{user.City}, {user.State} {user.Zip}\nBirthday: {user.BirthdayFormatted}\n");
                Console.WriteLine($"User ID: {theID - 1}\n");
            }
            string choice;
            string[] updateUserInfo = { "(1) Update User Infor", "(2) Exit" };

            do
            {
                Console.WriteLine("Do you want to (1) Update Your Information, (2) Go back");
                updateUserInfo[0] = "1";
                updateUserInfo[1] = "2";

                choice = Console.ReadLine();

                if (choice == updateUserInfo[0])
                {
                    UserInfoUpdate();
                }
            } while (choice != updateUserInfo[1]);

        }
        public static void UserInfoInput()
        {
            ObjectIDGenerator obj = new ObjectIDGenerator();
            bool isFirstTime;
            UserInfo user = new UserInfo();
            long theID = obj.GetId(user, out isFirstTime);
            Console.WriteLine("Enter All Fields");
            Console.WriteLine();
            Console.Write("Please enter your first name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            user.LastName = Console.ReadLine();
            Console.Write("Please enter your 10 digit phone number: ");
            user.NumberFormatted = Console.ReadLine();
            Console.Write("Please enter your street address: ");
            user.StreetAddress = Console.ReadLine();
            Console.Write("Please enter your city: ");
            user.City = Console.ReadLine();
            Console.Write("Please enter your state: ");
            user.State = Console.ReadLine();
            Console.Write("Please enter your zip code: ");
            user.Zip = Console.ReadLine();
            Console.Write("Please enter your birthday(Ex. 01012020): ");
            user.BirthdayFormatted = Console.ReadLine();
            Console.WriteLine($"User ID: {theID - 1}\n");
            UserInfo.userInfo.Add(user);
        }
        public static void UserInfoUpdate()
        {
            UserInfo user = new UserInfo();
            Console.WriteLine("Update Your Info: Enter Your ID Number");
            int userInput = int.Parse(Console.ReadLine());
            var userUpdate = UserInfo.userInfo[userInput];
            Console.WriteLine("Enter All Fields");
            Console.WriteLine();
            Console.Write("Please enter your first name: ");
            userUpdate.FirstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            userUpdate.LastName = Console.ReadLine();
            Console.Write("Please enter your 10 digit phone number: ");
            userUpdate.NumberFormatted = Console.ReadLine();
            Console.Write("Please enter your street address: ");
            userUpdate.StreetAddress = Console.ReadLine();
            Console.Write("Please enter your city: ");
            userUpdate.City = Console.ReadLine();
            Console.Write("Please enter your state: ");
            userUpdate.State = Console.ReadLine();
            Console.Write("Please enter your zip code: ");
            userUpdate.Zip = Console.ReadLine();
            Console.Write("Please enter your birthday(Ex. 01012020): ");
            userUpdate.BirthdayFormatted = Console.ReadLine();
            UserInfo.userInfo.Remove(user);
        }
        /************************FAVORATES OUTPUT***************/
        public static void ListFaveContact()
        {
            Console.WriteLine("Favorite Contacts\n");

            bool isEmpty = !Favorite.FavoritesList.Any();
            if (isEmpty)
            {
                ConsoleLogged.NoContacts();
            }

            ObjectIDGenerator obj = new ObjectIDGenerator();
            bool isFirstTime;

            foreach (Contact contact in Favorite.FavoritesList)
            {
                long theID = obj.GetId(contact, out isFirstTime);
                Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} \nPhone Number: {contact.NumberFormatted}" +
                    $"\nAddress:\n{contact.StreetAddress} \n{contact.City}, {contact.State} {contact.Zip} " +
                    $"\nBirthday: {contact.BirthdayFormatted}");
                Console.WriteLine($"Contact ID: {theID - 1}\n");
                
            }
            string choice;
            string[] RemoveExit = { "1. Remove Contact From Favorites List", "2. Update Contact", "3. Go back" };

            do
            {
                Console.WriteLine("Do you want to (1) Remove Contact From Favorites List, (2) Update Contact, (3) Go back");
                RemoveExit[0] = "1";
                RemoveExit[1] = "2";
                RemoveExit[2] = "3";

                choice = Console.ReadLine();

                if (choice == RemoveExit[0])
                {
                    Console.WriteLine("Remove contact from favorites: Enter Contact's ID number");
                    int userInput = int.Parse(Console.ReadLine());
                    Favorite.FavoritesList.Remove(Favorite.FavoritesList[userInput]);
                    Console.WriteLine($"Contact Removed\n");
                }
                else if (choice == RemoveExit[1])
                {
                    AddContact();
                    ListRegContact();
                }


            } while (choice != RemoveExit[2]);
        }

        /******************CONTACTS OUTPUT**********************/

        public static void ListRegContact()
        {
            Console.WriteLine("All Contacts\n");

            bool isEmpty = !Contact.ContactsList.Any();
            if (isEmpty)
            {
                ConsoleLogged.NoContacts();
            }

            ObjectIDGenerator obj = new ObjectIDGenerator();
            bool isFirstTime;


            foreach (Contact contact in Contact.ContactsList)
            {
                long theID = obj.GetId(contact, out isFirstTime);
                Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} \nPhone Number: {contact.NumberFormatted}" +
                    $"\nAddress:\n{contact.StreetAddress} \n{contact.City}, {contact.State} {contact.Zip} " +
                    $"\nBirthday: {contact.BirthdayFormatted}");
                Console.WriteLine($"Contact ID: {theID - 1}");

                if (contact.AddToFavorites == true)
                {
                    Console.WriteLine("This is a Favorite Contact!");
                }

                Console.WriteLine();

            }
            ContactChoice();
           
        }

        public static void ContactChoice()
        {
            string choice;
            string[] RemoveExit = { "1. Remove Contact", "2. Update Contact", "3. Add contact to favorites", "4. Add New Contact", "5. Go back" };

            do
            {
                Console.WriteLine("Do you want to (1) Remove Contact, (2) Update Contact, (3) Add contact to favorites, (4) Add New Contact, (5) Go back");
                RemoveExit[0] = "1";
                RemoveExit[1] = "2";
                RemoveExit[2] = "3";
                RemoveExit[3] = "4";
                RemoveExit[4] = "5";
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Remove contact: Enter Contact's ID number");
                        Console.WriteLine("**If contact is a favorite it must be removed from that list as well**");
                        int userInput = int.Parse(Console.ReadLine());
                        Contact.ContactsList.Remove(Contact.ContactsList[userInput]);
                        Console.WriteLine($"Contact Removed");
                        break;
                    case "2":
                        UpdateContQuestions();
                        break;
                    case "3":
                        Console.WriteLine("Add contact to favorites: Enter Contact's ID number");
                        int userInput1 = int.Parse(Console.ReadLine());
                        Favorite.FavoritesList.Add(Contact.ContactsList[userInput1]);
                        Console.WriteLine("Contact Added To Favorites");
                        break;
                    case "4":
                        AddContact();
                        ListRegContact();
                        break;
                }

            } while (choice != RemoveExit[4]);

        }

        /***********************ADDING CONTACTS********************/
        public static void AddContact()
        {
            Console.WriteLine("Create Contact\n");

            Contact contact = new Contact();
            Console.WriteLine("Enter All Fields");
            Console.WriteLine();
            Console.Write("Please enter their first name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Please enter their last name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Please enter their 10 digit phone number: ");
            contact.NumberFormatted = Console.ReadLine();
            Console.Write("Please enter their street address: ");
            contact.StreetAddress = Console.ReadLine();
            Console.Write("Please enter their city: ");
            contact.City = Console.ReadLine();
            Console.Write("Please enter their state: ");
            contact.State = Console.ReadLine();
            Console.Write("Please enter their zip code: ");
            contact.Zip = Console.ReadLine();
            Console.Write("Please enter their birthday(Ex. 01012020): ");
            contact.BirthdayFormatted = Console.ReadLine();
            Console.Write("Do you want to add them to your favorites?(true or false): ");



            try
            {
                contact.AddToFavorites = bool.Parse(Console.ReadLine());
                Console.WriteLine();


                if (contact.AddToFavorites == true)
                {

                    Favorite.FavoritesList.Add(contact);
                    Contact.ContactsList.Add(contact);
                }
                else
                {
                    Contact.ContactsList.Add(contact);

                }
            }
            catch
            {
                ConsoleLogged.InvalidEntry();
            }

            Console.WriteLine();

        }

        /*******************UPDATE CONTACTS*********************/
        public static void UpdateContQuestions()
        {
            Console.WriteLine("Update Contact: Enter Contact's ID number");
            int userInput = int.Parse(Console.ReadLine());
            var cont = Contact.ContactsList[userInput];
            Console.WriteLine("Enter All Fields");
            Console.WriteLine();
            Console.Write("Update First Name: ");
            cont.FirstName = Console.ReadLine();
            Console.Write("Update Last Name: ");
            cont.LastName = Console.ReadLine();
            Console.Write("Update Phone Number: ");
            cont.NumberFormatted = Console.ReadLine();
            Console.Write("Update Street Address: ");
            cont.StreetAddress = Console.ReadLine();
            Console.Write("Update City: ");
            cont.City = Console.ReadLine();
            Console.Write("Update State: ");
            cont.State = Console.ReadLine();
            Console.Write("Update Zip: ");
            cont.Zip = Console.ReadLine();
            Console.Write("Update Birthday: ");
            cont.BirthdayFormatted = Console.ReadLine();
            try
            {
                Console.Write("Update Do You Want To Add To Favorites? (true) or (false): ");
                cont.AddToFavorites = bool.Parse(Console.ReadLine());
                //if (cont.AddToFavorites == true) { Favorite.FavoritesList.Add(ContactsList[userInput]); }
            }
            catch
            {
                ConsoleLogged.InvalidEntry();
            }

        }

       
    }
}
