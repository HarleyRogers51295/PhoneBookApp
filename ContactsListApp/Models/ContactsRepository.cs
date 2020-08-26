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
            contact.CategoryName = categoryList;

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
            var depos = _connection.Query<Contact>("SELECT * FROM contacts LEFT JOIN categories ON contacts.CategoryName = categories.categoryName ORDER BY categoryID DESC");
            return depos;   //SELECT * FROM contacts FULL OUTER JOIN categories ON contacts.categoryID = categories.categoryID ORDER BY contacts.categoryID DESC
        }
        public IEnumerable<Contact> GetAllCategories()
        {
            var depos = _connection.Query<Contact>("SELECT * FROM categories ORDER BY categoryID DESC");
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
            _connection.Execute("INSERT INTO contacts (FirstName, LastName, PhoneNumber, StreetAddress, City, State, Zip, Birthday, CategoryID, CategoryName) " +
                "VALUES (@firstName, @lastName, @phoneNumber, @streetAddress, @city, @state, @zip, @birthday, @categoryID, @categoryName)", 
                 new
                 {
                     firstName = contactToInsert.FirstName,
                     lastName = contactToInsert.LastName,
                     phoneNumber = contactToInsert.PhoneNumber,
                     streetAddress = contactToInsert.StreetAddress,
                     city = contactToInsert.City,
                     state = contactToInsert.State,
                     zip = contactToInsert.Zip,
                     birthday = contactToInsert.Birthday,
                     categoryID = contactToInsert.CategoryID,
                     categoryName = contactToInsert.CategoryName
                 });
        }
        //updates the selected contact
        public void UpdateContact(Contact contact)
        {
            _connection.Execute($"UPDATE contacts SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber, StreetAddress = @streetAddress, " +
                $"City = @city, State = @state, Zip = @zip, Birthday = @birthday, CategoryID = @categoryID, CategoryName = @categoryName WHERE ID = @id",
                new
                {
                    firstName = contact.FirstName,
                    lastName = contact.LastName,
                    phoneNumber = contact.PhoneNumber,
                    streetAddress = contact.StreetAddress,
                    city = contact.City,
                    state = contact.State,
                    zip = contact.Zip,
                    birthday = contact.Birthday,
                    categoryID = contact.CategoryID,
                    categoryName = contact.CategoryName,
                    id = contact.ID

                });
        }

        //delets the selected contact
        public void DeleteContact(Contact contact)
        {
            _connection.Execute("DELETE FROM contacts WHERE ID = @id;", new { id = contact.ID });
        }
        
    }
}
