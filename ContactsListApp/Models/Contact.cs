using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsListApp.Models
{
    public class Contact
    {
      //here is all our parameters for our contacts
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            private string _phoneNumber;
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            private string _birthday;

        //public IEnumerable<DateTime> Birthday { get; set; }
        //public IEnumerable<Date> Birthday { get; set; }
        public IEnumerable<Category> CategoryID { get; set; }
        public IEnumerable<Category> CategoryName { get; set; }

        //this formats the phone number
            public string PhoneNumber
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
        //this formats the numbers for birthday
        public string Birthday
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
        //here is our default and perameratized constructor
        public Contact()
            {

            }
            public Contact(string firstName, string lastName, string phoneNumber, string streetAdd, string city, string state, string zip, /*IEnumerable<Date>*/string birthdayDay, IEnumerable<Category> catID)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.PhoneNumber = phoneNumber;
                this.StreetAddress = streetAdd;
                this.City = city;
                this.State = state;
                this.Zip = zip;
                this.Birthday = birthdayDay;
                this.CategoryID = catID;
            }



        }
    }  
