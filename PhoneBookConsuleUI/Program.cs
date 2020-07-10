using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PhoneBookConsuleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {


            AppFunction.Intro();
        
            AppFunction.Execute();
            
        }
        

    }
}




/* My TODO List.
 * 
 * 
 * ADD NOTES ON WHAT EVERYTHING DOES!! SUPER IMPORTANT!
 * 
 * Connect to JSON
 * make a GUI for the program. 'windows forms' or WPF
 * Implement abstract and/or interface classes & factory pattern
 *              make the contacts the abstract or Iteration. Make a new contactsList class and  put the contacts list there.
 * fix update issues where it makes you fill in all the infromation again.
 *              make the user choose what property they want to update. Do a do while loop with a choice. 
 * fix ID's. Make different than 0,1,2. Might need dictionaries.
 * Auto populate un entered fields with N/A
 * fix issue where favorate is can be added twice
 *              when adding to favorates have it check the ID's and if there is already the existing Id to add the new one and delete the old.
 * turn true or false into Y or N. (use ToLower();)
 *
 */