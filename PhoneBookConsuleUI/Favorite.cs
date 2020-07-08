using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace PhoneBookConsuleUI
{
    public class Favorite : Contact
    {
        public static List<Contact> FavoritesList = new List<Contact>();


        public Favorite(string firstName, string lastName, string phoneNumber, string streetAdd, string city, string state, string zip, string birthdayDay, bool addToFavorites)
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
