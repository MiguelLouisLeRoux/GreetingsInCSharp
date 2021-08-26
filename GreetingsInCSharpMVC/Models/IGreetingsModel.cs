using System;
using System.Collections.Generic;

namespace GreetingsInCSharp.Models
{
    interface IGreetingsModel
    {
        // Dictionary<string, int> namesList = new Dictionary<string, int>();
        string nameVal {get; set;}

        string language {get; set;}
        int count {get; set;} 

        string exception {get; set;}

        string indexSuccessMessage {get; set;}

        string namesListSuccessMessage {get; set;}

        string theGreeting {get; set;}

        string selectedName {get; set;}

        int selectedNameGreetCount {get; set;}

        // List<SelectedNameDataModel> SelectedNamesData = new List<SelectedNameDataModel>();
    }
}