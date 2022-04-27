using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace Firebase.Login
{
    public class Login
    {

        string userID;
        string companyName;

        bool hasSent = false;

        public bool hasReturned;
        public string message;

        // On button press; once both fields have been filled out, this process will begin.
        // On success it will load the main program
        // On fail it will display a message
        public async Task HandleLogin(string userName, string pass)
        {

            //hasReturned = true;
            if (userName == "" || pass == "") return;
            message = "V";

        }

    }

    public class MessageBase
    {
        public string Author { get; set; }

        public string Content { get; set; }
    }

    public class InboundMessage
    {
        public bool isValid;
    }
}
