using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace PhoneBookConsuleUI
{
    public class ContactsRepository : IContactRepository
    {

        //private static string LoadConnectionString(string id = "Default")
        //{
        //    return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        //}

        //public static List<Contact> contactsList = new List<Contact>();

        //private readonly IDbConnection _connection;

        //public ContactsRepository(IDbConnection connection)
        //{
        //    _connection = connection;
        //}

        //public Contact GetContact(int id)
        //{
        //    return (Contact)_connection.QuerySingle<Contact>("SELECT * FROM contacts WHERE ID = @id", new {ID = id });
        //}

        //public IEnumerable<Contact> GetAllContacts()
        //{
        //   // using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //  //  {  cnn.
        //        var depos = _connection.Query<Contact>("SELECT * FROM contacts ORDER BY favorite DESC");
        //        return depos;
        //  //  }
        //}


        //public void CreateContact(string firstname, string lastName, string phone, string street, string city, string state, string zip, string birthday, bool fav) //Contact contact)
        //{
        //   // using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //   // {  cnn.
        //        _connection.Execute("INSERT INTO contacts (FirstName, LastName, PhoneNumber, StreetAddress, City, State, Zip, Birthday, Favorite) " +
        //            "VALUES (@FirstName, @LastName, @PhoneNumber, @StreetAddress, @City, @State, @Zip, @Birthday, @Favorite)", //contact);
        //        new { FirstName = firstname, LastName = lastName, PhoneNumber = phone, StreetAddress = street, City = city, State = state, Zip = zip, Birthday = birthday, Favorite = fav });
        //  //  }


        //}

        //public void UpdateContact(Contact contact)
        //{
        //    _connection.Execute($"UPDATE contacts SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, StreetAddress = @StreetAddress, " +
        //        $"City = @City, State = @State, Zip = @Zip, Birthday = @Birthday, Favorite = @Favorite WHERE ID = @id", 
        //        new { FirstName = contact.FirstName, LastName = contact.LastName, PhoneNumber = contact.NumberFormatted, StreetAddress = contact.StreetAddress, 
        //            City = contact.City, State = contact.State, Zip = contact.Zip, Birthday = contact.BirthdayFormatted, Favorite = contact.AddToFavorites});
        //}


        //public void DeleteContact(Contact contact)
        //{
        //    _connection.Execute("DELETE FROM contacts WHERE ID = @id;", new { id = contact.ID });
        //}


        //public static void Print(IEnumerable<Contact> depos)
        //{
        //    foreach (var depo in depos)
        //    {
        //        Console.WriteLine($"Id: {depo.ID} Name: {depo.FirstName}{depo.LastName} Phone Number: ${depo.NumberFormatted} Address: {depo.StreetAddress}, {depo.City}" +
        //            $", {depo.State}, {depo.Zip} Birthday: {depo.BirthdayFormatted} Favorite: {depo.AddToFavorites}");
        //    }

        //}

        

        


       
        











        //public ContactsList()
        //{
        //    LoadContactsList();
        //}

        //private void LoadContactsList()
        //{
        //    contactsList = SQLConnection.LoadContact();
        //}

        //private void AddContact()
        //{
        //    //Contact p = new Contact();

        //    //SQLConnection.SaveContact(p);

        //    foreach (var contact in contactsList)
        //    {
        //        if (contactsList.Contains(contact) != true)
        //        {
        //            SQLConnection.SaveContact(contact);
        //        }

        //    }

        //ompare static list to this list if(this contains..)
        //if contact is int contacts list already, no not add...
        //}


    }
}
