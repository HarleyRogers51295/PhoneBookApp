using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsListApp.Models
{
    public interface IContactRepository
    {
        //displays contacts
        public IEnumerable<Contact> GetAllContacts();
        //displays one contact
        public Contact GetContact(int id);
        //creates a contact
        public void CreateContact(Contact contactToInsert); //string firstName, string lastname, string phoneNumber, string street, string city, string state, string zip, string birthday, bool CategoryID); //Contact contact); 
        //updates a contact
        public void UpdateContact(Contact contact);
        //these are the catigory selectors
        public IEnumerable<Category> GetCategories();
        public Contact AssignCategory();
        //this deletes the contact selected
        public void DeleteContact(Contact contact);
    }
    }
