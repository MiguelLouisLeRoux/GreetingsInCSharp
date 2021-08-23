using System.Collections.Generic;

namespace GreetingsInCSharp.Models
{
    public class GreetingsModel
    {
        public static Dictionary<string, int> namesList = new Dictionary<string, int>();
        public static string nameVal {get; set;}

        public static string language {get; set;}
        public static int count {get; set;} 

        public static string exception {get; set;}

        public static string indexSuccessMessage {get; set;}

        public static string namesListSuccessMessage {get; set;}

        public static string theGreeting {get; set;}

        public static string selectedName {get; set;}

        public static int selectedNameGreetCount {get; set;}

        public static List<SelectedNameDataModel> SelectedNamesData = new List<SelectedNameDataModel>();   
    }
}