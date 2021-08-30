using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GreetingsInCSharp.Models
{
    public class GreetingsModel : IGreetings
    {
        private Dictionary<string, int> namesList = new Dictionary<string, int>();

        private List<SelectedNameDataModel> SelectedNamesData = new List<SelectedNameDataModel>();  

        public string NameVal {get; set;}

        public string Language {get; set;}

        public int count {get; set;}

        public string Exception {get; set;}

        public string SuccessMessage {get; set;}

        public string SecondPageSuccessMessage {get; set;}

        public string TheGreeting {get; set;}

        public string SelectedName {get; set;}

        public int SelectedNameGreetCount {get; set;}

        public Dictionary<string, int> GetNamesList
        {
            get {
                return namesList;
            }
        }

        public List<SelectedNameDataModel> GetSelectedNamesData
        {
            get {
                return SelectedNamesData;
            }
        }

        public void GetNameAndLanguage(string theName, string theLanguage)
        {
            string trimmedName = theName;

            if (!string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                trimmedName = theName.Trim();
            }

            Exception = "";
            NameVal = "";
            Language = "";
            TheGreeting = "";
            SuccessMessage = "";

            Regex regexPattern1 = new Regex(@"[A-ZA-z]\s[A-Za-z]+$");
            Regex regexPattern2 = new Regex(@"[A-ZA-z]+$");

            if (string.IsNullOrEmpty(trimmedName) && string.IsNullOrEmpty(theLanguage))
            {
                Exception = "Enter a name, then select a language.";
                return;
            }
            else if (string.IsNullOrEmpty(theLanguage) && !string.IsNullOrEmpty(trimmedName))
            {
                Exception = "Select a language.";
                return;
            }
            else if (string.IsNullOrEmpty(trimmedName) && !string.IsNullOrEmpty(theLanguage))
            {
                Exception = "Enter a name.";
                return;
            }
            else if (regexPattern1.IsMatch(trimmedName) || regexPattern2.IsMatch(trimmedName))
            {
                string upperName = char.ToUpper(trimmedName[0]) + trimmedName.Substring(1);
                NameVal = upperName;
                Language = theLanguage;
                return;
            }
            else
            {
                Exception = "Special characters and digits are not accepted.";
            }
        }

        public void GreetName()
        {
            if (!namesList.ContainsKey(NameVal))
            {
                namesList.Add(NameVal, 1);
            }
            else if (namesList.ContainsKey(NameVal))
            {
                namesList[NameVal] += 1;
            }

            if (Language == "Portuguese")
            {
                TheGreeting = $"Olá {NameVal}!";
            }
            else if (Language == "Swedish")
            {
                TheGreeting = $"Hej {NameVal}!";
            }
            else if (Language == "Japanese")
            {
                TheGreeting = $"こんにちは {NameVal}!";
            }

            count = namesList.Count;

            DateTime theGreetTime = DateTime.Now;
            theGreetTime.ToString();
            SelectedNameDataModel greetData = new SelectedNameDataModel(NameVal, Language, theGreetTime);
            SelectedNamesData.Add(greetData);
        }

        public void SetSellectedNameValues(string theSelectedName)
        {
            SelectedName = theSelectedName;
            SelectedNameGreetCount = namesList[theSelectedName];
            SecondPageSuccessMessage = "";
        }

        public void ClearMessages()
        {
            Exception = "";
            TheGreeting = "";
            NameVal = "";
            SecondPageSuccessMessage = "";
        }

        public void ClearGreets()
        {
            namesList.Clear();
            SelectedNamesData.Clear();
            count = namesList.Count;
            Exception = "";
            TheGreeting = "";
            NameVal = "";
            Language = "";
            SuccessMessage = "All greets succesfully cleared.";
            SecondPageSuccessMessage = "";
        }

        public void RemoveName(string theNameValue)
        {
            for(int i = 0; i < SelectedNamesData.Count; i++)
            {
                var item = SelectedNamesData[i];
                if(item.theName == theNameValue)
                {
                    SelectedNamesData.Remove(item);
                }
            }

            for(int i = 0; i < SelectedNamesData.Count; i++)
            {
                var item = SelectedNamesData[i];
                if(item.theName == theNameValue)
                {
                    SelectedNamesData.Remove(item);
                }
            }

            if(namesList.ContainsKey(theNameValue))
            {
                namesList.Remove(theNameValue);
            }

            count = namesList.Count;

            SecondPageSuccessMessage = $"{theNameValue} has been succesfully removed.";
        }

    }
}