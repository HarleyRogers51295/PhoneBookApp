using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PhoneBookConsuleUI
{
    public class AppFunction
    {



        //#region Intro
        //public static void Intro()
        //{
        //    ConsoleLogged.WelcomeMessage(); //Displays welcome message.
        //    do
        //    {
        //        ConsoleLogged.EnterUserInfoNote(); //Asks the user to enter their Data
        //        UserInfoInput(); //Takes in the user's Data
        //        ConsoleLogged.FirstContactNote(); //Asks the user to enter first contact
        //        AddContact(); //takes in the contact's data
        //    } while (ContactsRepository.contactsList == null);
        //}
        //#endregion

        //#region Execute
        //public static void Execute()
        //{
        //    //Contact contact = new Contact(); //Makes an instance of a Contact

        //    string choice; //Users choid of what to do
        //    string[] CreateOrExit = { "1. Create New Contact", "\n2. View Favorites ", "\n3. View Contacts", "\n4. User Info", "\n5. Exit Program" }; //Creates the array of choices
        //    do
        //    {
        //        //Displays the choices to the user
        //        Console.WriteLine("Enter '1' to create contact. \nEnter '2' to View favorites. \nEnter '3' to view All contacts. \nEnter '4' View/Update Your Info. \nEnter '5' To Exit Program ");
        //        CreateOrExit[0] = "1";
        //        CreateOrExit[1] = "2";
        //        CreateOrExit[2] = "3";
        //        CreateOrExit[3] = "4";
        //        CreateOrExit[4] = "5";
        //        choice = Console.ReadLine(); //User choice input
        //        Console.WriteLine();

        //        if (choice == CreateOrExit[0])
        //        {
        //            AddContact(); //Takes Contacts data
        //        }
        //        else if (choice == CreateOrExit[1])
        //        {
        //            ListFaveContact(); //Lists out the Favorites contacts
        //        }
        //        else if (choice == CreateOrExit[2])
        //        {
        //            ListRegContact(); //Lists out regular contacts
        //        }
        //        else if (choice == CreateOrExit[3])
        //        {
        //            UserInformation(); //List the Users information
        //        }

        //    } while (choice != CreateOrExit[4]); //Exits the program



        //}
        //#endregion

        //#region UserInformation
        //public static void UserInformation()
        //{

        //    ObjectIDGenerator obj = new ObjectIDGenerator(); //Creates an object ID
        //    bool isFirstTime;


        //    Console.WriteLine("Your Information\n"); //Displays User info
        //    foreach (UserInfo user in UserInfo.userInfo)
        //    {
        //        long theID = obj.GetId(user, out isFirstTime);
        //        Console.WriteLine($"Name: {user.FirstName} {user.LastName}\nPhone Number: {user.NumberFormatted}" +
        //            $"\nAddress: {user.StreetAddress}\n{user.City}, {user.State} {user.Zip}\nBirthday: {user.BirthdayFormatted}\n");
        //        Console.WriteLine($"User ID: {theID - 1}\n");
        //    }
        //    string choice;
        //    string[] updateUserInfo = { "(1) Update User Infor", "(2) Exit" };

        //    do //user choice to update info or go back
        //    {
        //        Console.WriteLine("Do you want to (1) Update Your Information, (2) Go back");
        //        updateUserInfo[0] = "1";
        //        updateUserInfo[1] = "2";

        //        choice = Console.ReadLine();

        //        if (choice == updateUserInfo[0])
        //        {
        //            UserInfoUpdate(); //allows user to update their info
        //        }
        //    } while (choice != updateUserInfo[1]);

        //}
        //#endregion

        //#region UserInfoInput
        //public static void UserInfoInput() //inout of user info
        //{
        //    ObjectIDGenerator obj = new ObjectIDGenerator();
        //    bool isFirstTime;
        //    UserInfo user = new UserInfo();
        //    long theID = obj.GetId(user, out isFirstTime);
        //    Console.WriteLine("Enter All Fields");
        //    Console.WriteLine();
        //    Console.Write("Please enter your first name: ");
        //    user.FirstName = Console.ReadLine();
        //    Console.Write("Please enter your last name: ");
        //    user.LastName = Console.ReadLine();
        //    Console.Write("Please enter your 10 digit phone number: ");
        //    user.NumberFormatted = Console.ReadLine();
        //    Console.Write("Please enter your street address: ");
        //    user.StreetAddress = Console.ReadLine();
        //    Console.Write("Please enter your city: ");
        //    user.City = Console.ReadLine();
        //    Console.Write("Please enter your state: ");
        //    user.State = Console.ReadLine();
        //    Console.Write("Please enter your zip code: ");
        //    user.Zip = Console.ReadLine();
        //    Console.Write("Please enter your birthday(Ex. 01012020): ");
        //    user.BirthdayFormatted = Console.ReadLine();
        //    Console.WriteLine($"User ID: {theID - 1}\n");
        //    UserInfo.userInfo.Add(user);
        //}
        //#endregion

        //#region UserInfoUpdate
        //public static void UserInfoUpdate() //update of user info
        //{
        //    UserInfo user = new UserInfo();
        //    Console.WriteLine("Update Your Info: Enter Your ID Number");
        //    int userInput = int.Parse(Console.ReadLine());
        //    var userUpdate = UserInfo.userInfo[userInput];
        //    Console.WriteLine("Enter All Fields");
        //    Console.WriteLine();
        //    Console.Write("Please enter your first name: ");
        //    userUpdate.FirstName = Console.ReadLine();
        //    Console.Write("Please enter your last name: ");
        //    userUpdate.LastName = Console.ReadLine();
        //    Console.Write("Please enter your 10 digit phone number: ");
        //    userUpdate.NumberFormatted = Console.ReadLine();
        //    Console.Write("Please enter your street address: ");
        //    userUpdate.StreetAddress = Console.ReadLine();
        //    Console.Write("Please enter your city: ");
        //    userUpdate.City = Console.ReadLine();
        //    Console.Write("Please enter your state: ");
        //    userUpdate.State = Console.ReadLine();
        //    Console.Write("Please enter your zip code: ");
        //    userUpdate.Zip = Console.ReadLine();
        //    Console.Write("Please enter your birthday(Ex. 01012020): ");
        //    userUpdate.BirthdayFormatted = Console.ReadLine();
        //    UserInfo.userInfo.Remove(user);
        //}
        //#endregion



        //#region ListFaveContact
        //public static void ListFaveContact() //lists contacts in favorites list
        //{
        //    Console.WriteLine("Favorite Contacts\n");

        //    bool isEmpty = !Favorite.FavoritesList.Any(); //if no fav contacts notifies user
        //    if (isEmpty)
        //    {
        //        ConsoleLogged.NoContacts();
        //    }

        //    ObjectIDGenerator obj = new ObjectIDGenerator();
        //    bool isFirstTime;

        //    foreach (Contact contact in Favorite.FavoritesList) //display the fav contacts
        //    {
        //        long theID = obj.GetId(contact, out isFirstTime);
        //        Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} \nPhone Number: {contact.NumberFormatted}" +
        //            $"\nAddress:\n{contact.StreetAddress} \n{contact.City}, {contact.State} {contact.Zip} " +
        //            $"\nBirthday: {contact.BirthdayFormatted}");
        //        Console.WriteLine($"Contact ID: {theID - 1}\n");

        //    }
        //    string choice; //user choice to remove contact, update contact or go back
        //    string[] RemoveExit = { "1. Remove Contact From Favorites List", "2. Update Contact", "3. Go back" };

        //    do
        //    {
        //        Console.WriteLine("Do you want to (1) Remove Contact From Favorites List, (2) Update Contact, (3) Go back");
        //        RemoveExit[0] = "1";
        //        RemoveExit[1] = "2";
        //        RemoveExit[2] = "3";

        //        choice = Console.ReadLine();

        //        if (choice == RemoveExit[0])
        //        {
        //            Console.WriteLine("Remove contact from favorites: Enter Contact's ID number"); //removes contact from fav list
        //            int userInput = int.Parse(Console.ReadLine());
        //            Favorite.FavoritesList.Remove(Favorite.FavoritesList[userInput]);
        //            Console.WriteLine($"Contact Removed\n");
        //        }
        //        else if (choice == RemoveExit[1])
        //        {
        //            UpdateContQuestions(); //updates contact 
        //            ListFaveContact(); //list the contacts in faves list
        //        }


        //    } while (choice != RemoveExit[2]);
        //}
        //#endregion

        
        //#region ListRegContact
        //public static void ListRegContact() //list the regular contacts in contactslist
        //{
        //    Console.WriteLine("All Contacts\n");

            
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        ContactsRepository repo = new ContactsRepository(cnn);
        //        ContactsRepository.Print(repo.ListAllContacts());
                
        //    }

           
        //    //bool isEmpty = !ContactsList.contactsList.Any(); //checks to see if there are contacts in the list
        //    //if (isEmpty)
        //    //{
        //    //    ConsoleLogged.NoContacts(); //displays to user contact list is empty
        //    //}

        //    //ObjectIDGenerator obj = new ObjectIDGenerator();
        //    //bool isFirstTime;


        //    //foreach (Contact contact in ContactsList.contactsList) //if not empty, this displays the contacts
        //    //{
               

        //    //    long theID = obj.GetId(contact, out isFirstTime);
        //    //    Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} \nPhone Number: {contact.NumberFormatted}" +
        //    //        $"\nAddress:\n{contact.StreetAddress} \n{contact.City}, {contact.State} {contact.Zip} " +
        //    //        $"\nBirthday: {contact.BirthdayFormatted}");
        //    //    Console.WriteLine($"Contact ID: {theID - 1}");

        //    //    if (Favorite.FavoritesList.Contains(contact) == true)
        //    //    {
        //    //        Console.WriteLine("This is a Favorite Contact!");
        //    //    }

        //    //    Console.WriteLine();

        //    //}
        //    ContactChoice(); //this is the choice for contact navigation

        //}
        //#endregion

        //#region ContactChoice
        //public static void ContactChoice() //this is the choice for contact navigation
        //{
        //    string choice;
        //    string[] RemoveExit = { "1. Remove Contact", "2. Update Contact", "3. Add contact to favorites", "4. Add New Contact", "5. Go back" };

        //    do
        //    {  //lists choices for user
        //        Console.WriteLine("Do you want to (1) Remove Contact, (2) Update Contact, (3) Add contact to favorites, (4) Add New Contact, (5) Go back");
        //        RemoveExit[0] = "1";
        //        RemoveExit[1] = "2";
        //        RemoveExit[2] = "3";
        //        RemoveExit[3] = "4";
        //        RemoveExit[4] = "5";
        //        choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1": //removes contact
        //                Console.WriteLine("Remove contact: Enter Contact's ID number");
        //                Console.WriteLine("**If contact is a favorite it must be removed from that list as well**");
        //                int userInput = int.Parse(Console.ReadLine());
        //                ContactsRepository.contactsList.Remove(ContactsRepository.contactsList[userInput]);
        //                Console.WriteLine($"Contact Removed");
        //                break;
        //            case "2": //updates contact
        //                UpdateContQuestions();
        //                break;
        //            case "3": //adds already existant contact to favorites list
        //                Console.WriteLine("Add contact to favorites: Enter Contact's ID number");
        //                int userInput1 = int.Parse(Console.ReadLine());
        //                Favorite.FavoritesList.Add(ContactsRepository.contactsList[userInput1]);
        //                Console.WriteLine("Contact Added To Favorites");
        //                break;
        //            case "4": //adds contact
        //                AddContact();
        //                ListRegContact(); //lists contacts
        //                break;
        //        }

        //    } while (choice != RemoveExit[4]);

        //}
        //#endregion


        //#region AddContact
        //public static void AddContact() //adds contact, request user inter the infrormation needed for contact
        //{

        //    Console.WriteLine("Create Contact\n");

        //    Contact contact = new Contact();
        //    Console.WriteLine("Enter All Fields");
        //    Console.WriteLine();
        //    Console.Write("Please enter their first name: ");
        //    contact.FirstName = Console.ReadLine();
        //    Console.Write("Please enter their last name: ");
        //    contact.LastName = Console.ReadLine();
        //    Console.Write("Please enter their 10 digit phone number: ");
        //    contact.NumberFormatted = Console.ReadLine();
        //    Console.Write("Please enter their street address: ");
        //    contact.StreetAddress = Console.ReadLine();
        //    Console.Write("Please enter their city: ");
        //    contact.City = Console.ReadLine();
        //    Console.Write("Please enter their state: ");
        //    contact.State = Console.ReadLine();
        //    Console.Write("Please enter their zip code: ");
        //    contact.Zip = Console.ReadLine();
        //    Console.Write("Please enter their birthday(Ex. 01012020): ");
        //    contact.BirthdayFormatted = Console.ReadLine();
        //    Console.Write("Do you want to add them to your favorites?(true or false): ");

        //    var answer = Console.ReadLine();
        //    if (answer.ToLower() == "yes")
        //    {
        //        contact.AddToFavorites = true;
        //    }
        //    else
        //    {
        //        contact.AddToFavorites = false;
        //    }

        //    Console.WriteLine();



        //    if (contact.AddToFavorites == true) //if favorite is true, add to favorits list and reg list
        //    {
        //        ContactsRepository.CreateContact(contact.FirstName, contact.LastName, contact.NumberFormatted, contact.StreetAddress, 
        //            contact.StreetAddress, contact.City, contact.Zip, contact.BirthdayFormatted, contact.AddToFavorites);

        //        //Favorite.FavoritesList.Add(contact);
        //       // ContactsList.contactsList.Add(contact);
        //    }
        //    else
        //    {
        //       ContactsRepository.CreateContact(contact.FirstName, contact.LastName, contact.NumberFormatted, contact.StreetAddress,
        //           contact.StreetAddress, contact.City, contact.Zip, contact.BirthdayFormatted, contact.AddToFavorites);

        //        //ContactsList.contactsList.Add(contact);

        //    }

        //    Console.WriteLine();


        //}

        //#endregion

        //#region UpdateContQuestions
        //public static void UpdateContQuestions()  //update questions for contact updates
        //{
            
        //        Console.WriteLine("Update Contact: Enter Contact's ID number");
        //        int userInput = int.Parse(Console.ReadLine());
        //        var cont = ContactsRepository.contactsList[userInput];
           

        //    string choice;
        //    string[] updateContact = { "(1)First Name", "(2)Last Name", "(3)Phone Number", "(4)Street Address", "(5)City", "(6)State", "(7)Zip", "(8)Birthday", "(9)Favorite", "(10)Go Back" };

        //    do
        //    {
        //        Console.WriteLine($"Contact: {cont.FirstName} {cont.LastName} \nPhone Number: {cont.NumberFormatted}" +
        //           $"\nAddress:\n{cont.StreetAddress} \n{cont.City}, {cont.State} {cont.Zip} " +
        //           $"\nBirthday: {cont.BirthdayFormatted}");
                

        //        if (Favorite.FavoritesList.Contains(cont) == true)
        //        {
        //            Console.WriteLine("This is a Favorite Contact!");
        //        }

        //        Console.WriteLine();

        //        Console.WriteLine("Enter the field you want to update?");
        //        Console.WriteLine("(1)First Name, (2)Last Name, (3)Phone Number, (4)Street Address, (5)City, \n(6)State, (7)Zip, (8)Birthday, or (9)Go Back");
                
        //        updateContact[0] = "1";
        //        updateContact[1] = "2";
        //        updateContact[2] = "3";
        //        updateContact[3] = "4";
        //        updateContact[4] = "5";
        //        updateContact[5] = "6";
        //        updateContact[6] = "7";
        //        updateContact[7] = "8";
        //        updateContact[8] = "9";
                
        //        choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1":
        //                Console.Write("Update First Name: ");
        //                cont.FirstName = Console.ReadLine();
        //                break;
        //            case "2":
        //                Console.Write("Update Last Name: ");
        //                cont.LastName = Console.ReadLine();
        //                break;
        //            case "3":
        //                Console.Write("Update Phone Number: ");
        //                cont.NumberFormatted = Console.ReadLine();
        //                break;
        //            case "4":
        //                Console.Write("Update Street Address: ");
        //                cont.StreetAddress = Console.ReadLine();
        //                break;
        //            case "5":
        //                Console.Write("Update City: ");
        //                cont.City = Console.ReadLine();
        //                break;
        //            case "6":
        //                Console.Write("Update State: ");
        //                cont.State = Console.ReadLine();
        //                break;
        //            case "7":
        //                Console.Write("Update Zip: ");
        //                cont.Zip = Console.ReadLine();
        //                break;
        //            case "8":
        //                Console.Write("Update Birthday: ");
        //                cont.BirthdayFormatted = Console.ReadLine();
        //                break;
                    
        //        }

        //    } while(choice != "9");


        //    #endregion

        //}
        //private static string LoadConnectionString(string id = "Default")
        //{
        //    return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        //}
    }
}
