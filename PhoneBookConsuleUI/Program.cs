using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

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


//When this is all completed.
//Save the user contacts to a file like JSON or a txt file.
//Add a GUI(Graphical User Interface) to the project. (Easy) use win forms, or (hard) WPF > These are window applications. 