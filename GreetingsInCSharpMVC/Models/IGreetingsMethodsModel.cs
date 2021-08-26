using System;
using System.Collections.Generic;

namespace GreetingsInCSharp.Models
{
    interface IGreetingsMethods
    {
        void GetNameAndLanguage(string theName, string theLanguage);

        void GreetName();

        void SetSellectedNameValues(string theSelectedName);

        void ClearMessages();

        void ClearGreets();

        void RemoveName(string theNameValue);

    }

}