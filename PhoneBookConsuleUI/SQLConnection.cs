using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Configuration;
using System.Data;
using Dapper;
using System.Linq;

namespace PhoneBookConsuleUI
{
    class SQLConnection
    {
       //public static List<Contact> LoadContact()
       // {
       //     using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
       //     {
       //         var output = cnn.Query<Contact>("SELECT * FROM Contacts");
       //         return output.ToList();
       //     }
       // }
        //public static void SaveContact(string firstname, string lastName, string phone, string street, string city, string state, string zip, string birthday, bool fav) //Contact contact)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        cnn.Execute("INSERT INTO contacts (FirstName, LastName, PhoneNumber, StreetAddress, City, State, Zip, Birthday, Favorite) " +
        //            "VALUES (@FirstName, @LastName, @PhoneNumber, @StreetAddress, @City, @State, @Zip, @Birthday, @Favorite)", contact);
        //            //new { FirstName = firstname, LastName = lastName, PhoneNumber = phone, StreetAddress = street, City = city, State = state, Zip = zip, Birthday = birthday, Favorite = fav });
        //    }

            
        //}
        //private static string LoadConnectionString(string id = "Default")
        //{
        //    return ConfigurationManager.ConnectionStrings[id].ConnectionString; 
        //}
    }
}
