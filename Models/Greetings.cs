using System;
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

        public static string theGreeting {get; set;}

        public static string selectedName {get; set;}

        public static int selectedNameGreetCount {get; set;}

        public static List<SelectedNameDataModel> SelectedNamesData = new List<SelectedNameDataModel>();

        public void GetNameAndLanguage(string theName, string theLanguage)
        {
            if (string.IsNullOrEmpty(theName) && string.IsNullOrEmpty(theLanguage))
            {
                exception = "Enter a name, then select a language.";
                nameVal = "";
                language = "";
                theGreeting = "";
            }
            else if (string.IsNullOrEmpty(theLanguage) && !string.IsNullOrEmpty(theName))
            {
                exception = "Select a language";
                nameVal = "";
                language = "";
                theGreeting = "";
            }
            else if (string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                exception = "Enter a name.";
                nameVal = "";
                language = "";
                theGreeting = "";
            }
            else if (!string.IsNullOrEmpty(theName) && !string.IsNullOrEmpty(theLanguage))
            {
                string upName = char.ToUpper(theName[0]) + theName.Substring(1);
                nameVal = upName.Trim();
                language = theLanguage;
                exception = "";
            }
        }

        public void GreetName()
        {
            if (!string.IsNullOrWhiteSpace(nameVal))
            {
                if (!namesList.ContainsKey(nameVal))
                {
                    namesList.Add(nameVal, 1);
                }
                else if (namesList.ContainsKey(nameVal))
                {
                    namesList[nameVal] += 1;
                }

                if (language == "Portuguese")
                {
                    theGreeting = $"Olá {nameVal}!";
                }
                else if (language == "Swedish")
                {
                    theGreeting = $"Hej {nameVal}!";
                }
                else if (language == "Japanese")
                {
                    theGreeting = $"こんにちは {nameVal}!";
                }
            }

            count = namesList.Count;

            DateTime theGreetTime = DateTime.Now;
            theGreetTime.ToString();
            SelectedNameDataModel greetData = new SelectedNameDataModel(nameVal, language, theGreetTime);
            SelectedNamesData.Add(greetData);
        }

        public void SetSellectedNameValues(string theSelectedName)
        {
            selectedName = theSelectedName;
            selectedNameGreetCount = namesList[theSelectedName];
        }

        public void ClearMessages()
        {
            exception = "";
            theGreeting = "";
            nameVal = "";
        }

        public void ClearGreets()
        {
            count = 0;
            namesList.Clear();
            SelectedNamesData.Clear();
            exception = "";
            theGreeting = "";
            nameVal = "";
            language = "";
        }

        public void RemoveName(string theNameValue)
        {
            for(int i = 0; i < SelectedNamesData.Count; i++)
            {
                var item = SelectedNamesData[i];
                if(item.theName == theNameValue)
                {
                    SelectedNamesData.RemoveAt(i);
                }
            }

            if(namesList.ContainsKey(theNameValue))
            {
                namesList.Remove(theNameValue);
                count = namesList.Count;
            }
        }
    }
}