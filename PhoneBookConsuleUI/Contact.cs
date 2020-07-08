using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Markup;
using Newtonsoft.Json;

namespace PhoneBookConsuleUI
{
    public class Contact 
    {

        public static List<Contact> ContactsList = new List<Contact>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _phoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        private string _birthday { get; set; } 
        public bool AddToFavorites { get; set; }


        public string NumberFormatted
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "($1)$2-$3");
            }
        }
        public string BirthdayFormatted
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = Regex.Replace($"{value}", @"(\d{2})(\d{2})(\d{4})", "$1/$2/$3");
            }
        }

        public Contact()
        {

        }
        public Contact(string firstName, string lastName, string phoneNumber, string streetAdd, string city, string state, string zip, string birthdayDay, bool addToFavorites)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.NumberFormatted = phoneNumber;
            this.StreetAddress = streetAdd;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.BirthdayFormatted = birthdayDay;
            this.AddToFavorites = addToFavorites;
        }

        
    }
}
