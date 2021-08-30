using System.Collections.Generic;

namespace GreetingsInCSharp.Models
{
    public interface IGreetings
    {
        string NameVal {get; set;}
    
        string Language {get; set;}

        int count {get; set;}

        string Exception {get; set;}

        string SuccessMessage {get; set;}

        string TheGreeting {get; set;}

        string SelectedName {get; set;}

        int SelectedNameGreetCount {get; set;}

        Dictionary<string, int> GetNamesList {get;}

        List<SelectedNameDataModel> GetSelectedNamesData {get;}

        void GetNameAndLanguage(string theName, string theLanguage);

        void GreetName();

        void SetSellectedNameValues(string theSelectedName);

        void ClearMessages();


        void ClearGreets();

        void RemoveName(string theNameValue);
    }
}