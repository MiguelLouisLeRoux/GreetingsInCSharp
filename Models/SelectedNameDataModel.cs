using System;

namespace GreetingsInCSharp.Models
{
    public class SelectedNameDataModel
    {
        public string theName {get; set;}

        public string language {get; set;}

        public DateTime theTime {get; set;}

        public SelectedNameDataModel (string TheName, string Language, DateTime TheTime)
        {
            theName = TheName;
            language = Language;
            theTime = TheTime;
        }
    }
}