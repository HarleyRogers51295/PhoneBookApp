using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsListApp.Models
{
    public class ContactsRepository : IContactRepository
    {

        //conection methods
        private readonly IDbConnection _connection;

        public ContactsRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        //this is where the category is picked
        public Contact AssignCategory()
        {
            var categoryList = GetCategories();
            var contact = new Contact();
            contact.CategoryID = categoryList;

            return contact;
        }

        //selects all from the categories
        public IEnumerable<Category> GetCategories()
        {
            return _connection.Query<Category>("SELECT * FROM categories;");
        }

        //displays all contacts
        public IEnumerable<Contact> GetAllContacts()
        {
            var depos = _connection.Query<Contact>("SELECT * FROM contacts ORDER BY categoryID DESC");
            return depos;
        }

        //displays one contact
        public Contact GetContact(int id)
        {
                return (Contact)_connection.QuerySingle<Contact>("SELECT * FROM contacts WHERE ID = @id", new { ID = id });
        }


        //creates a contact
        public void CreateContact(Contact contactToInsert)
        {
            _connection.Execute("INSERT INTO contacts (FirstName, LastName, PhoneNumber, StreetAddress, City, State, Zip, Birthday, CategoryID) " +
                "VALUES (@firstName, @lastName, @phoneNumber, @streetAddress, @city, @state, @zip, @birthday, @categoryID)", 
                 new
                 {
                     firstName = contactToInsert.FirstName,
                     lastName = contactToInsert.LastName,
                     phoneNumber = contactToInsert.NumberFormatted,
                     streetAddress = contactToInsert.StreetAddress,
                     city = contactToInsert.City,
                     state = contactToInsert.State,
                     zip = contactToInsert.Zip,
                     birthday = contactToInsert.BirthdayFormatted,
                     categoryID = contactToInsert.CategoryID
                 });
        }
        //updates the selected contact
        public void UpdateContact(Contact contact)
        {
            _connection.Execute($"UPDATE contacts SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber, StreetAddress = @streetAddress, " +
                $"City = @city, State = @state, Zip = @zip, Birthday = @birthday, CategoryID = @categoryID WHERE ID = @id",
                new
                {
                    firstName = contact.FirstName,
                    lastName = contact.LastName,
                    phoneNumber = contact.NumberFormatted,
                    streetAddress = contact.StreetAddress,
                    city = contact.City,
                    state = contact.State,
                    zip = contact.Zip,
                    birthday = contact.BirthdayFormatted,
                    categoryID = contact.CategoryID
                });
        }

        //delets the selected contact
        public void DeleteContact(Contact contact)
        {
            _connection.Execute("DELETE FROM contacts WHERE ID = @id;", new { id = contact.ID });
        }
        
    }
}
